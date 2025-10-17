using DecorShopMVC.Models;
using DecorShopMVC.Repositories;
using System.Collections.Generic;

namespace DecorShopMVC.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepo;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        public IEnumerable<Product> GetAll() => _productRepo.GetAll();
        public Product? GetById(int id) => _productRepo.GetById(id);
    }
}