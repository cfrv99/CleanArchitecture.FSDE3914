using FirstApi.Application.Base;
using FirstApi.Application.Handlers.Commands.Products.Responses;
using FirstApi.Domain.Commons.Exceptions;
using FirstApi.Domain.Commons.Responses;
using FirstApi.Domain.Entities;
using FirstApi.Domain.Repositories;
using FirstApi.Infrastructure.Dapper.Helpers;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static FirstApi.Application.Base.MediatRBase;

namespace FirstApi.Application.Handlers.Commands.Products
{
    public class AddProductCommand : IRequestWrapper<AddProductResponse>
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }

    public class AddProductHandler : BaseHandlerService, IHandlerWrapper<AddProductCommand, AddProductResponse>
    {
        private readonly IRepository<Product> repository;
        private readonly IUnitOfWork unitOfWork;

        public AddProductHandler(IHttpContextAccessor httpContextAccessor, IRepository<Product> repository, IUnitOfWork unitOfWork) : base(httpContextAccessor)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ApiResponse<AddProductResponse>> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if(request.Model == null)
                {
                    throw new ApiException("Can not be null", "401");
                }
                Product product = new Product
                {
                    Name = request.Name,
                    Price = request.Price,
                    Model = request.Model
                };
                await repository.Add(product);


                using (var trx = unitOfWork.BeginTransaction())
                {
                    unitOfWork.SaveChanges();
                }

                return new ApiResponse<AddProductResponse>(new AddProductResponse { AddStatus = true });
            }
            catch(ApiException ex)
            {
                return new ApiResponse<AddProductResponse>(ex.Message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
