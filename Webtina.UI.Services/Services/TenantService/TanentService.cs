using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models;

namespace Webtina.UI.Services.Services
{

    public class TanentService : ITanentService
    {
        private readonly IUserService userService;
        private IMemoryCache cache;

        public TanentService(IUserService userService, IMemoryCache cache)
        {
            this.userService = userService;
            this.cache = cache;
        }

        /// <summary>
        /// دریافت اطلاعات کاربر و فروشگاه از روی آدرس URl
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task<Tenant> GetTenantAsync(HttpContext context)
        {
            var domain = context.Request.Host.Value;
            cache.TryGetValue(domain, out Tenant tenant);
            if (tenant==null)
            {
                tenant = await userService.GetShop(domain);
                cache.Set(domain, tenant, new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromHours(2)
                });
            }

            return tenant;
        }
    }
}
