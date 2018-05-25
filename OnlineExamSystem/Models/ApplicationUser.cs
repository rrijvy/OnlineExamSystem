using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using OnlineExamSystem.Services;

namespace OnlineExamSystem.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public Gender Gender { get; set; }

        [Display(Name = "Collage Name")]
        public string CollageName { get; set; }

        public List<Result> Results { get; set; }
    }
}
