using a.entity;
using System.Collections.Generic;

namespace a.data.Abstract
{
    public interface IRepistory<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity); 
    }
}