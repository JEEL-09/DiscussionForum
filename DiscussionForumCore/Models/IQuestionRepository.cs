using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{
    public interface IQuestionRepository
    {
        Question GetQuestion(int id);

        IEnumerable<Question> GetAllQuestions();

        SavedPost IsSaved(int Id,string userId);

        IEnumerable<Answer> AnswerofQuestion(int id);

        Question Add(Question question);

        Question Update(Question questionChanges);

        Question Delete(int id);
    }
}
