using Pausal.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.BLL.Model
{
    public class AccountTransactionModel : EntityModel
    {
        public int AccountId { get; set; }
        public int TransactionId { get; set; }

        public Account? Account { get; set; }
        public Transaction? Transaction { get; set; }
    }
}
