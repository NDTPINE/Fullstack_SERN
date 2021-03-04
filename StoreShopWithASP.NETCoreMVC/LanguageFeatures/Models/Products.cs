using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Products
    {
        public string  Name { get; set; }
        public decimal? Price { get; set; }
        public static Products[] GetProducts()
        {
            Products kayak = new Products
            {
                Name = "Kayak",
                Price = 275M
            }; 
            Products lifejacket = new Products
            {
                Name = "Lifejacket",
                Price = 48.95M
            };
            Products soccer = new Products
            {
                Name = "Soccer",
                Price = 19.5M
            };
            Products flag = new Products
            {
                Name = "Flag",
                Price = 34.95M
            };
            return new Products[] { kayak, lifejacket, soccer,flag };
        }
    }
    //public interface IProductSelection
    //{
    //    IEnumerable<Products> products { get; }

    //}
    //public class ShoppingCart 
    //{
    //    private List<Products> products = new List<Products>();
    //    public ShoppingCart(params Products[] prods)
    //    {
    //        products.AddRange(prods);
    //    }
    //    public IEnumerable<Products> Products { get => products; }
    //    IEnumerable<string> Names => products.Select(p => p.Name);

    //}
    //public class ShoppingCart : IEnumerable<Products>
    //{
    //    public IEnumerable<Products> products { get; set; }

    //    public IEnumerator<Products> GetEnumerator()
    //    {
    //        return products.GetEnumerator();
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }
    //}
    public static class MyExtensionMethods { 
        public static decimal TotalPrices(this IEnumerable<Products> cartParam)
        {
            decimal total = 0;
            foreach (Products pro in cartParam)
            {
                total += pro?.Price ?? 0;
            }
            return total;
        }
        public static IEnumerable<Products> Filter(this IEnumerable<Products> productEnum, Func<Products, bool> selector) {
            foreach (Products pro in productEnum)
            {
                if (selector(pro))
                {
                    yield return pro;
                }
            }
        }
        //public static IEnumerable<Products> FilterByPrice(this IEnumerable<Products> productEnum, decimal minimumPrice)
        //{
        //    foreach (Products pro in productEnum)
        //    {
        //        if((pro.Price ?? 0) >= minimumPrice)
        //        {
        //            yield return pro;
        //        }
        //    }
        //}
        //public static IEnumerable<Products> FilterByName(this IEnumerable<Products> productEnum, char firstLetter)
        //{
        //    foreach (Products pro in productEnum)
        //    {
        //        if (pro.Name?[0] == firstLetter)
        //        {
        //            yield return pro;
        //        }
        //    }
        //}
    }
}
