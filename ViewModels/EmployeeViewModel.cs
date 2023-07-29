using EmployeeAccountingApplication.Enums;
using EmployeeAccountingApplication.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class EmployeeViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string FullName { get; set; }
        [DisplayName("Табельный номер")]
        public string PersonnelNumber { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        [DisplayName("Подразделение")]
        public string DepartmentName { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        [DisplayName("Телефон")]
        public string PhoneNumber { get; set; }
        [DisplayName("Дата приема")]
        public DateTime EmploymentDate { get; set; }
        [DisplayName("Состояние записи")]
        public string RecordStatus { get; set; }
        [DisplayName("Дата увольнения")]
        public DateTime? DateOfDismissal { get; set; }
    }
}
