using CoreLayer.DataAccess;
using DataAccessLayer.Abtract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.NpgSql
{
    public class EfBranchDal : EfEntityRepositoryBase<Branch, ERPContext>, IBranchDal
    {
    }
}
