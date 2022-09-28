using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Doprinosi")]
   public class Doprinosi : Entity
   {
      public decimal PIO { get; set; }
      public decimal Zdravstveno { get; set; }
      public decimal PorezNaDobit { get; set; }
      public decimal Nezaposlenost { get; set; }
      public PoslovnaGodina? PoslovnaGodina { get; set; }

   }
}
