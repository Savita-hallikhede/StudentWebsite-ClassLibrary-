using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Entity1;
using ServiceContracts.DTO;

namespace StudentWebsite_ClassLibrary_.Controllers
{
    public class StdController : Controller
    {

        private IStdService _obj;
        public StdController(IStdService obj)
        {
            _obj = obj;
        }

        public IActionResult ShowStdData()
        {
            List<StdResponse> allStdData  = _obj.GetAllStds();
               
            return View(allStdData);
        }
    }
}
