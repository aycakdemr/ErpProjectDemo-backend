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
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public IResult Add(Notification t)
        {
            _notificationDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _notificationDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _notificationDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Notification>> GetAll()
        {
            return new SuccessDataResult<List<Notification>>(_notificationDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<Notification>> GetById(int id)
        {
            return new SuccessDataResult<List<Notification>>(_notificationDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IResult Update(Notification t)
        {
            _notificationDal.Update(t);
            return new SuccessResult(Messages.updated);
        }
    }
}
