using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pausal.DAL.Enums.Enums;

namespace Pausal.DAL.Model
{
   [Table("Transaction")]
   public class Transaction : Entity
    {
        public EntryType Entry { get; set; }
        public decimal Amount { get; set; }           
        public ICollection<AccountTransaction>? AccountTransactions { get; set; }
    }
}
