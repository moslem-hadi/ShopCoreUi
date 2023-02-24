using Dapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models;
using Webtina.UI.Models.ViewModels;

namespace Webtina.UI.Services.Services
{
    public class PageService : IPageService
    {
        private readonly IOptions<AppSettings> appSettings;
        private readonly IDapperService<object> dapperService;
        public PageService(IDapperService<object> dapperService, IOptions<AppSettings> appSettings)
        {
            this.dapperService = dapperService;
            this.appSettings = appSettings;
        }

        public async Task<PageViewModel> Get(string url)
        {
            try
            {
                using (var connection = dapperService.GetConnection())
                {
                    connection.Open();
                    DynamicParameters par = new DynamicParameters();
                    par.Add("@url", url);

                    using (var multi = connection.QueryMultiple("GetPageByUrl", new { url = url }, commandType: System.Data.CommandType.StoredProcedure))
                    {
                        var page = multi.Read<PageViewModel>().First();
                        if (page == null)
                            return null;
                        page.Pic = appSettings.Value.Cdn + page.Pic;
                        var items = multi.Read<PageItemViewModel>().ToList();
                        items.ForEach(item =>
                        {
                            item.FileName = appSettings.Value.Cdn + item.FileName;
                        });
                        page.Items = items;
                        return page;
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
         
    }
}
