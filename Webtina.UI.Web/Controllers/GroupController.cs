using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webtina.UI.Web.Controllers
{
    public class GroupController : Controller
    {
        [Route("group/{id:int}/{slug}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
