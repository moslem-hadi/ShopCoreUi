using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Webtina.UI.Core.Extentions;
using Webtina.UI.Core.Infrastructure;
using Webtina.UI.Models;

namespace Webtina.UI.Web.Controllers
{
    public class _BaseController : Controller
    {
        public Tenant Tenant => HttpContext.GetTenant();
    }

}
