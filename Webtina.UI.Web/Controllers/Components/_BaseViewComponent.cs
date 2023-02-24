using Microsoft.AspNetCore.Mvc;
using Webtina.UI.Core.Extentions;
using Webtina.UI.Models;

namespace Webtina.UI.Web.Controllers.Components
{
    public abstract class BaseViewComponent : ViewComponent
    {
        public Tenant Tenant => HttpContext.GetTenant();
    }
}
