using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{

    public class SQLAnswerRepository : IAnswerRepository
    {

        private readonly AppDbContext _context;

        public SQLAnswerRepository(AppDbContext context)
        {
            _context = context;
        }

        public Answer Add(Answer answer)
        {
            _context.answers.Add(answer);
            _context.SaveChanges();
            return answer;
        }

        public Answer Delete(int id)
        {
            Answer answer = _context.answers.Find(id);
            if(answer != null)
            {
                _context.answers.Remove(answer);
                _context.SaveChanges();
            }
            return answer;
        }

        public IEnumerable<Answer> GetAllAnswers()
        {
            return _context.answers.OrderByDescending(o => o.CreateTime);
        }

        public Answer GetAnswer(int id)
        {
            return _context.answers.Find(id);
        }

        public Question GetQuestion(int id)
        {
            return _context.questions.Find(id);
        }

        public Answer Update(Answer answerChanges)
        {
            var answer = _context.answers.Attach(answerChanges);
            answer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return answerChanges;
        }
    }
}
