using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Commons.Requests
{
    public interface IRequestPaging
    {
        public int CurrentPage { get; set; }
        public int Limit { get; set; }
    }
}
