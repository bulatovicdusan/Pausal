using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("RobaUsluga")]
   public class RobaUsluga : Entity
   {
      public string? Naziv { get; set; }
   }
}
