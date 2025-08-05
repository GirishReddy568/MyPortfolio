using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyPortfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private static List<Project> Projects = new()
        {
            new Project
            {
                Id = 1,
                Title = "Weather App",
                Description = "Built using ASP.NET Core and a weather API.",
                ImageUrl = "/images/project1.jpg",
                Link = "https://github.com/GirishReddy568/weather-app"
            },
            new Project
            {
                Id = 2,
                Title = "Personal Blog",
                Description = "Blog engine with Markdown support.",
                ImageUrl = "/images/project2.jpg",
                Link = "https://github.com/GirishReddy568/blog"
            }
        };

        public IActionResult Index() => View(Projects);

        public IActionResult Details(int id)
        {
            var project = Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();
            return View(project);
        }
    }
}
