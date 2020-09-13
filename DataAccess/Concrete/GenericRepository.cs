using DataAccess.Abstract;
using DataAccess.Context;
using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, ITable, new()
    {
        public void Delete(T entity)
        {
            using var context = new ExamContext();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var context = new ExamContext();
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var context = new ExamContext();
            return context.Set<T>().Find(id);
        }

        public void Save(T entity)
        {
            using var context = new ExamContext();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using var context = new ExamContext();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}
