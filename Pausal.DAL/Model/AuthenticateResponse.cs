using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   public class AuthenticateResponse
   {
      public Korisnik? Korisnik { get; set; }

      public string? Token { get; set; }
   }
}
