using Microsoft.AspNetCore.Mvc;
using WebAppG5.Models;

namespace WebAppG5.Controllers
{
    public class DepartmentController : Controller
    {
        StepsContext context=new StepsContext();
        public IActionResult Index()
        {
            List<Department> deptList = context.Departments.ToList();
            return View("Index",deptList);
        }

        #region New
        //Department/NEw
        [HttpGet]
        public IActionResult New()
        {
            return View("New");//Modedl Null
        }
        //Department/SaveNew?Name=&ManagerName=
        //handel only post req
        [HttpPost]
        public IActionResult SaveNew(Department dept)//,string Name,string ManagerName)
        {
            //if (Request.Method == "POST") { }
            //Department dept = new Department();
            //dept.Name= Name;
            //dept.ManagerName= ManagerName;
            if (dept.Name != null)
            {
                context.Departments.Add(dept);
                context.SaveChanges();//<---
                return RedirectToAction("Index", "Department");
            }
            return View("New", dept);
        }
        #endregion
    }
}
