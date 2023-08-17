using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_Core_Lesson_2_Homework.Controllers
{
    public class CalkController : Controller
    {
        public IActionResult Add(int x, int y)
        {
            int res = x + y;
            string textRes = $"Результата {x} + {y} будет {res}";

            return View("Resalt", textRes as object);
        }

        public IActionResult Mul(int x, int y)
        {
            int res = x * y;
            string textRes = $"Результата {x} * {y} будет {res}";

            return View("Resalt", textRes as object);
        }


        public IActionResult Div(int x, int y)
        {
            int res = x / y;
            string textRes = $"Результата {x} / {y} будет {res}";

            return View("Resalt", textRes as object);
        }


        public IActionResult Sub(int x, int y)
        {
            int res = x - y;
            string textRes = $"Результата {x} - {y} будет {res}";

            return View("Resalt", textRes as object);
        }
    }
}
