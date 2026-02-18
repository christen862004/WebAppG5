using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppG5.Models;

namespace WebAppG5.Controllers
{
    //1) End With Controller
    //2) inherit form Controller
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //Home/showText
        //public string showText()
        //{
        //    return "Heloooooooooooo";
        //}
        public ContentResult ShowText()
        {
            //logic
            //Decalre result
            ContentResult result = new ContentResult();
            //set data
            result.Content = "Hello from action";
            //return
            return result;
        }
        //Home/ShowView
        public ViewResult ShowView()
        {
            //logic
            //declare result
            ViewResult result=new ViewResult();
            //set 
            result.ViewName = "View1";
            //return
            return result;
        }
        //Home/ShowMix?id=12&name=ahmed
        //Home/ShowMix?id=13&name=alaa
        //Home/ShowMix/12?name=alaa
        public IActionResult ShowMix(int id,string name)
        {
            if (id == 13)
            {
                //logic
              
                //return
                return Content("Close");
            }
            else
            {
                //logic
                //declare result 
                return View("View1");
            }
        }
        //public ViewResult View(string ViewNAme) {
        //    {
        //        ViewResult result = new ViewResult();
        //        //set 
        //        result.ViewName = ViewNAme;
        //        //return
        //        return result;
        //    } 
        

        /*
         1- content   ==>ContentResult
         2- View      ==>ViewResult
         3- Json      ==>JsonResult
         4- NotFound  ==>NtFoundResult
         5- unauthorize....
        ................
         
         */





        //call Action ==>endpoint
        /*
         1) must be public
         2) must not be static
         3) cant be overload (only in one case )
         */
        

        //Home/index
        public IActionResult Index()
        {
            return View();
        }
        //Home/Privacy
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
