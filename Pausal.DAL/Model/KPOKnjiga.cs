using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("KPOKnjiga")]
   public class KPOKnjiga : Entity
   {
      public Preduzece? Preduzece { get; set; }
      public PoslovnaGodina? PoslovnaGodina { get; set; }
      public ICollection<Faktura>? Fakture { get; set; }
      public decimal Ukupno { get; set; }
   }
}
