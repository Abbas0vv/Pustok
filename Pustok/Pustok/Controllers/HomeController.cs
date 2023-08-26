using Microsoft.AspNetCore.Mvc;
using Pustok.Database.Repositories;

namespace Pustok.Controllers
{
    public class HomeController : Controller //controller
    {
        public string About() //action
        {
            return "Hello Mahmood how are oyu?";
        }

        public string Contact() //action
        {
            return "This page is contact";
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}