using Microsoft.AspNetCore.Mvc;

namespace StudentWebsite_ClassLibrary_.Controllers
{
    public class StudentWebController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
