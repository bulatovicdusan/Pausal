using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Delatnost")]
   public class Delatnost : Entity
   {
      public int Sifra { get; set; }
      public string? Naziv { get; set; }
      public bool Primarna { get; set; }
   }
}
