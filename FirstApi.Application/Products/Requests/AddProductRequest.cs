using FirstApi.Domain.Commons.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Products.Requests
{
    public class AddProductRequest : IDto
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Amount { get; set; }
    }
}
