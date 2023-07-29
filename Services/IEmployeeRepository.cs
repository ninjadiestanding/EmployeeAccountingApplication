using EmployeeAccountingApplication.Models;
using EmployeeAccountingApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingApplication.Services
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
        List<Employee> GetEmployeesWithDepartments();
        List<Employee> GetFilteredEmployeesWithDepartments(int? employeeId, int? departmentId, string fullName, string personnelNumber);
        Employee GetEmployee(int employeeId);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int employeeId);

        int GetHiredEmployeesNumber(DateTime startDate, DateTime endDate, int? departmentId);
        int GetFiredEmployeesNumber(DateTime startDate, DateTime endDate, int? departmentId);
    }
}
