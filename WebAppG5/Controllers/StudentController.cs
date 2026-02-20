using Microsoft.AspNetCore.Mvc;
using WebAppG5.Models;

namespace WebAppG5.Controllers
{
    public class StudentController : Controller
    {
        StudentBL stdBl = new StudentBL();

        //Student/All
        public IActionResult All()
        {
            List<Student> studends= stdBl.GetAll();//get data from model
            return View("ShowAll",studends);//go view with List<student>
        }
    }
}
