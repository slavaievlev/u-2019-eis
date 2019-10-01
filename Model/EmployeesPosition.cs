using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisModel
{
    // Должность
    public class EmployeesPosition
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Salary { get; set; }

        [ForeignKey("EmployeePositionId")]
        public virtual List<Employee> Employees { get; set; }
    }
}
