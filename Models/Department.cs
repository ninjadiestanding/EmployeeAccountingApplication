using EmployeeAccountingApplication.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmployeeAccountingApplication.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [ForeignKey("MainDepartment")]
        public int? MainDepartmentId { get; set; }
        public Department MainDepartment { get; set; }


        [ForeignKey("Director")]
        public int? DirectorId { get; set; }
        public Employee Director { get; set; }


        [Required]
        public RecordStatusEnum RecordStatus { get; set; }
    }
}
