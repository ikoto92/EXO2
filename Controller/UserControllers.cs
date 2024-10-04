using Microsoft.AspNetCore.Mvc;

namespace EXO2.Controller
{
    public class UserControllers : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
