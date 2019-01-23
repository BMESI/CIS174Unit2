using System.Collections.Generic;
using Unit2A3.Shared.ViewModels;

namespace Unit2A3.Shared.Orchestrators.Interfaces
{
    public interface IStudentOrchestrator
    {
        List<StudentViewModel> GetAllStudents();
    }
}
