using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.NpgSql;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpProjectDemo.Controllers
{
    public class SectionController : Controller
    {
        SectionManager sm = new SectionManager(new EFSectionDal());
        public IActionResult Index()
        {
            var values = sm.GetAll().Data;
            return View(values);
        }
    }
}
