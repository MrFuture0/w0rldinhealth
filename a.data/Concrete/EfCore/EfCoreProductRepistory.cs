using System.Collections.Generic;
using System.Linq;
using a.data.Abstract;
using a.entity;

namespace a.data.Concrete.EfCore
{
    public class EfCoreProductRepistory : EfCoreGenericRepistory<Product, shopcontext>, IProductRepistory
    {
        public List<Product> GetPopularProduct()
        {
            using (var context = new shopcontext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}