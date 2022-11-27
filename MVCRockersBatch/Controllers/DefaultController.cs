using MVCRockersBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRockersBatch.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        [NonAction]
        public string GetData()
        {
            return "HelloWorld";
        }
        public string GetDataById(int? id=1)
        {
            return "MY Employee Id is :" + id + " " + GetData();
        }

        public string GetMultipleParamData(int? id,string name)
        {
            return "MY Employee Id is :" + id + " " + GetDataById()+" "+name+" ";
        }
        public ActionResult GetMeView()
        {
            return View("~/Views/AboutUs/TestingView.cshtml");
        }

        public ActionResult GetResultView()
        {
            ViewBag.Name="Ram";
            return View();
        }
        public ActionResult SendData()
        {
            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Raj";
            emp.EmpSalary = 30000;

            ViewBag.empInfo = emp;
            return View();
        }

        public ActionResult SendData2()
        {
            List<EmployeeModel> listEmp = new List<EmployeeModel>();

            EmployeeModel emp = new EmployeeModel();
            emp.EmpId = 1;
            emp.EmpName = "Raj";
            emp.EmpSalary = 30000;

            EmployeeModel emp1 = new EmployeeModel();
            emp1.EmpId = 2;
            emp1.EmpName = "Rani";
            emp1.EmpSalary = 31000;

            EmployeeModel emp2 = new EmployeeModel();
            emp2.EmpId = 3;
            emp2.EmpName = "Raji";
            emp2.EmpSalary = 32000;

            listEmp.Add(emp);
            listEmp.Add(emp1);
            listEmp.Add(emp2);

            ViewBag.empInfo = listEmp;
            return View();
        }
    }
}