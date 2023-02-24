using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webtina.UI.Models.Enums;
using Webtina.UI.Models.ViewModels;

namespace Webtina.UI.Services.Services
{
    public class CommonService : ICommonService
    {
        private readonly IDapperService<object> dapperService;
        public CommonService(IDapperService<object> dapperService)
        {
            this.dapperService = dapperService;
        }
        public async Task<IEnumerable<HomePageComponentViewModel>> GetHomePageComponents()
        {
            return dapperService.Query<HomePageComponentViewModel>("GetHomePageComponents",
                  commandType: System.Data.CommandType.StoredProcedure);
        }

        public async Task<IEnumerable<MenuViewModel>> GetMenu(MenuPosition position)
        {
            var menus = dapperService.Query<MenuViewModel>("GetMenuByLang",
                new { position },
                  commandType: System.Data.CommandType.StoredProcedure).ToList();

            menus.Where(a => a.ParentId is null).ToList().ForEach(a =>
             {
                 a.SubMenus = menus.Where(s => s.ParentId == a.Id).OrderBy(s => s.Priority).ToList();
             });

            menus.RemoveAll(a => a.ParentId != null);

            return menus;
        }

        public async Task<IEnumerable<MenuViewModel>> GetFooterMenus()
        {
            var menus = dapperService.Query<MenuViewModel>("GetFooterMenusByLang", 
                  commandType: System.Data.CommandType.StoredProcedure).ToList();
            return menus;
        }

        public async Task AddViewCount(PageViewViewModel model)
        {
            dapperService.ExecuteAsync("AddViewCount", System.Data.CommandType.StoredProcedure);
        }

        public async Task<List<SiteMapDataViewModel>> GetSitemapData()
        {
            return dapperService.Query<SiteMapDataViewModel>("GetSitemapData",
                   commandType: System.Data.CommandType.StoredProcedure).ToList();
        }

    }
}
