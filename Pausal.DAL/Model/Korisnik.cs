using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Korisnik")]
   public class Korisnik : Entity
   {
      public string? Ime { get; set; }
      public string? Prezime { get; set; }
      public string? KorisnickoIme { get; set; }
      public string? Sifra { get; set; }
      public string? Email { get; set; }
      public Preduzece? Preduzece { get; set; }

   }
}
