using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGenericService<T>
    {
        void Save(T entity);
        void Delete(T entity);
        void Update(T entity);
        T GetById(int id);
        List<T> GetAll();
    }
}
