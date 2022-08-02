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
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDal());
        public IActionResult Index()
        {
            var values = mm.GetMailByReceiver("ayca@ayca.com").Data;
            return View(values);
        }
        public IActionResult SendersMail()
        {
            var values = mm.GetMailBySender("ayca@ayca.com").Data;
            return View(values);
        }
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMail(Message m)
        {
            m.SenderMail = "ayayay@gmail.com";
            m.Status = false;
            m.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            mm.Add(m);
            return RedirectToAction("Index");
        }
        public IActionResult MailBoxPartial()
        {
            return PartialView();
        }
        public IActionResult MailDetail(int id)
        {
            var value = mm.GetById(id).Data;
            return View(value);
        }
        public IActionResult DeleteMail(int id)
        {
            mm.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
