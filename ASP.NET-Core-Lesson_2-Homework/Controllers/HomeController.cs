using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Security.Policy;

namespace ASP.NET_Core_Lesson_2_Homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

    }
}
