using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Entrepreneur")]
   public class Entrepreneur : Entity
   {
      public string? Name { get; set; }
      public int PIB { get; set; }
      public int IdentificationNumber { get; set; }
      public Address? Address { get; set; }
      public string? PhoneNumber { get; set; }
      public Tax? Tax { get; set; }
      public Activity? PrimaryActivity { get; set; }
      public Activity? SecondaryActivity { get; set; }
      public List<Client>? Clients { get; set; }
      public List<Account>? Accounts { get; set; }
   }
}