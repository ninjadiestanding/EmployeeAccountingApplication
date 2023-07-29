using EmployeeAccountingApplication.Enums;
using EmployeeAccountingApplication.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace EmployeeAccountingApplication.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Наименование")]
        public string Name { get; set; }
        [DisplayName("Головное подразделение")]
        public string MainDepartmentName { get; set; }
        [DisplayName("Руководитель")]
        public string DirectorFullName { get; set; }
        [DisplayName("Состояние записи")]
        public string RecordStatus { get; set; }
    }
}
