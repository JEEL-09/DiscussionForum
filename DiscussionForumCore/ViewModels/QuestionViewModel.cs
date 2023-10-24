using DiscussionForumCore.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.ViewModels
{
    public class QuestionViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string question { get; set; }

        [Required]
        public string category { get; set; }

        public DateTime CreateTime { get; set; }

        public IFormFile Photo{ get; set; }

        public string appUserId { get; set; }
        public AppUser appUser { get; set; }

    }
}
