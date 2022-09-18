using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("KPOBookItem")]
   public class KPOBookItem : Entity
   {
      public DateTime Date { get; set; }
      public Invoice? Invoice { get; set; }
      public string? Description { get; set; }
      public decimal SalesRevenue { get; set; }
      public decimal ServiceRevenue { get; set; }
      public decimal TotalRevenue { get; set; }
   }
}
