using Microsoft.AspNetCore.Mvc;

namespace SmartLocker.API.Controllers
{
    public class FaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
