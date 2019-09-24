using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // Журнал операций
    public class JournalOperations
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int Sum { get; set; }

        [Required]
        public int Count { get; set; }

        public virtual Provider Provider { get; set; }

        [Required]
        public int ProviderId { get; set; }

        public virtual Employee Employee { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        public virtual DirectoryGMProductSeries GetDirectoryGMProductSeries { get; set; }

        [Required]
        public int DirectoryGMProductSeriesId { get; set; }

        [ForeignKey("JournalOperationId")]
        public virtual List<JournalEntries> JournalEntriesList { get; set; }
    }
}
