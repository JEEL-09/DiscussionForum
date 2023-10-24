using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{
    public interface IAnswerRepository
    {
        Answer GetAnswer(int id);

        IEnumerable<Answer> GetAllAnswers();

        Question GetQuestion(int id);

        Answer Add(Answer answer);

        Answer Update(Answer answerChanges);

        Answer Delete(int id);
    }
}
