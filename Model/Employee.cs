using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Сотрудник
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FIO { get; set; }

        public virtual Subdivision Subdivision { get; set; }

        [Required]
        public int SubdivisionId { get; set; }

        public virtual EmployeesPosition EmployeePosition { get; set; }

        [Required]
        public int EmployeePositionId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual List<JournalOperations> JournalOperationsList { get; set; }
    }
}
