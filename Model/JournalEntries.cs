using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EisModel
{
    // Журнал проводок
    public class JournalEntries
    {
        [Key]
        public int Id { get; set; }

        public string SubcontoDebitOne { get; set; }

        public string SubcontoDebitTwo { get; set; }

        public string SubcontoDebitThree { get; set; }

        public string SubcontoCreditOne { get; set; }

        public string SubcontoCreditTwo { get; set; }

        public string SubcontoCreditThree { get; set; }

        [Required]
        public int Sum { get; set; }

        [Required]
        public string Operation { get; set; }

        public string Comment { get; set; }

        [Required]
        public int Count { get; set; }

        public virtual JournalOperations JournalOperations { get; set; }

        [Required]
        public int JournalOperationId { get; set; }

        // Счет дебита
        public virtual ChartOfAccounts DebitAccount { get; set; }

        public int? DebitAccountId { get; set; }

        // Счет кредита
        public virtual ChartOfAccounts CreditAccount { get; set; }

        public int? CreditAccountId { get; set; }
    }
}
