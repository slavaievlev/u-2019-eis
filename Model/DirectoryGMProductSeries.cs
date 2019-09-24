using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // For relationship betweet DirectoryGM and ProductSeries
    public class DirectoryGMProductSeries
    {
        [Key]
        public int Id { get; set; }

        public virtual DirectoryGM DirectoryGM { get; set; }

        [Required]
        public int DirectoryGMId { get; set; }

        public virtual ProductSeries ProductSeries { get; set; }

        [Required]
        private int ProductSeriesId { get; set; }

        [Required]
        // Розничная цена
        public int RetailPrice { get; set; }

        [Required]
        // Закупочная цена
        public int PurchasePrice { get; set; }

        [Required]
        public DateTime DeadlineForImplementation { get; set; }

        [ForeignKey("DirectoryGMProductSeriesId")]
        public virtual List<JournalOperations> JournalOperationsList { get; set; }
    }
}
