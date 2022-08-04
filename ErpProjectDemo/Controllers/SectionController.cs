using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.NpgSql;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpProjectDemo.Controllers
{
    public class SectionController : Controller
    {
        SectionManager sm = new SectionManager(new EFSectionDal());
        BranchManager bm = new BranchManager(new EfBranchDal());
        UserManager um = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            var values = sm.GetSectionDetails().Data;
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSection()
        {
            List<SelectListItem> branchvalue = (from x in bm.GetAll().Data
                                                select new SelectListItem
                                                {
                                                    Text = x.Name,
                                                    Value = x.Id.ToString()
                                                }).ToList();

            ViewBag.bv = branchvalue;
            List<SelectListItem> uservalue = (from x in um.GetAll().Data
                                              select new SelectListItem
                                              {
                                                  Text = x.FirstName+""+x.LastName,
                                                  Value = x.Id.ToString()
                                              }).ToList();

            ViewBag.uv = uservalue;
            
            return View();
        }
        [HttpPost]
        public IActionResult AddSection(Section s)
        {
            SectionValidator sv = new SectionValidator();
            ValidationResult result = sv.Validate(s);
            if (result.IsValid)
            {
                sm.Add(s);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            
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
