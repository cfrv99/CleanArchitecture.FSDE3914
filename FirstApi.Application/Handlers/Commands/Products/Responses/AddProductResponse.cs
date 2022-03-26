using FirstApi.Domain.Commons.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Handlers.Commands.Products.Responses
{
    public class AddProductResponse : IDto
    {
        public bool AddStatus { get; set; }
    }
}
