using FirstApi.Domain.Commons.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Products.Responses
{
    public class AddProductResponse : IDto
    {
        public int Id { get; set; }
        public string Message { get; set; }

    }
}
