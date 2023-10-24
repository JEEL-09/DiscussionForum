using DiscussionForumCore.Models;
using DiscussionForumCore.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DiscussionForumCore.Controllers
{   
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private AppDbContext _context;
        private readonly IHostingEnvironment hostingEnvironment;


        private Task<AppUser> GetCurrentUserAsync() => userManager.GetUserAsync(HttpContext.User);

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, AppDbContext context, IHostingEnvironment hostingEnvironment)
        {
            this._context = context;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = new AppUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    Name = model.Name,
                    PhoneNumber = model.PhoneNumber,
                    University = model.University,
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("index", "Question");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Edit(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);
            if(user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {Id} cannot be found";
                return View("NotFound");
            }
            var model = new AppUserViewModel
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                UserName = user.UserName,
                PhoneNumber = user.PhoneNumber,
                University = user.University,
            };
            return View(model);
        }


        [Authorize]
        public IActionResult AllQuestions()
        {
            string userId = userManager.GetUserId(HttpContext.User);

            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var questions = _context.questions.Where(q => q.appUserId == userId).OrderByDescending(o=>o.CreateTime);
            return View(questions);
        }


        [Authorize]
        public IActionResult AllAnswers()
        {
            string userId = userManager.GetUserId(HttpContext.User);

            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var answers = _context.answers.Where(q => q.appUserId == userId).OrderByDescending(o => o.CreateTime);
            return View(answers);
        }



        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Edit(AppUserViewModel appUser)
        {
            var user = await userManager.FindByIdAsync(appUser.Id);
            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {appUser.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                user.Name = appUser.Name;
                user.UserName = appUser.UserName;
                user.Email = appUser.Email;
                user.PhoneNumber = appUser.PhoneNumber;
                user.University = appUser.University;
                string uniqueFileName = null;
                if (appUser.ProfilePic != null)
                {
                    string path = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + appUser.ProfilePic.FileName;
                    string filepath = Path.Combine(path, uniqueFileName);
                    appUser.ProfilePic.CopyTo(new FileStream(filepath, FileMode.Create));
                }
                else
                {
                    uniqueFileName = user.ProfilePic;
                }
                user.ProfilePic = uniqueFileName;



                var result = await userManager.UpdateAsync(user);
                if(result.Succeeded)
                {
                    return RedirectToAction("ViewQuestions");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(appUser);
            }

        }


        [Authorize]
        public async Task<IActionResult> ViewQuestionsAsync()
        {
            string userId = userManager.GetUserId(HttpContext.User);

            ViewData["userId"] = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var questions = _context.questions.Where(a => a.appUserId == userId);
            AppUser appUser = await GetCurrentUserAsync();
            //Console.WriteLine(bookings);
            //foreach (var booking in bookings)
            //{
            //    Console.WriteLine(booking.name);
            //}
            return View(appUser);
        }


        [HttpGet]
        public IActionResult Login()
        {
            if(signInManager.IsSignedIn(User))
            {
                return RedirectToAction("index", "Question");
            }


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.username, model.password, model.rememberMe, false);
                if (result.Succeeded)
                {
                    //string username = HttpContext.User.Identity.Name;
                    //Console.WriteLine("THIS IS USERNAME : "+username);
                    //HttpContext.Session.SetString("UserId", JsonConvert.SerializeObject(User.FindFirstValue(ClaimTypes.NameIdentifier)));
                    return RedirectToAction("index", "Question");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login");
            }
            return View(model);
        }
    }
}
