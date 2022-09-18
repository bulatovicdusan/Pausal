using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Address")]
   public class Address : Entity
   {
      public string? City { get; set; }
      public string? Postcode { get; set; }
      public string? Street { get; set; }
   }
}
