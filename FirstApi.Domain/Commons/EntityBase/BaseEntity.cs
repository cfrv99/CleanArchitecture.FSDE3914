using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.EntityBase
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreatorId { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifierId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
