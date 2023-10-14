using EmployeeManagementModels;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Api.Models
{
    public interface IDepartmentRepository 
    {
        IEnumerable<Department> GetDepartments();
        Department GetDepartment(int departmentId);
    }
}
