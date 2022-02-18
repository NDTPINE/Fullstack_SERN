using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugin.DataStore.SQL
{
    public class ProductRepository : IProductRepository
    {
        private readonly MarketContext db;

        public ProductRepository(MarketContext db)
        {
            this.db = db;
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            var pro = db.Products.Find(productId);
            if (pro == null) return;
            db.Products.Remove(pro);
            db.SaveChanges();
        }

        public Product GetProductById(int productId)
        {
            return db.Products.Find(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return db.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByCategoryId(int categoryId)
        {
            var pro = db.Products.Where(x => x.CategoryId == categoryId).ToList();
            return pro;
        }

        public void UpdateProduct(Product product)
        {
            var pro = db.Products.Find(product.ProductId);
            pro.Name = product.Name;
            pro.CategoryId = product.CategoryId;
            pro.Price = product.Price;
            pro.Quantity = product.Quantity;
            db.SaveChanges();
        }

    }
}
