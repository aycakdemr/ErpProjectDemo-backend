using DataAccessLayer.Abtract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.NpgSql
{
    public class EfBranchDal : EfEntityRepositoryBase<Branch>, IBranchDal
    {

    }
}
