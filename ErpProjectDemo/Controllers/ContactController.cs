using BusinessLayer.Abstract;
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
    public class ContactController : Controller
    {
        private IContactService cm;

        public ContactController(IContactService cm)
        {
            this.cm = cm;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContact(Contact c)
        {
            cm.Add(c);
            return View();
        }
    }
}
