using FirstApi.Domain.Commons.EntityBase;
using FirstApi.Domain.Entities.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public List<CategoryProducts> CategoryProducts { get; set; }

    }
}
