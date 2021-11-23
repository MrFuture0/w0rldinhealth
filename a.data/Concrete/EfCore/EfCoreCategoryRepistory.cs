using System.Collections.Generic;
using a.data.Abstract;
using a.entity;

namespace a.data.Concrete.EfCore
{
    public class EfCoreCategoryRepistory : EfCoreGenericRepistory<Category, shopcontext>, ICategoryRepistorycs
    {
        public List<Category> GetPopularCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}