using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Faktura")]
   public class Faktura : Entity
   {
      public string? BrojFakture { get; set; }
      public DateOnly DatumIzdavanja { get; set; }
      public DateOnly DatumValute { get; set; }
      public decimal UkupanRabat { get; set; }
      public decimal UkupnaOsnovica { get; set; }
      public decimal UkupanPDV { get; set; }
      public decimal UkupanIznos { get; set; }
      public ICollection<StavkaFakture>? StavkeFakture { get; set; }
      public Preduzece? Preduzece { get; set; }
      public Kupac? Kupac { get; set; }

   }
}
