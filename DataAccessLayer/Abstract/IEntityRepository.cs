using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IEntityRepository<T>
    {
        void Add(T t);

        void Delete(T t);
        void Update(T t);
        List<T> GetAll();
        T GetById(int id);

        List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
