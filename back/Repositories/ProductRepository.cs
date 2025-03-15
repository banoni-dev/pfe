using back.Models;
using back.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace back.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Db _db;

        public ProductRepository(Db db)
        {
            _db = db;
        }

        public ProductModel GetProductById(int id)
        {
            return _db.Products.FirstOrDefault(p => p.Id == id);
        }

        public ProductModel GetProductByName(string name)
        {
            return _db.Products.FirstOrDefault(p => p.Name == name);
        }

        public List<ProductModel> GetAllProducts()
        {
            return _db.Products.ToList();
        }

        public ProductModel CreateProduct(ProductModel product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
            return product;
        }

        public ProductModel UpdateProduct(int id, ProductModel updatedProduct)
        {
            var product = _db.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                throw new Exception("Product not found");

            product.Name = updatedProduct.Name;
            product.Description = updatedProduct.Description;
            product.ProductType = updatedProduct.ProductType;
            product.Price = updatedProduct.Price;

            _db.SaveChanges();
            return product;
        }

        public void DeleteProduct(int id)
        {
            var product = _db.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                throw new Exception("Product not found");

            _db.Products.Remove(product);
            _db.SaveChanges();
        }
    }
}
