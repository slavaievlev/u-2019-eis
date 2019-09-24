using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Должность
    public class EmployeesPosition
    {
        [Key]
        private int Id { get; set; }

        [Required]
        private string Name { get; set; }

        [Required]
        private int Salary { get; set; }

        [ForeignKey("EmployeePositionId")]
        public virtual List<Employee> Employees { get; set; }
    }
}
