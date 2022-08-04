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
    public class TableManager : ITableService
    {
        ITableDal _tableDal;

        public TableManager(ITableDal tableDal)
        {
            _tableDal = tableDal;
        }

        public IResult Add(Table t)
        {
            _tableDal.Add(t);
            return new SuccessResult(Messages.added);
        }

        public IResult Delete(int id)
        {
            foreach (var _id in _tableDal.GetAll())
            {
                if (_id.Id == id)
                {
                    _tableDal.Delete(_id);
                    return new SuccessResult(Messages.deleted);

                }
            }
            return new ErrorResult(Messages.error);
        }

        public IDataResult<List<Table>> GetAll()
        {
            return new SuccessDataResult<List<Table>>(_tableDal.GetAll(), Messages.succeed);
        }

        public IDataResult<List<Table>> GetById(int id)
        {
            return new SuccessDataResult<List<Table>>(_tableDal.GetAll(p => p.Id == id), Messages.succeed);
        }

        public IDataResult<List<TableSectionUserDto>> GetTableDetails()
        {
            return new SuccessDataResult<List<TableSectionUserDto>>(_tableDal.GetTableDetails(), Messages.succeed);
        }

        public IResult Update(Table t)
        {
            _tableDal.Update(t);
            return new SuccessResult(Messages.added);
        }
    }
}
