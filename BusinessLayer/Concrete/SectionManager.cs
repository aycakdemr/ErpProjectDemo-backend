using BusinessLayer.Abstract;
using BusinessLayer.Constans;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abtract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SectionManager : ISectionService
    {
        ISectionDal _sectionDal;

        public SectionManager(ISectionDal sectionDal)
        {
            _sectionDal = sectionDal;
        }

        public IResult Add(Section t)
        {
            _sectionDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _sectionDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _sectionDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Section>> GetAll()

        {
            Console.WriteLine(_sectionDal.GetAll());
            return new SuccessDataResult<List<Section>>(_sectionDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<Section>> GetById(int id)
        {
            return new SuccessDataResult<List<Section>>(_sectionDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IDataResult<List<SectionDto>> GetSectionDetails()
        {
            return new SuccessDataResult<List<SectionDto>>(_sectionDal.GetSectionDetails(), Messages.succeed);
        }

        public IResult Update(Section t)
        {
            _sectionDal.Update(t);
            return new SuccessResult(Messages.added);
        }
    }
}
