using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Client")]
   public class Client : Entity
   {
      public string? Name { get; set; }
      public string? Email { get; set; }
      public int PIB { get; set; }
      public int IdentificationNumber { get; set; }
      public Address? Address { get; set; }
      public Account? Account { get; set; }
   }
}
