using System.Collections.Generic;
using Unit2A3.Shared.Enums;
using Unit2A3.Shared.Orchestrators.Interfaces;
using Unit2A3.Shared.ViewModels;

namespace Unit2A3.Shared.Orchestrators
{
    public class StudentOrchestrator : IStudentOrchestrator
    {
        public List<StudentViewModel> GetAllStudents()
        {
            var StudentsFromOrch = new List<StudentViewModel>
            {                
                new StudentViewModel
                {
                FirstName= "Benji",
                LastName = "Mesinovici",
                Age = "30",
                Major = "BIS",
                Gender = GenderEnums.Male
                },
                 new StudentViewModel
                {
                FirstName = "1Ben2",
                LastName = "1Mesinovic2",
                Age = "1302",
                Major = "1BIS2",
                Gender = GenderEnums.Male
                }
            };
            return StudentsFromOrch;
        }
    }
}
