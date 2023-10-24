using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscussionForumCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
using System.Dynamic;
using DiscussionForumCore.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace DiscussionForumCore.Controllers
{
    [Authorize]

    public class QuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly AppDbContext _context;

        private readonly UserManager<AppUser> userManager;
        private readonly IHostingEnvironment hostingEnvironment;


        private Task<AppUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);



        public QuestionController(IQuestionRepository questionRepository, UserManager<AppUser> userManager, IHostingEnvironment hostingEnvironment,AppDbContext context)
        {
            _questionRepository = questionRepository;
            this.userManager = userManager;
            _context = context;
            this.hostingEnvironment = hostingEnvironment;
        }

        public async Task<IActionResult> Search(string searchString)
        {
            var questions = from q in _context.questions select q;
            //Console.WriteLine("Hello" + searchString);
            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (!string.IsNullOrEmpty(searchString))
            {
                questions = questions.Where(q => q.question.Contains(searchString) || q.category.Contains(searchString)).OrderByDescending(o=>o.CreateTime);
            }
            return View(await questions.AsNoTracking().ToListAsync());
        }

        public IActionResult ViewAnswer(int Id)
        {
            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var answers = _questionRepository.AnswerofQuestion(Id);
            return View(answers);
        }


        public IActionResult Index()
        {
            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var model = _questionRepository.GetAllQuestions();
            return View(model);
        }

        [HttpGet]
        public async Task<ViewResult> CreateAsync()
        {
            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(QuestionViewModel question1)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(question1.Photo != null)
                {
                    string path = Path.Combine(hostingEnvironment.WebRootPath,"images");
                    uniqueFileName = Guid.NewGuid().ToString()+"_"+question1.Photo.FileName;
                    string filepath = Path.Combine(path,uniqueFileName);
                    question1.Photo.CopyTo(new FileStream(filepath, FileMode.Create));
                }
                AppUser appUser = await GetCurrentUserAsync();

                Question question2 = new Question
                {
                    question = question1.question,
                    category = question1.category,
                    PhotoPath = uniqueFileName,
                    appUserId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                    CreateTime = DateTime.Now,
                    Name = appUser.Name,
                    ProfilePic = appUser.ProfilePic,
                };

                Question new_question = _questionRepository.Add(question2);
                return RedirectToAction("Details", new { id = new_question.Id });
            }
            return View();
        }

        public ActionResult Details(int Id)
        {
            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);

            Question question = _questionRepository.GetQuestion(Id);
            string userId = userManager.GetUserId(HttpContext.User);
            if (question == null)
            {
                Response.StatusCode = 404;
                return View("Question Not Found",Id);
            }
            dynamic mymodel = new ExpandoObject();
            SavedPost sp = _questionRepository.IsSaved(Id,userId);
            if (sp != null)
                ViewData["Check"] = true;
            else
                ViewData["Check"] = false;
            var answer = _questionRepository.AnswerofQuestion(Id);
            mymodel.question1 = question;
            mymodel.answer = answer;
            return View(mymodel);
        }

        [HttpGet]
        public ViewResult Edit(int Id)
        {
            Question question = _questionRepository.GetQuestion(Id);
            return View(question);
        }

        [HttpPost]
        public IActionResult Edit(Question questionChanges)
        {
            if(ModelState.IsValid)
            {
                Question question = _questionRepository.GetQuestion(questionChanges.Id);
                question.question = questionChanges.question;
                question.category = questionChanges.category;
                question.Name = questionChanges.Name;
                question.ProfilePic = questionChanges.ProfilePic;
                question.CreateTime = questionChanges.CreateTime;
                question.PhotoPath = questionChanges.PhotoPath;
                //question.QuestionImage = questionChanges.QuestionImage;
                Question updated_question = _questionRepository.Update(question);
                return RedirectToAction("Index");
            }
            return View(questionChanges);
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Question question = _questionRepository.GetQuestion(Id);
            if(question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int Id)
        {
            Question question = _questionRepository.GetQuestion(Id);
            _questionRepository.Delete(question.Id);
            return RedirectToAction("Index");
        }

    }
}
