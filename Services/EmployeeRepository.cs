using EmployeeAccountingApplication.Database;
using EmployeeAccountingApplication.DBContext;
using EmployeeAccountingApplication.Models;
using EmployeeAccountingApplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EmployeeAccountingApplication.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private AppDBContext _dbContext;

        public EmployeeRepository(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public List<Employee> GetEmployeesWithDepartments()
        {
            return _dbContext.Employees.Include(e => e.Department).ToList();
        }

        public List<Employee> GetFilteredEmployeesWithDepartments(int? employeeId, int? departmentId, string fullName, string personnelNumber)
        {
            var query = _dbContext.Employees.AsQueryable();

            if (employeeId.HasValue)
            {
                query = query.Where(e => e.Id == employeeId.Value);
            }

            if (departmentId.HasValue)
            {
                query = query.Where(e => e.DepartmentId == departmentId.Value);
            }

            if (!string.IsNullOrEmpty(fullName))
            {
                query = query.Where(e => e.FullName.Contains(fullName));
            }

            if (!string.IsNullOrEmpty(personnelNumber))
            {
                query = query.Where(e => e.PersonnelNumber.Contains(personnelNumber));
            }

            var filteredEmployees = query.ToList();
            return filteredEmployees;
        }

        public Employee GetEmployee(int employeeId)
        {
            return _dbContext.Employees.Include(e => e.Department).FirstOrDefault(e => e.Id == employeeId);
        }

        public void AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Update(employee);
            _dbContext.SaveChanges();
        }

        public void DeleteEmployee(int employeeId)
        {
            var employeeToDelete = _dbContext.Employees.Find(employeeId);

            if (employeeToDelete != null)
            {
                _dbContext.Employees.Remove(employeeToDelete);
                _dbContext.SaveChanges();
            }
        }

        public int GetHiredEmployeesNumber(DateTime startDate, DateTime endDate, int? departmentId)
        {
            var query = _dbContext.Employees.AsQueryable();

            if (departmentId.HasValue)
            {
                query = query.Where(e => e.DepartmentId == departmentId.Value);
            }

            query = query.Where(e => e.EmploymentDate >= startDate && e.EmploymentDate <= endDate);

            return query.Count();
        }

        public int GetFiredEmployeesNumber(DateTime startDate, DateTime endDate, int? departmentId)
        {
            var query = _dbContext.Employees.AsQueryable();

            if (departmentId.HasValue)
            {
                query = query.Where(e => e.DepartmentId == departmentId.Value);
            }

            query = query.Where(e => e.DateOfDismissal >= startDate && e.DateOfDismissal <= endDate);

            return query.Count();
        }
    }
}
