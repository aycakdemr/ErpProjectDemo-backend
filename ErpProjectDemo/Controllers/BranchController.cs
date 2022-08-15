using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.NpgSql;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpProjectDemo.Controllers
{

    public class BranchController : Controller
    {
        BranchManager bm = new BranchManager(new EfBranchDal());
        public IActionResult Index()
        {
            var val = bm.GetAll().Data;
            return View(val);
        }
        public IActionResult DeleteBranch(int id)
        {
            bm.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBranch(int id)
        {
            var value = bm.GetById(id).Data.FirstOrDefault();
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateBranch(Branch w)
        {
            bm.Update(w);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddBranch()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddBranch(Branch s)
        {
           
                bm.Add(s);
                return RedirectToAction("Index");
           
        }
    }
}
