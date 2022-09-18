using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("AccountTransaction")]
   public class AccountTransaction : Entity
    {
        public int AccountId { get; set; }
        public int TransactionId { get; set; }

        public Account? Account { get; set; }
        public Transaction? Transaction { get; set; }
    }
}
