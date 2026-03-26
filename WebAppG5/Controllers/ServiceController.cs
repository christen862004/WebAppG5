using Microsoft.AspNetCore.Mvc;
using WebAppG5.Repository;

namespace WebAppG5.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IService service;

        public ServiceController(IService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            ViewBag.Id = service.Id;
            return View("Index");
        }
    }
}
