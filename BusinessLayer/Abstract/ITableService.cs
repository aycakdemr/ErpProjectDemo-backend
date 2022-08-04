using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ITableService : IService<Table>
    {
        IDataResult<List<TableSectionUserDto>> GetTableDetails();
    }
}
