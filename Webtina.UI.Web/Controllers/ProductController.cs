using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webtina.UI.Services.Services;

namespace Webtina.UI.Web.Controllers
{
    public class ProductController : _BaseController
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("/product/{id:int}/{title}")]
        public async Task<IActionResult> Details(int id)
        {
            var product = await productService.GetProductDetail(id);
            if (product == null)
                return NotFound();


            return View(product);
        }
    }
}
