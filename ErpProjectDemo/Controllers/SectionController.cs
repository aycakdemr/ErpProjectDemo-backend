using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.NpgSql;
using EntityLayer.Concrete;
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
            var values = sm.GetSectionDetails().Data;
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSection()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSection(Section s)
        {
            s.Status = true;
            sm.Add(s);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteSection(int id)
        {
            sm.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateSection(int id)
        {
            var value = sm.GetById(id).Data.FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateSection(Section w)
        {
            sm.Update(w);
            return RedirectToAction("Index");
        }
    }
}
