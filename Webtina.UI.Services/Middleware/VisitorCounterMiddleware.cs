using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Services.Services;

namespace Webtina.UI.Services.Middleware
{
    public class VisitorCounterMiddleware
    {
        private readonly RequestDelegate _requestDelegate;

        public VisitorCounterMiddleware(RequestDelegate requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }

        public async Task Invoke(HttpContext context, ICommonService commonService)
        {
            string visitorId = context.Request.Cookies["VisitorId"];
            if (visitorId == null)
            {
                commonService.AddViewCount(null);

                context.Response.Cookies.Append("VisitorId", Guid.NewGuid().ToString(), new CookieOptions()
                {
                    Path = "/",
                    HttpOnly = true,
                    Secure = false,
                });
            }

            await _requestDelegate(context);
        }
    }
}
