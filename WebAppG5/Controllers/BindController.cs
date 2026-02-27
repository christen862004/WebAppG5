using Microsoft.AspNetCore.Mvc;
using WebAppG5.Models;

namespace WebAppG5.Controllers
{
    public class BindController : Controller
    {
        //public - not static - overload only on case
        //Bind/M1
        [HttpGet]
        public IActionResult M1()
        {
            return Content("M! ggget");
        }
        //Bind/M1
        //Bind/M1/1
        //Bind/M1?id=1

        [HttpPost]
        public IActionResult M1(int id)
        {
            return Content("M! post");
        }



        /*
         <form action="/Bind/TestPrimitive/1" method=get>
            <input name="name" type=text>
            <input name="age" type=number>
            <input name="id" type=number>
            <input name="PhoneBook[ahmed]" type=number>
        </form>
         */
        //bind/testprimitive/11?name=ahmed&age=20
        //bind/testprimitive?name=ahmed&age=20&id=99&color=red&color=blue
        public IActionResult TestPrimitive(int age ,string name,int id,string[] color)
        {
            return Content($"{name}");
        }

        //collection list Dic
        //Bind/TestDic?name=ahmed&PhoneBook[ahmed]=133&PhoneBook[mohamed]=57777
        public IActionResult TestDic(string name,Dictionary<string,string> PhoneBook)
        {
            return Content($"{name}");

        }

        //object
        //Bind/TestObj?id=11&name=SD&MAnagerNAme=ahmed
        //public IActionResult TestObj(int Id, string Name, string ManagerName,List<Employee> Employees )
        public IActionResult TestObj(Department dept)
        {
            return Content($"ok");

        }
    }
}
