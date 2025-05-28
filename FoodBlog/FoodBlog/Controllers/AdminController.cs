using Microsoft.AspNetCore.Mvc;

namespace FoodBlog.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
