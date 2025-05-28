using Microsoft.AspNetCore.Mvc;

namespace FoodBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
