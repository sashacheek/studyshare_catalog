using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.TeacherId);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LessonCount = table.Column<int>(type: "int", nullable: false),
                    CourseLength = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "TeacherId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Sasha", "Cheek" },
                    { 2, "Jenna", "Hillman" },
                    { 3, "Bryson", "Keightley" },
                    { 4, "Annika", "Creste" },
                    { 5, "Andrew", "Brooks" },
                    { 6, "Mark", "Templeton" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseLength", "Description", "Image", "LessonCount", "Level", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 1, 15, "Learn the basics of programming in Java. Topics include variables, datatypes, conditional statements, loops, and functions.", "introduction-to-java.jpg", 25, "Beginner", 1, "Introduction to Java" },
                    { 2, 16, "Learn how to query and build relational databases. This course is taught in SQL using SQL Server Management Server 19.", "database-development.jpg", 31, "Beginner", 1, "Database Development" },
                    { 3, 25, "Learn advanced techniques for creating machine learning algorithms.", "advanced-machine-learning.jpg", 47, "Advanced", 2, "Advanced Machine Learning" },
                    { 4, 12, "Build your own webpages in React! Suitable for beginners.", "react-basics.jpg", 19, "Intermediate", 2, "React Basics" },
                    { 5, 18, "Learn how to develop web apps with ASP.Net Core. Basic knowledge of HTML and CSS required.", "asp-net-core-web-development.jpg", 29, "Advanced", 2, "Asp.Net Core Web Development" },
                    { 6, 8, "Learn the basics of web development with HTML and CSS.", "html-and-css.jpg", 16, "beginner", 2, "HTML and CSS" },
                    { 7, 15, "Learn advanced development techniques in C#. Focuses on the use of classes and object-oriented programming.", "intermediate-csharp.jpg", 26, "Intermediate", 3, "Intermediate C#" },
                    { 8, 13, "Learn advanced web design techniques to plan our your website to be effective and engaging.", "advanced-web-design.jpg", 22, "Advanced", 3, "Advanced Web Design" },
                    { 9, 11, "Learn rudimentary Php as used in web development. No prior programming knowledge required.", "introduction-to-php.jpg", 17, "Beginner", 4, "Introduction to Php" },
                    { 10, 23, "Learn common programming data structures and algorithms in Java. Topics include search trees, graphs, stacks, lists, and queues.", "data-structures-and-algorithms.jpg", 37, "Intermediate", 4, "Data Structures and Algorithms" },
                    { 11, 6, "Learn how to use Bootstrap to elevate your web development. Prior HTML and CSS knowledge required.", "bootstrap.png", 13, "Intermediate", 5, "Bootstrap" },
                    { 12, 19, "Learn intermediate web backend development techniques in Python.", "intermediate-django.jpg", 38, "Intermediate", 6, "Intermediate Django" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
