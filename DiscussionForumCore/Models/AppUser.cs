using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscussionForumCore.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string University { get; set; }

        public string ProfilePic { get; set; }

    }
}
