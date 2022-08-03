using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.NpgSql;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ErpProjectDemo.ViewComponents
{
    public class ToDoList : ViewComponent
    {
        ToDoListManager tm = new ToDoListManager(new EfToDoListDal());

        public IViewComponentResult Invoke()
        {
            var v = tm.GetAll().Data;
            return View(v);
        }
    }
}
