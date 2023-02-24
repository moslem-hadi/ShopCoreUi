using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models;
using Webtina.UI.Models.ViewModels;

namespace Webtina.UI.Services.Services
{
    public interface IUserService
    {
        /// <summary>
        /// دریافت اطلاعات فروشگاه و کاربر با استفاده از آدرس Url
        /// </summary>
        /// <param name="domain"></param>
        /// <returns></returns>
        Task<Tenant> GetShop(string domain);
    }
}
