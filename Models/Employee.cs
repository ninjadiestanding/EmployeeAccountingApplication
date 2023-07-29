using EmployeeAccountingApplication.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAccountingApplication.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PersonnelNumber { get; set; }
        [Required]
        public string Position { get; set; }


        [ForeignKey("Department")]
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }


        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime EmploymentDate { get; set; }
        [Required]
        public RecordStatusEnum RecordStatus { get; set; }
        [Column(TypeName = "DATETIME")]
        public DateTime? DateOfDismissal { get; set; }
    }
}
