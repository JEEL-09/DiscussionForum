using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{
    public interface ISavedPostRepository
    {
        IList<SavedPost> GetQuestions(string Id);

        SavedPost Add(SavedPost savedPost);

        SavedPost Delete(int Id,string userId);

        SavedPost GetSavedPost(int Id,string userId);

        public IList<Question> GetSavedPosts(IList<SavedPost> savedPosts);


    }
}
