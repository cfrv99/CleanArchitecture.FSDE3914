using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Infrastructure.Dapper.Products
{
    public static class ProductConsts
    {
        public const string GetAllSql = "SELECT * FROM PRODUCTS WHERE ISDELETED=0";
    }
}
