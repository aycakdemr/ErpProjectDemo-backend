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
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public IResult Add(Contact t)
        {
            _contactDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _contactDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _contactDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<Contact>> GetById(int id)
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IResult Update(Contact t)
        {
            _contactDal.Update(t);
            return new SuccessResult(Messages.updated);
        }
    }
}
