using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult About() => View();
        public IActionResult Contact() => View();
        public IActionResult Experience() => View();

    }
}
