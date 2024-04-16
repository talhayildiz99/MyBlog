using Microsoft.AspNetCore.Mvc;

namespace MyBlog_PresentationLayer.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
