using Org.BouncyCastle.Crypto.Macs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pausal.DAL.Model
{
   [Table("Preduzece")]
   public class Preduzece : Entity
   {
      public string? Naziv { get; set; }
      public int PIB { get; set; }
      public int MIB { get; set; }
      public Adresa? Adresa { get; set; }
      public string? Telefon { get; set; }
      public ICollection<Doprinosi>? Doprinosi { get; set; }
      public ICollection<Delatnost>? Delatnosti { get; set; }
      public ICollection<Racun>? Racuni { get; set; }
      public ICollection<Faktura>? Fakture { get; set; }
      public ICollection<Kupac>? Kupci { get; set; }
      public ICollection<PoslovnaGodina>? PoslovneGodine { get; set; }
      public ICollection<Korisnik>? Korisnici { get; set; }
      public ICollection<Dobavljac>? Dobavljaci { get; set; }
      public ICollection<Cenovnik>? Cenovnici { get; set; }
   }
}