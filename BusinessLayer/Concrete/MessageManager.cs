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
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public IResult Add(Message t)
        {
            _messageDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _messageDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _messageDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Message>> GetAll()
        {
            return new SuccessDataResult<List<Message>>(_messageDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<Message>> GetById(int id)
        {
            return new SuccessDataResult<List<Message>>(_messageDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IResult Update(Message t)
        {
            _messageDal.Update(t);
            return new SuccessResult(Messages.updated);
        }
    }
}
