﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.NpgSql;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpProjectDemo.Controllers
{
    public class TableController : Controller
    {
        TableManager tm = new TableManager(new EfTableDal());
        SectionManager sm = new SectionManager(new EFSectionDal());
        BranchManager bm = new BranchManager(new EfBranchDal());
        UserManager um = new UserManager(new EfUserDal());
        public IActionResult Index()
        {
            var val = tm.GetTableDetails().Data;
            return View(val);
        }
        public IActionResult DeleteTable(int id)
        {
            tm.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTable(int id)
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
                                                  Text = x.Name,
                                                  Value = x.Id.ToString()
                                              }).ToList();

            ViewBag.uv = uservalue;
            List<SelectListItem> sectionvalue = (from x in sm.GetAll().Data
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString()
                                                 }).ToList();

            ViewBag.sv = sectionvalue;
            var value = tm.GetById(id).Data.FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateTable(Table w)
        {
            tm.Update(w);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddTable()
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
                                                  Text = x.Name,
                                                  Value = x.Id.ToString()
                                              }).ToList();

            ViewBag.uv = uservalue;
            List<SelectListItem> sectionvalue = (from x in sm.GetAll().Data
                                              select new SelectListItem
                                              {
                                                  Text = x.Name,
                                                  Value = x.Id.ToString()
                                              }).ToList();

            ViewBag.sv = sectionvalue;
            return View();
        }
        [HttpPost]
        public IActionResult AddTable(Table s)
        {

            tm.Add(s);
            return RedirectToAction("Index");

        }
    }
}
