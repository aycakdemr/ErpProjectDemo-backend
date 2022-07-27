using CoreLayer.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IService<T>
    {
        IResult Add(T t);
        IResult Delete(int id);
        IResult Update(T t);
        IDataResult<List<T>> GetAll();
        IDataResult<List<T>> GetById(int id);
    }
}
