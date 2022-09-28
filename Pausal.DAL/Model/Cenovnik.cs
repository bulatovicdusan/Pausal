using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Cenovnik")]
   public class Cenovnik : Entity
   {
      public DateOnly DatumVazenja { get; set; }
      public ICollection<StavkaCenovnika>? StavkeCenovnika { get; set; }
   }
}
