using FirstApi.Domain.Commons.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstApi.Application.Base
{
    public class BaseHandlerService
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public BaseHandlerService(IHttpContextAccessor httpContextAccessor)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        protected int GetCurrentUserId()
        {
            return 0;
        }

        protected int GetCurrentTenantId()
        {
            int tenantId = 0;
            return tenantId;
        }

        protected bool UploadLocalFile(string base64)
        {
            return false;
        }
    }
}
