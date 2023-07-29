using EmployeeAccountingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingApplication.Services
{
    public interface IDepartmentRepository
    {
        List<Department> GetDepartments();
        List<Department> GetDepartmentsWithEmployees();
        List<Department> GetFilteredDepartmentsWithEmployees(int? departmentId);
        Department GetDepartment(int departmentId);
        void AddDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int departmentId);
    }
}
