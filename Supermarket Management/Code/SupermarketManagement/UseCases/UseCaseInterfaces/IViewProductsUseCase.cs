using CoreBusiness;
using System.Collections.Generic;

namespace UseCases.ProductsUseCases
{
    public interface IViewProductsUseCase
    {
         public IEnumerable<Product> Execute();
    }
}