using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webtina.UI.Models.ViewModels;
using Webtina.UI.Services.Services;

namespace Webtina.UI.Web.Controllers.Components
{
    public class ProductsViewComponent : BaseViewComponent
    {
        private readonly IProductService productService;
        public ProductsViewComponent(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(ProductsComponentQuery query)
        {
            query.UserId = Tenant.UserId;
            query.ShopType = Tenant.ShopType;
            var items = await productService.GetProducts(query);
            return View(items);
        }
    }
}
