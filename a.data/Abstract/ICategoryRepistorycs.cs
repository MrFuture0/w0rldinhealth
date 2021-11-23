using a.entity;
using System.Collections.Generic;

namespace a.data.Abstract
{
    public interface ICategoryRepistorycs:IRepistory<Category>
    {
        List<Category> GetPopularCategories();
    }
}