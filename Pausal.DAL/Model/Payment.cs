using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Payment")]
   public class Payment : Entity
   {
      public string? Date { get; set; }
      public string? Method { get; set; }
      public decimal Advance { get; set; }
      public decimal Total { get; set; }
   }
}
