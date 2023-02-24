using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models;
using Webtina.UI.Models.ViewModels;

namespace Webtina.UI.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IDapperService<object> dapperService;

        public UserService(IDapperService<object> dapperService)
        {
            this.dapperService = dapperService;
        }
        public async Task<Tenant> GetShop(string domain)
        {
            try
            {
                if (domain.Contains("nikanlink.com"))
                    domain = domain.Split('.')[0];


                DynamicParameters parameters = new DynamicParameters();
                parameters.Add(nameof(domain), domain);
                var user = dapperService.Query<Tenant>("GetUserShop_New",
                    parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

                return user;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
