using BusinessLayer.Abstract;
using BusinessLayer.Constans;
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
    public class BranchManager : IBranchService
    {
        IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public IResult Add(Branch t)
        {
            _branchDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _branchDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _branchDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Branch>> GetAll()
        {
            return new SuccessDataResult<List<Branch>>(_branchDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<Branch>> GetById(int id)
        {
            return new SuccessDataResult<List<Branch>>(_branchDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IResult Update(Branch t)
        {
            _branchDal.Update(t);
            return new SuccessResult(Messages.added);
        }
    }
}
