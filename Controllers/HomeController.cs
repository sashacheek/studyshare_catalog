using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private Repository<Course> data {  get; set; }

        public HomeController(FinalProjectContext ctx) => data = new Repository<Course>(ctx);


        public IActionResult Index()
        {
            ViewBag.Filter = "all";
            var options = new QueryOptions<Course> { };
            return View(data.List(options));
        }

        public IActionResult FilterLevel(string filter)
        {
            ViewBag.Filter = filter;
            var options = new QueryOptions<Course> { };
            if (filter != "all") {
                options.Where = c => c.Level.ToLower() == filter;
            }
            return View("Index", data.List(options));
        }

        [HttpGet]
        public IActionResult CourseDetails([FromRoute] int id)
        {
            var options = new QueryOptions<Course>
            {
                Includes = "Teacher",
                Where = c => c.CourseId == id
            };
            Course? course = data.Get(options);
            if (course == null)
            {
                return NotFound(); // Return a 404 Not Found response..
            }
            
            return View(course);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
