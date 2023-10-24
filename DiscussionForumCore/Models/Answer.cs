using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string answer { get; set; }
        public DateTime CreateTime { get; set; }

        public int questionId { get; set; }
        public Question question { get; set; }

        public string appUserId { get; set; }
        public AppUser appUser { get; set; }



        [Required]
        public string Name { get; set; }

        public string ProfilePic { get; set; }

    }
}
