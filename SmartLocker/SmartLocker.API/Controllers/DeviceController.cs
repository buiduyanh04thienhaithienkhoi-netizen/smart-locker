using Microsoft.AspNetCore.Mvc;
using SmartLocker.API.Data;

namespace SmartLocker.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeviceController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDevices()
        {
            return Ok(_context.Devices.ToList());
        }
    }
}   