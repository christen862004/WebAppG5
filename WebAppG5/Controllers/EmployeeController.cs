using Microsoft.AspNetCore.Mvc;
using WebAppG5.Models;


namespace WebAppG5.Controllers
{
    public class EmployeeController : Controller
    {
        StepsContext context = new StepsContext();

        public EmployeeController()
        {
            
        }

        public IActionResult Index()
        {
            List<Employee> employees = context.Employees.ToList();
            return View("Index",employees);
        }

        #region Edit
        public IActionResult Edit(int id)
        {
           //collect
            Employee empFromdb=context.Employees.FirstOrDefault(e=>e.Id == id);
            List<Department> deptList=context.Departments.ToList();
            
            //decalre vm and map
            EmployeeWithDeptListViewModel empVM = new();
            empVM.ImageURL = empFromdb.ImageURL;
            empVM.Id = empFromdb.Id;
            empVM.Salary = empFromdb.Salary;
            empVM.EmpName = empFromdb.Name;
            empVM.DepartmentId = empFromdb.DepartmentId;
            empVM.Departments = deptList;
            //send vm view edit form
            return View("Edit", empVM);
        }
        //Employee/SaveEdit/1?Name=&Salary=&ImageURL=&DepartmentId=
        [HttpPost]
        public IActionResult SaveEdit(EmployeeWithDeptListViewModel EmpFromReq)//id .empname,salary ,imageurl,departmentID
        {
            if (EmpFromReq.EmpName != null)
            {
                Employee EmpFromDb = context.Employees.FirstOrDefault(e => e.Id == EmpFromReq.Id);
                EmpFromDb.Name = EmpFromReq.EmpName;
                EmpFromDb.ImageURL = EmpFromReq.ImageURL;
                EmpFromDb.Salary = EmpFromReq.Salary;
                EmpFromDb.DepartmentId = EmpFromReq.DepartmentId;
                context.SaveChanges();
                return RedirectToAction("Index", "Employee");
            }

            EmpFromReq.Departments = context.Departments.ToList();
            return View("Edit", EmpFromReq);
        }
        #endregion

        #region DEtails

        //Employee/Details/1
        //Employee/Details?id=1
        public IActionResult Details(int id)
        {
            Employee Emp= context.Employees.FirstOrDefault(e => e.Id == id);
            if (Emp != null)
            {
                string msg = "welcome";
                int temp = 20;
                List<string> branches = new List<string>() { "Alex", "Menia", "Smart", "New Capital" };

                ViewData["Msg"] = msg;
                ViewData["Temp"] = 20;
                ViewData["Branches"] = branches;
                ViewBag.Color = "red";
                ViewData["Color"] = "blue";//

                return View("Details", Emp);//Model

            }
            else
                return NotFound();
            //view "Details" ,Model Employee
        }

        public IActionResult DetailsVM(int id)
        {
            //Collect data
            Employee Emp = context.Employees.FirstOrDefault(e => e.Id == id);
            if (Emp != null)
            {
                string msg = "welcome";
                int temp = 20;
                List<string> branches = new List<string>() { "Alex", "Menia", "Smart", "New Capital" };
                string Color = "red";
                //Declare Vm
                EmpWithColroBranchesTempMsgViewModel empVM = new();
                //Mapping
                empVM.EmpID = Emp.Id;
                empVM.EmpName = Emp.Name;
                empVM.Color = Color;
                empVM.Temp = temp;
                empVM.Branches = branches;
                empVM.Message = msg;
                //Send Vm To View

                return View("DetailsVM", empVM);//Model EmpWithColroBranchesTempMsgViewModel

            }
            else
                return NotFound();

           
        }
        #endregion

    }
}
