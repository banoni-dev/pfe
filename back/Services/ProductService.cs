using back.Models;
using back.Repositories;
using System;
using System.Collections.Generic;

namespace back.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public ProductModel GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public ProductModel GetProductByName(string name)
        {
            return _productRepository.GetProductByName(name);
        }

        public List<ProductModel> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }

        public ProductModel CreateProduct(ProductModel product)
        {
            if (_productRepository.GetProductByName(product.Name) != null)
                throw new Exception("Product name already exists");

            return _productRepository.CreateProduct(product);
        }

        public ProductModel UpdateProduct(int id, ProductModel updatedProduct)
        {
            return _productRepository.UpdateProduct(id, updatedProduct);
        }

        public void DeleteProduct(int id)
        {
            _productRepository.DeleteProduct(id);
        }
    }
}
