using Microsoft.AspNetCore.Mvc;
using WebProject.DbContextLayer;

namespace WebProject.Controllers
{
    public class BaseController : Controller
    {
        protected readonly ILogger<HomeController> _logger;

        protected readonly AppDbContext _context;
        public BaseController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }
    }
}
