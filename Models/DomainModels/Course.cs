using System.Diagnostics.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required(ErrorMessage = "Please enter a course title.")]
        [MaxLength(200, ErrorMessage = "Title must not exceed 200 characters.")]
        public string Title { get; set; } = string.Empty;

        public int LessonCount { get; set; }
        public int CourseLength { get; set; } // total length in hours
        public string Image { get; set; } = string.Empty;

        public string Level { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int TeacherId {  get; set; }
        [Required]
        public Teacher Teacher { get; set; }

        // TODO: Consider adding course levels (ex. beginner, intermediate, advanced)
    }
}
