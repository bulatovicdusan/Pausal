using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Tax")]
   public class Tax : Entity
   {
      public decimal PIO { get; set; }
      public decimal HealthCare { get; set; }
      public decimal IncomeTax { get; set; }
      public decimal Unemployment { get; set; }

   }
}
