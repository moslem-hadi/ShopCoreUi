using System.Collections.Generic;
using System.Threading.Tasks;
using Webtina.UI.Models.Enums;
using Webtina.UI.Models.ViewModels;

namespace Webtina.UI.Services.Services
{
    public interface ICommonService
    {
        Task<IEnumerable<HomePageComponentViewModel>> GetHomePageComponents();
        Task<IEnumerable<MenuViewModel>> GetMenu(MenuPosition position);

        /// <summary>
        /// برای منوهای فوتر. میتونه با بالایی یکی بشه
        /// </summary>
        /// <param name="langId"></param>
        /// <returns></returns>
        Task<IEnumerable<MenuViewModel>> GetFooterMenus();
        Task AddViewCount(PageViewViewModel model);
        Task<List<SiteMapDataViewModel>> GetSitemapData();

    }
}