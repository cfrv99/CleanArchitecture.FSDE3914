using FirstApi.Domain.Commons.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Base
{
    public class MediatRBase
    {
        public interface IRequestWrapper<T> : IRequest<ApiResponse<T>> where T : IDto
        {

        }

        public interface IHandlerWrapper<Tin, Tout> : IRequestHandler<Tin, ApiResponse<Tout>> where Tin : IRequestWrapper<Tout> where Tout : IDto
        {

        }
    }
}
