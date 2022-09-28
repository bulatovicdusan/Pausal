using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Nalog")]
   public class Nalog : Entity
   {
      public string? Duznik { get; set; }
      public string? Poverilac { get; set; }
      public string? SvrhaPlacanja { get; set; }
      public DateOnly? Datum { get; set; }
      public int SifraPlacanja { get; set; }
      public string? PozivNaBroj { get; set; }
      public decimal? Iznos { get; set; }
      public Racun? RacunPrimaoca { get; set; }
   }
}
