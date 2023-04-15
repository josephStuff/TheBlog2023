using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TheBlog2023.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "The {0} must be not less than {2} and not more than {1} long", MinimumLength = 2)]
        public string Text { get; set; }


        public virtual Post Post { get; set; }
        public virtual IdentityUser Author { get; set; }




    }
}
