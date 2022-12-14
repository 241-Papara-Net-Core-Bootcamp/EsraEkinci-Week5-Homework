using Repository.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Repository.Data.Abstracts
{
    public interface IRepository<T> where T : class
    {

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void HardDelete(T entity);
        IQueryable<T> GetById(int id);
        IQueryable<T> UpdateGetAll();


    }






}
