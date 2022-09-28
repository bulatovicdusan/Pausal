using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("PoslovnaGodina")]
   public class PoslovnaGodina : Entity
   {
      public int Godina { get; set; }
      public bool Zakljucena { get; set; }
   }
}
