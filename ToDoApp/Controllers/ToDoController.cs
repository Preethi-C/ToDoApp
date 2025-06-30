using Microsoft.AspNetCore.Mvc;

namespace ToDoApp.Controllers
{
    public class ToDoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
