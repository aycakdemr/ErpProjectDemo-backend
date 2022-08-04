using DataAccessLayer.Abtract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.NpgSql
{
   public class EfTableDal : EfEntityRepositoryBase<Table>, ITableDal
    {
        public List<TableSectionUserDto> GetTableDetails()
        {
            using (ERPContext context = new ERPContext(new DbContextOptions<ERPContext>()))
            {
                var result = from t in context.Tables
                             join user in context.Users on t.UserId equals user.Id
                             join branch in context.Branches on t.BranchId equals branch.Id
                             join section in context.Sections on t.SectionId equals section.Id
                             select new TableSectionUserDto
                             {
                                 TableId = t.Id,
                                 BranchName = branch.Name,
                                 NumberOfChair = t.NumberOfChair,
                                 SectionName = section.Name,
                                 TableNumber = t.TableNumber,
                                 UserName = user.FirstName +" " +user.LastName,
                                 Status = t.Status
                                    
                             };
                return result.ToList();
            }
        }
    }
}
