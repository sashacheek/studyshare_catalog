using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        [MaxLength(100, ErrorMessage = "First name must not exceed 100 characters.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        [MaxLength(100, ErrorMessage = "Last name must not exceed 100 characters.")]
        public string LastName { get; set; } = string.Empty;

        public ICollection<Course> Courses { get; set; }
    }
}
