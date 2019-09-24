using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    // План счетов
    public class ChartOfAccounts
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public string Name { get; set; }

        public int? SubcontoOne { get; set; }

        public int? SubcontoTwo { get; set; }

        public int? SubcontoThree { get; set; }
    }
}
