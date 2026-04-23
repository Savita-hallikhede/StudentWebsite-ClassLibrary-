using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using Entity1;
using ServiceContracts.DTO;
using Service;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace StudentWebsite_ClassLibrary_.Controllers
{
    public class StdController : Controller
    {
        // Service objects (Dependency Injection)
        // These are used to call business logic layer(StdService)
        private IStdService _obj;
        private IClgService _clgObj;

        //created a constructor to inject the service class object into the controller class
        public StdController(IStdService obj, IClgService clgObj)
        {
            _obj = obj;
            _clgObj = clgObj;
        }


        // ================= COLLEGE DATA =================

        // GET: Show all college records
        public IActionResult ShowClgData()
        {
            // Fetch all colleges from service
            List<ClgResponse> allClgData = _clgObj.GetAllClgs();
            // Send data to View
            return View(allClgData);

        }


        // ================= STUDENT LIST =================

        // GET: Show all student data
        [HttpGet]
        //[Route("[action]")]
        public IActionResult ShowStdData()
        {
            // Fetch all students
            List<StdResponse> allStdData = _obj.GetAllStds();

            // Pass data to View
            return View(allStdData);
        }



        // ================= ADD STUDENT (GET) =================
        // GET: Show empty form
        [HttpGet]
        public IActionResult Add()
        {
            // Get all students (used for dropdown or reference list)
            List<StdResponse> stds = _obj.GetAllStds();

            // Convert student list into dropdown format (SelectListItem)
            ViewBag.Stds = stds.Select(temp =>
                new SelectListItem
                {
                    Text = temp.StdName,   // Display text in dropdown
                    Value = temp.StdId.ToString() // Hidden value
                }).ToList();

            // Return Add view (form page)
            return View();
        }


        // ================= ADD STUDENT (POST) ================= 
        // POST: Submit form data

        [HttpPost]
        // This method receives data from Add Student form
        public IActionResult Add(StdAddRequest stdAddRequest)
        {
            // Call service layer to add student into database
            StdResponse stdResponse = _obj.AddStd(stdAddRequest);

            // After saving, redirect to student list page
            return RedirectToAction("ShowStdData");
        }
    }
}
        