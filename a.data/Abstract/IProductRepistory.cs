using System.Collections.Generic;
using a.entity;
namespace a.data.Abstract
{
    public interface IProductRepistory:IRepistory<Product>
    {
        List<Product> GetPopularProduct();

        List<Product> GetTop5Products();
    }
}