using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pausal.DAL.Enums.Enums;

namespace Pausal.DAL.Model
{
   [Table("Account")]
   public class Account : Entity
    {
        public string? Name { get; set; }
        public string? Number { get; set; }
        public Currency Currency { get; set; }
        public ICollection<AccountTransaction>? AccountTransactions { get; set; }
    }
}
