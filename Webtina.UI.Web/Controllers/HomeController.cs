using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;
using Webtina.UI.Services.Services;
using Webtina.UI.Web.Models;

namespace Webtina.UI.Web.Controllers
{
    public class HomeController : _BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICommonService _commonService;
        private readonly IPageService _pageService;

        public HomeController(ILogger<HomeController> logger, ICommonService commonService, IPageService pageService)
        {
            _logger = logger;
            _commonService = commonService;
            _pageService = pageService;
        } 

        //[ResponseCache(Duration = 30)]
        public async Task<IActionResult> Index()
        {

            //var components = await _commonService.GetHomePageComponents();

            //var homeInfo = await _pageService.Get("home");
            //HttpContext.SetSeoInfo(seoInfo =>
            //{
            //    seoInfo.SetCommonInfo(
            //    pageTitle: homeInfo.SeoTitle ?? "",
            //    url: HttpContext.GetTenant().Url ?? "",
            //    keywordTags: null,
            //    description: homeInfo.Description ?? "");
            //});

            //return View(components.ToList());
            return View();
        }
        //[Route("/{culture:lang}/Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [Route("/{culture}/contactus")]
        public ActionResult ContactUs()
        {
            return View();
        }

    }
}
