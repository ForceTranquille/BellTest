using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DAL;
using WEB.UI.Models;

namespace WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        private HelpDeskEntities contextEF = new HelpDeskEntities();

        public ActionResult Index()
        {
            List<Department> departments = contextEF.Department.ToList();
            ViewBag.departments = new SelectList(departments, "DEPNO", "DNAME");
            return View();
        }

        public JsonResult GetEmpList(int DEPNO)
        {
            contextEF.Configuration.ProxyCreationEnabled = false;
            List<Employee> employeeList = contextEF.Employee.Where(e => e.DEPNO == DEPNO).ToList();
            return Json(employeeList, JsonRequestBehavior.AllowGet);
        }


        public ActionResult GetData()
        {
            int project = contextEF.Ticket.Where(x => x.PROJECTNAME == "TEST").Count();
            int other = contextEF.Ticket.Where(x => x.PROJECTNAME == "testmappape").Count();

            Ratio obj = new Ratio();
            obj.Project = project;
            obj.Other = other;

            return Json(obj, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
        public ActionResult Report()
        {
            return View();
        }

    }
}