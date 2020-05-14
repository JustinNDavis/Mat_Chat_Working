using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mat_Chat_Working.Models;
using System.Text.Encodings.Web;
using Microsoft.EntityFrameworkCore;

namespace Mat_Chat_Working.Controllers
{
    public class HomeController : Controller
    {
        MyDbContext context = new MyDbContext();
        private readonly ILogger<HomeController> _logger;

        public string Welcome(string firstName, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {firstName}");
        }
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Data()
        {
            return View();
        }
        //make student profile variable = whatever context.prof.... is returning
        public IActionResult Profile(int id)
        {
            var studentProfile = context.Profile.SingleOrDefaultAsync(x => x.StudentID == id);
            return View(studentProfile);
        }
        public IActionResult Messaging()
        {
            return View();
        }
        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
