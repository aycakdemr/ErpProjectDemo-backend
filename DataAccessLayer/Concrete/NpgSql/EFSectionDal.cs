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
    public class EFSectionDal : EfEntityRepositoryBase<Section>, ISectionDal
    {
        public List<SectionDto> GetSectionDetails()
        {
            using (ERPContext context = new ERPContext(new DbContextOptions<ERPContext>()))
            {
                var result = from sc in context.Sections
                             join user in context.Users on sc.UserId equals user.Id
                             join branch in context.Branches on sc.BranchId equals branch.Id
                             
                             select new SectionDto
                             {
                                 SectionId = sc.Id,
                                 BranchName = branch.Name,
                                 Name = sc.Name,
                                 Number = sc.Number,
                                 NumberOfTable = sc.NumberOfTable,
                                 UserName = user.Name
                             };
                return result.ToList();
            }
        }
    }
}
