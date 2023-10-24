
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string question { get; set; }

        [Required]
        public string category { get; set; }

        public DateTime CreateTime { get; set; }

        public String PhotoPath { get; set; }

        public string appUserId { get; set; }
        public AppUser appUser { get; set; }


        [Required]
        public string Name { get; set; }

        public string ProfilePic { get; set; }



    }
}
