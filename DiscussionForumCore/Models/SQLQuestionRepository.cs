using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiscussionForumCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DiscussionForumCore.Models
{
    public class SQLQuestionRepository : IQuestionRepository
    {

        private readonly AppDbContext _context;

        public SQLQuestionRepository(AppDbContext context)
        {
            _context = context;
        }

        public Question Add(Question question)
        {
            _context.questions.Add(question);
            _context.SaveChanges();
            return question;
        }

        public Question Delete(int id)
        {
            Question question = _context.questions.Find(id);
            if(question != null)
            {
                _context.questions.Remove(question);
                _context.SaveChanges();
            }
            return question;
        }


        public IEnumerable<Question> GetAllQuestions()
        {
            return _context.questions.OrderByDescending(o => o.CreateTime);
        }

        public async Task<Question> GetQuestionAsync(int id)
        {
            return await _context.questions.FirstOrDefaultAsync(q => q.Id == id);
        }

        public Question Update(Question questionChanges)
        {
            var question = _context.questions.Attach(questionChanges);
            question.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return questionChanges;
        }

        public IEnumerable<Answer> AnswerofQuestion(int id)
        {
            return _context.answers.Where(q => q.questionId == id).OrderByDescending(o => o.CreateTime);
        }

        public SavedPost IsSaved(int Id,string userId)
        {
            SavedPost sp = _context.savedPosts.FirstOrDefault(s => s.questionId == Id && s.appUserId == userId);
            return sp;
        }

        public Question GetQuestion(int id)
        {
            return _context.questions.Find(id);
        }
    }
}
