using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webtina.UI.Models.ViewModels;

namespace Webtina.UI.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IDapperService<object> dapperService;
        public ProductService(IDapperService<object> dapperService)
        {
            this.dapperService = dapperService;
        }
        public async Task<List<GridProductViewModel>> GetProducts(ProductsComponentQuery query)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add(nameof(query.GroupId), query.GroupId);
                parameters.Add(nameof(query.Count), query.Count);
                parameters.Add(nameof(query.PriceType), query.PriceType);
                parameters.Add(nameof(query.ShopType), query.ShopType);
                parameters.Add(nameof(query.UserId), query.UserId);
                var list = dapperService.Query<GridProductViewModel>("GetProductsForBox_New",
                    parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();

                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<ProductDetailsViewModel> GetProductDetail(int id)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add(nameof(id), id);
                return dapperService.Query<ProductDetailsViewModel>("GetProductDetail_New",
                    parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
