﻿using CoreLayer;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abtract
{
    public interface ITableDal : IEntityRepository<Table>
    {
        List<TableSectionUserDto> GetTableDetails();
    }
}
