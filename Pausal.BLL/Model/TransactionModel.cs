using Pausal.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pausal.DAL.Enums.Enums;

namespace Pausal.BLL.Model
{
    public class TransactionModel : EntityModel
    {
        public EntryType Entry { get; set; }
        public decimal Amount { get; set; }

        public ICollection<AccountTransaction>? AccountTransactions { get; set; }
    }
}
