using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProject.DbContextLayer;
using WebProject.Dto;
using WebProject.Entites;

namespace WebProject.Controllers
{
    public class SearchController : BaseController
    {
        public SearchController(ILogger<HomeController> logger, AppDbContext context) : base(logger, context)
        {
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<JsonResult> SearchProduct(string prefix, bool isSearch)
        {
            var format = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

            var queryProduct = await _context.Products.AsNoTracking().ToListAsync();

            var products = new List<Product>();

            if (!string.IsNullOrEmpty(prefix))
            {

                products = (from p in queryProduct
                            where p.Name.ToLower().Contains(prefix.Trim().ToLower())
                            select p).Take(50).ToList();
            }

            var podductSearchs = new List<ProductSearchDTO>();

            foreach (var product in products)
            {
                podductSearchs.Add(new ProductSearchDTO
                {
                    id = product.ID,
                    title = product.Title,
                    name = product.Name,
                    price = @String.Format(format, "{0:c0}", product.Price),
                    slug = product.Slug,

                });
            }

            return Json(podductSearchs);
        }
    }
}
