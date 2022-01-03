using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemoryRepository : IProductRepository
    {
        private List<Product> products;
        public ProductInMemoryRepository()
        {
            //Init with default value
            products = new List<Product>()
            {
                new Product{ProductId =1, CategoryId =1,Name="Iced Tea", Quantity =100, Price =1.99 },
                new Product{ProductId =2, CategoryId =1,Name="Canada Dry", Quantity =100, Price =4.99 },
                new Product{ProductId =3, CategoryId =2,Name="Cake", Quantity =100, Price =2.99 },
                new Product{ProductId =4, CategoryId =3,Name="Beef", Quantity =100, Price =3.99 },

            };
        }

        public void AddProduct(Product product)
        {
            if (products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase))) return;
            if (products != null && products.Count > 0)
            {
                var maxId = products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }
            products.Add(product);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
        public void UpdateProduct(Product product)
        {
            var productToUpdate = GetProductById(product.ProductId);
            if (productToUpdate != null)
            {
                productToUpdate.CategoryId = product.CategoryId;
                productToUpdate.Name = product.Name;
                productToUpdate.Price = product.Price;
                productToUpdate.Quantity = product.Quantity;
            }
        }
        public Product GetProductById(int productId)
        {
            var product = products?.FirstOrDefault(x => x.ProductId == productId);
            return product;
        }

        public void DeleteProduct(int productId)
        {
            products?.Remove(GetProductById(productId));
        }
    }
}
