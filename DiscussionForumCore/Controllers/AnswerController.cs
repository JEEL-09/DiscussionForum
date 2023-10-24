using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscussionForumCore.Models;
using Microsoft.AspNetCore.Routing;
using System.Security.Claims;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace DiscussionForumCore.Controllers
{
    [Authorize]
    public class AnswerController : Controller
    {

        private readonly IAnswerRepository _answerRepository;
        private readonly UserManager<AppUser> userManager;

        private Task<AppUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);


        public AnswerController(IAnswerRepository answerRepository , UserManager<AppUser> userManager)
        {
            _answerRepository = answerRepository;
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var model = _answerRepository.GetAllAnswers();
            return View(model);
        }

        [HttpGet]
        public async Task<ViewResult> CreateAsync(int id)
        {
            Answer answer = new Answer();
            answer.questionId = id;
            answer.CreateTime = DateTime.Now;
            answer.appUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            Question question = _answerRepository.GetQuestion(id);
            AppUser appUser = await GetCurrentUserAsync();
            answer.Name = appUser.Name;
            answer.ProfilePic = appUser.ProfilePic;
            return View(answer);
        }

        [HttpPost]
        public IActionResult Create(Answer answer1)
        {
            if(ModelState.IsValid)
            {
                Answer new_answer = _answerRepository.Add(answer1);
                return RedirectToAction("Details","Question", new {id = answer1.questionId });
            }
            return View();
        }

        

        public ViewResult Details(int Id)
        {
            Answer answer = _answerRepository.GetAnswer(Id);
            if (answer == null)
            {
                Response.StatusCode = 404;
                return View("Question Not Found", Id);
            }
            dynamic mymodel = new ExpandoObject();
            Question question = _answerRepository.GetQuestion(answer.questionId);
            mymodel.question1 = question;
            mymodel.answer1 = answer;

            return View(mymodel);
        }

        [HttpGet]
        public ViewResult Edit(int Id)
        {
            Answer answer1 = _answerRepository.GetAnswer(Id);
            return View(answer1);
        }

        [HttpPost]
        public IActionResult Edit(Answer answerChanges)
        {
            if (ModelState.IsValid)
            {
                Answer answer1 = _answerRepository.GetAnswer(answerChanges.Id);
                answer1.answer = answerChanges.answer;
                //question.QuestionImage = questionChanges.QuestionImage;
                Answer answer = _answerRepository.Update(answer1);
                return RedirectToAction("Details", "Question", new { id = answer1.questionId });
            }
            return View(answerChanges);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Answer answer = _answerRepository.GetAnswer(Id);
            if (answer == null)
            {
                return NotFound();
            }
            return View(answer);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Id)
        {
            Answer answer = _answerRepository.GetAnswer(Id);
            _answerRepository.Delete(answer.Id); 
            return RedirectToAction("Details", "Question", new { id = answer.questionId });
        }

    }
}
