using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{
    public class SQLSavedPostRepository : ISavedPostRepository
    {
        private readonly AppDbContext _context;
        private readonly IQuestionRepository questionRepository;

        private readonly UserManager<AppUser> userManager;

        public SQLSavedPostRepository(AppDbContext context,IQuestionRepository questionRepository, UserManager<AppUser> userManager)
        {
            _context = context;

            this.userManager = userManager;
            this.questionRepository = questionRepository;
        }

        public SavedPost Add(SavedPost savedPost)
        {
            _context.savedPosts.Add(savedPost);
            _context.SaveChanges();
            return savedPost;
        }

        public SavedPost Delete(int id,string userId)
        {
            SavedPost savedPost = _context.savedPosts.FirstOrDefault(q => q.questionId == id && q.appUserId == userId);
            if (savedPost != null)
            {
                _context.savedPosts.Remove(savedPost);
                _context.SaveChanges();
            }
            return savedPost;
        }

        public IList<SavedPost> GetQuestions(string Id)
        {
            return _context.savedPosts.Where(s => s.appUserId == Id).OrderByDescending(o => o.Id).ToList();

        }

        public SavedPost GetSavedPost(int Id,string userId)
        {
            return _context.savedPosts.FirstOrDefault(s => s.questionId == Id && s.appUserId == userId);
        }

        public IList<Question> GetSavedPosts(IList<SavedPost> savedPosts)
        {
            IList<Question> questions = new List<Question>();

            foreach (SavedPost sp in savedPosts.ToList())
            {
                Question question1 = questionRepository.GetQuestion(sp.questionId);
                Question new_question = new Question
                {
                    question = question1.question,
                    category = question1.category,
                    CreateTime = question1.CreateTime,
                    appUserId = question1.appUserId,
                    Id = question1.Id,
                    PhotoPath = question1.PhotoPath,
                    Name = question1.Name,
                    ProfilePic = question1.ProfilePic,
                };
                questions.Add(new_question);
            }
            return questions.ToList();
        }

    }
}
