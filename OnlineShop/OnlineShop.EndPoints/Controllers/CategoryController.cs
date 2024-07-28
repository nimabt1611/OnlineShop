using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.EndPoints.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
