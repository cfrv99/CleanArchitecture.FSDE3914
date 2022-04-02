using AutoMapper;
using FirstApi.Application.Products.Requests;
using FirstApi.Application.Products.Responses;
using FirstApi.Domain.Entities;
using FirstApi.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Application.Services.Products
{
    public interface IProductService
    {
        Task<AddProductResponse> AddAsync(AddProductRequest request);
        Task<AddProductResponse> AddAsync2(AddProductRequest request);
    }
    public class ProductService : IProductService
    {
        private readonly IRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public Task<AddProductResponse> AddAsync(AddProductRequest request)
        {
            var productEntity = _mapper.Map<Product>(request);
            _productRepository.Add(productEntity);
        }

        public Task<AddProductResponse> AddAsync2(AddProductRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
