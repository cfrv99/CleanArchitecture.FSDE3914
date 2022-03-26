using Dapper;
using FirstApi.Domain.Entities;
using FirstApi.Infrastructure.Dapper.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Infrastructure.Dapper.Products
{
    public interface IProductDapperRepository
    {
        Task<IEnumerable<Product>> GetAllProducts(); 
    }
    public class ProductDapperRepository : IProductDapperRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductDapperRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var query = await unitOfWork.GetConnection().QueryAsync<Product>(ProductConsts.GetAllSql, new { }, unitOfWork.GetTransaction());

            return query;
        }
    }
}
