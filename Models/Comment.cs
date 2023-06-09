﻿


using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using TheBlog2023.Enums;

namespace TheBlog2023.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        public string ModeratorId { get; set; }


        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and not more than {1} characters long", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string Body { get; set; }


        public DateTime Created { get; set; }
        public DateTime? Updated    { get; set; }
        public DateTime? Moderated { get; set; }
        public DateTime? Deleted { get; set; }


        [StringLength(500, ErrorMessage = "The {0} must be at least {2} and not more than {1} characters long", MinimumLength = 2)]
        [Display(Name = "Moderated Comment")]
        public string? ModeratedBody { get; set; }

        public ModerationType ModerationType { get; set; }

        //Navigation properties
        public virtual Post Post { get; set; }
        public virtual IdentityUser Author { get; set; }
        public virtual IdentityUser Moderator { get; set; }

        



    }
}
