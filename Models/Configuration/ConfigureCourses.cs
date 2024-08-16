using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalProject.Models
{
    public class ConfigureCourses : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> entity)
        {
            entity.HasData(
                new { CourseId = 1, Title = "Introduction to Java", LessonCount = 25, CourseLength = 15, Image = "introduction-to-java.jpg", TeacherId = 1, Level = "Beginner", Description = 
                "Learn the basics of programming in Java. Topics include variables, datatypes, conditional statements, loops, and functions." },
                new { CourseId = 2, Title = "Database Development", LessonCount = 31, CourseLength = 16, Image = "database-development.jpg", TeacherId = 1, Level = "Beginner", Description = 
                "Learn how to query and build relational databases. This course is taught in SQL using SQL Server Management Server 19."  },
                new { CourseId = 3, Title = "Advanced Machine Learning", LessonCount = 47, CourseLength = 25, Image = "advanced-machine-learning.jpg", TeacherId = 2, Level = "Advanced", Description = 
                "Learn advanced techniques for creating machine learning algorithms." },
                new { CourseId = 4, Title = "React Basics", LessonCount = 19, CourseLength = 12, Image = "react-basics.jpg", TeacherId = 2, Level = "Intermediate", Description = 
                "Build your own webpages in React! Suitable for beginners." },
                new { CourseId = 5, Title = "Asp.Net Core Web Development", LessonCount = 29, CourseLength = 18, Image = "asp-net-core-web-development.jpg", TeacherId = 2, Level = "Advanced", Description = 
                "Learn how to develop web apps with ASP.Net Core. Basic knowledge of HTML and CSS required." },
                new { CourseId = 6, Title = "HTML and CSS", LessonCount = 16, CourseLength = 8, Image = "html-and-css.jpg", TeacherId = 2, Level = "Beginner", Description = 
                "Learn the basics of web development with HTML and CSS."  },
                new { CourseId = 7, Title = "Intermediate C#", LessonCount = 26, CourseLength = 15, Image = "intermediate-csharp.jpg", TeacherId = 3, Level = "Intermediate", Description = 
                "Learn advanced development techniques in C#. Focuses on the use of classes and object-oriented programming."  },
                new { CourseId = 8, Title = "Advanced Web Design", LessonCount = 22, CourseLength = 13, Image = "advanced-web-design.jpg", TeacherId = 3, Level = "Advanced", Description = 
                "Learn advanced web design techniques to plan our your website to be effective and engaging."  },
                new { CourseId = 9, Title = "Introduction to Php", LessonCount = 17, CourseLength = 11, Image = "introduction-to-php.jpg", TeacherId = 4, Level = "Beginner", Description = 
                "Learn rudimentary Php as used in web development. No prior programming knowledge required."  },
                new { CourseId = 10, Title = "Data Structures and Algorithms", LessonCount = 37, CourseLength = 23, Image = "data-structures-and-algorithms.jpg", TeacherId = 4, Level = "Intermediate", Description = 
                "Learn common programming data structures and algorithms in Java. Topics include search trees, graphs, stacks, lists, and queues."  },
                new { CourseId = 11, Title = "Bootstrap", LessonCount = 13, CourseLength = 6, Image = "bootstrap.png", TeacherId = 5, Level = "Intermediate", Description =
                "Learn how to use Bootstrap to elevate your web development. Prior HTML and CSS knowledge required." },
                new { CourseId = 12, Title = "Intermediate Django", LessonCount = 38, CourseLength = 19, Image = "intermediate-django.jpg", TeacherId = 6, Level = "Intermediate", Description = 
                "Learn intermediate web backend development techniques in Python."  }
                );
        }
    }
}
