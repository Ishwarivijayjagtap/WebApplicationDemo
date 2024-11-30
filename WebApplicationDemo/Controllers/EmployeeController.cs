using Microsoft.AspNetCore.Mvc;

namespace WebApplicationDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
