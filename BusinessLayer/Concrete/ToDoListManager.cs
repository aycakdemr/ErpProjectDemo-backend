using BusinessLayer.Abstract;
using BusinessLayer.Constans;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ToDoListManager : IToDoListService
    {
        IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public IResult Add(ToDoList t)
        {
            _toDoListDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _toDoListDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _toDoListDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<ToDoList>> GetAll()
        {
            return new SuccessDataResult<List<ToDoList>>(_toDoListDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<ToDoList>> GetById(int id)
        {
            return new SuccessDataResult<List<ToDoList>>(_toDoListDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IResult Update(ToDoList t)
        {
            _toDoListDal.Update(t);
            return new SuccessResult(Messages.updated);
        }
    }
}
