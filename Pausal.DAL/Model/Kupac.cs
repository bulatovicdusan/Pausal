using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Kupac")]
   public class Kupac : Entity
   {
      public string? Naziv { get; set; }
      public string? Email { get; set; }
      public int PIB { get; set; }
      public int MIB { get; set; }
      public Adresa? Adresa { get; set; }
      public ICollection<Racun>? Racuni { get; set; }
      public ICollection<Faktura>? Fakture { get; set; }
   }
}
