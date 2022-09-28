using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Pausal.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Reflection.Emit;

namespace Pausal.DAL
{
   public class ApplicationDbContext : DbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options)
      {
      }

      public DbSet<Delatnost> Delatnosti { get; set; }
      public DbSet<PoslovnaGodina> PoslovneGodine { get; set; }
      public DbSet<Adresa> Adresa { get; set; }
      public DbSet<Doprinosi> Doprinosi { get; set; }
      public DbSet<KPOKnjiga> KPOKnjige { get; set; }
      public DbSet<Racun> Racuni { get; set; }
      public DbSet<Nalog> Nalozi { get; set; }
      public DbSet<Kupac> Kupci { get; set; }
      public DbSet<RobaUsluga> RobeUsluge { get; set; }
      public DbSet<StavkaCenovnika> StavkeCenovnika { get; set; }
      public DbSet<Cenovnik> Cenovnici { get; set; }
      public DbSet<Dobavljac> Dobavljaci { get; set; }
      public DbSet<Preduzece> Preduzeca { get; set; }
      public DbSet<StavkaFakture> StavkeFakture { get; set; }
      public DbSet<Faktura> Faktura { get; set; }
      public DbSet<Korisnik> Korisnici { get; set; }



      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Preduzece>(ConfigurePreduzece);
      }



      private void ConfigurePreduzece(EntityTypeBuilder<Preduzece> builder)
      {
         builder.HasMany(p => p.Korisnici).WithOne(k => k.Preduzece);
         builder.HasMany(p => p.Fakture).WithOne(f => f.Preduzece);
         
      }
   }
}
