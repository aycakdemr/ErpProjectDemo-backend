using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.NpgSql;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpProjectDemo.Controllers
{
    public class NotificationController : Controller
    {
        private INotificationService nm;

        public NotificationController(INotificationService nm)
        {
            this.nm = nm;
        }

        public IActionResult Index()
        {
            var values = nm.GetAll().Data;
            return View(values);
        }
        public IActionResult DeleteNotification(int id)
        {
            nm.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
