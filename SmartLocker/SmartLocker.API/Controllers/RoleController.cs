using Microsoft.AspNetCore.Mvc;

namespace SmartLocker.API.Controllers
{
    public class RoleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
