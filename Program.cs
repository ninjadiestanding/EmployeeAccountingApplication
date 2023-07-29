using EmployeeAccountingApplication.DBContext;
using EmployeeAccountingApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeAccountingApplication
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var dbContext = new AppDBContext();
            var employeeRepository = new EmployeeRepository(dbContext);
            var departmentRepository = new DepartmentRepository(dbContext);

            Application.Run(new MainForm(employeeRepository, departmentRepository));
        }
    }
}
