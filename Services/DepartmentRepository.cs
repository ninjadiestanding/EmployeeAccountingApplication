using EmployeeAccountingApplication.DBContext;
using EmployeeAccountingApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingApplication.Services
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private AppDBContext _dbContext;

        public DepartmentRepository(AppDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public List<Department> GetDepartments()
        {
            return _dbContext.Departments.ToList();
        }

        public List<Department> GetDepartmentsWithEmployees()
        {
            return _dbContext.Departments.Include(d => d.Director).ToList();
        }

        public List<Department> GetFilteredDepartmentsWithEmployees(int? departmentId)
        {
            var query = _dbContext.Departments.AsQueryable();

            if (departmentId.HasValue)
            {
                query = query.Where(d => d.Id == departmentId.Value);
            }

            var filteredDepartments = query.ToList();
            return filteredDepartments;
        }

        public Department GetDepartment(int departmentId)
        {
            return _dbContext.Departments.Include(d => d.Director).FirstOrDefault(d => d.Id == departmentId);
        }

        public void AddDepartment(Department department)
        {
            _dbContext.Departments.Add(department);
            _dbContext.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            _dbContext.Update(department);
            _dbContext.SaveChanges();
        }

        public void DeleteDepartment(int departmentId)
        {
            var departmentToDelete = _dbContext.Departments.Find(departmentId);

            if (departmentToDelete != null)
            {
                _dbContext.Departments.Remove(departmentToDelete);
                _dbContext.SaveChanges();
            }
        }
    }
}
