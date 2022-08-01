using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.NpgSql
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class
    {

        public void Delete(T t)
        {
            using var c = new ERPContext(new DbContextOptions<ERPContext>());
            c.Remove(t);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new ERPContext(new DbContextOptions<ERPContext>());
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            using var c = new ERPContext(new DbContextOptions<ERPContext>());
            return c.Set<T>().Find(id);
        }

        public void Add(T t)
        {
            using var c = new ERPContext(new DbContextOptions<ERPContext>());
            c.Add(t);
            c.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using var c = new ERPContext(new DbContextOptions<ERPContext>());
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            using var c = new ERPContext(new DbContextOptions<ERPContext>());
            c.Update(t);
            c.SaveChanges();
        }

    }
}
