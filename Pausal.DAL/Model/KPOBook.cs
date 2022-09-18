using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("KPOBook")]
   public class KPOBook : Entity
   {
      public Entrepreneur? Entrepreneur { get; set; }
      public ICollection<KPOBookItem>? KPOBookItems { get; set; }

      public decimal TotalRevenue { get; set; }
   }
}
