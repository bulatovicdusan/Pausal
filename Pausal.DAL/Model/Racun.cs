using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Pausal.DAL.Enums.Enums;

namespace Pausal.DAL.Model
{
   [Table("Racun")]
   public class Racun : Entity
   {
      public string? Naziv { get; set; }
      public string? BrojRacuna { get; set; }
      public Valuta Valuta { get; set; }
      public bool Aktivan { get; set; }

   }

}
