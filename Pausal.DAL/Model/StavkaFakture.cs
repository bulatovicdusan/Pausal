using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("StavkaFakture")]
   public class StavkaFakture : Entity
   {
      public decimal Kolicina { get; set; }
      public decimal Rabat { get; set; }
      public decimal JedinicnaCena { get; set; }
      public decimal Osnovica { get; set; }
      public decimal UkupnaCena { get; set; }
      public RobaUsluga? RobaUsluga { get; set; }

   }
}
