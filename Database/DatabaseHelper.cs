using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingApplication.Database
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            string projectFolderPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string databaseFilePath = Path.Combine(projectFolderPath, ConfigurationManager.AppSettings["DatabaseLocalPath"]);

            return $"Data Source={databaseFilePath};";
        }
    }
}
