using BusinessLayer.Abstract;
using BusinessLayer.Constans;
using CoreLayer.Entities;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abtract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User t)
        {
            _userDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _userDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _userDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<User>> GetById(int id)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public User GetByMail(string email)
        {
            return _userDal.GetByMail(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IResult Update(User t)
        {
            _userDal.Update(t);
            return new SuccessResult(Messages.added);
        }
    }
}
