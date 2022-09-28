using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Adresa")]
   public class Adresa : Entity
   {
      public string? Grad { get; set; }
      public string? PostanskiBroj { get; set; }
      public string? Ulica { get; set; }
   }
}
