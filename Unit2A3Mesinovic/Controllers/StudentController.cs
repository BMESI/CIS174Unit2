using System.Web.Mvc;
using Unit2A3.Shared.Enums;
using Unit2A3.Shared.Orchestrators;
using Unit2A3Mesinovic.Models;

namespace Unit2A3Mesinovic.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var studentOrchestrator = new StudentOrchestrator();
            var studentViewModelcontroller = new StudentModel
            {
            // We dont need this sample data here , but either way, the app now works with data given from controller or orchestrator 
                StudentsList = studentOrchestrator.GetAllStudents(),
                FirstName = "Ben",
                LastName = "Mesinovic",
                Age = "31",
                Major = "BIS",
                Gender = GenderEnums.Male
            };
            return View(studentViewModelcontroller);
        }
    }
}