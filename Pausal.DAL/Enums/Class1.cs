using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Enums
{
    public class Enums
    {
        public enum Currency 
        {
            RSD,
            Euro
        } 

        public enum Role
        {
            Admin,
            User
        }

        public enum EntryType
        {
            Income,
            Expense
        }
    }
}
