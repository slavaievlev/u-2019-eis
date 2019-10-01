using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisModel
{
    // Справочник ТМЦ
    public class DirectoryGM
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("DirectoryGMId")]
        public virtual List<DirectoryGMProductSeries> DirectoryGMProductSeriesList { get; set; }
    }
}
