using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers

{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index (string Name, int Age, string Address)
        {
            ViewBag.tbao  = "Xin chào " + Name + " - " + Age + " tuổi" + " - " + Address;
            return View();
        }
    }
}