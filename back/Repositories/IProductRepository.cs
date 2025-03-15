using back.Models;
using System.Collections.Generic;

namespace back.Repositories
{
    public interface IProductRepository
    {
        ProductModel GetProductById(int id);
        ProductModel GetProductByName(string name);
        List<ProductModel> GetAllProducts();
        ProductModel CreateProduct(ProductModel product);
        ProductModel UpdateProduct(int id, ProductModel updatedProduct);
        void DeleteProduct(int id);
    }
}
