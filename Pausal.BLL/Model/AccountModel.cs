using Pausal.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pausal.DAL.Enums.Enums;

namespace Pausal.BLL.Model
{
    public class AccountModel : EntityModel
    {
        public string? Name { get; set; }
        public string? Number { get; set; }
        public Currency Currency { get; set; }
        public ICollection<AccountTransaction>? AccountTransactions { get; set; }
    }
}
