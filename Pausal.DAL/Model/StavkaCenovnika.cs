using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{

   [Table("StavkaCenovnika")]
   public class StavkaCenovnika : Entity
   {
      public decimal Cena { get; set; }
      public RobaUsluga? RobaUsluga { get; set; }
   }
}
