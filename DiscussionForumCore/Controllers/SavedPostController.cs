using DiscussionForumCore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DiscussionForumCore.Controllers
{
    [Authorize]

    public class SavedPostController : Controller
    {

        private readonly ISavedPostRepository _savedPostRepository;
        private readonly IQuestionRepository _questionRepository;

        private readonly UserManager<AppUser> userManager;


        private Task<AppUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);


        public SavedPostController(ISavedPostRepository savedPostRepository, UserManager<AppUser> userManager,IQuestionRepository questionRepository)
        {
            _savedPostRepository = savedPostRepository;
            _questionRepository = questionRepository;
            this.userManager = userManager;
        }

        public IActionResult SavedPost()
        {
            string userId = userManager.GetUserId(HttpContext.User);

            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IList<SavedPost> savedPosts = _savedPostRepository.GetQuestions(userId);
            IList<Question> questions = _savedPostRepository.GetSavedPosts(savedPosts);
            return View(questions);
        }

        public async Task<IActionResult> SaveAsync(int Id)
        {
            string userId = userManager.GetUserId(HttpContext.User);
            AppUser appUser = await GetCurrentUserAsync();

            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            SavedPost savedPost = new SavedPost
            {
                questionId = Id,
                appUserId = userId,
                Name = appUser.Name,
                ProfilePic = appUser.ProfilePic,
            };

            SavedPost sp1 = _savedPostRepository.Add(savedPost);


            SavedPost sp = _questionRepository.IsSaved(Id, userId);
            if (sp != null)
                ViewData["Check"] = true;
            else
                ViewData["Check"] = false;
            return RedirectToAction("Details","Question", new { id = Id });
        }

        public IActionResult Delete(int Id)
        {
            string userId = userManager.GetUserId(HttpContext.User);
            SavedPost savedPost = _savedPostRepository.GetSavedPost(Id,userId);
            //Console.WriteLine(savedPost.questionId);
            _savedPostRepository.Delete(savedPost.questionId,userId);
            return RedirectToAction("Details","Question",new { id = Id});
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
