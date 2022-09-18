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

      public DbSet<Activity> Activities { get; set; }
      public DbSet<Address> Addresses { get; set; }
      public DbSet<Tax> Taxes { get; set; }
      public DbSet<KPOBookItem> KPOBookItems { get; set; }
      public DbSet<KPOBook> KPOBooks { get; set; }
      public DbSet<Account> Accounts { get; set; }
      public DbSet<Transaction> Transactions { get; set; }
      public DbSet<AccountTransaction> AccountTransactions { get; set; }
      public DbSet<Client> Clients { get; set; }
      public DbSet<Entrepreneur> Entrepreneurs { get; set; }
      public DbSet<InvoiceItem> InvoiceItems { get; set; }
      public DbSet<Invoice> Invoices { get; set; }
      public DbSet<User> Users { get; set; }


      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<AccountTransaction>(ConfigureAccountTransactions);
         modelBuilder.Entity<KPOBook>(ConfigureKPOBook);

      }

      private void ConfigureKPOBook(EntityTypeBuilder<KPOBook> builder)
      {
         builder.HasOne(b => b.KPOBookItems).WithMany();
      }

      private void ConfigureAccountTransactions(EntityTypeBuilder<AccountTransaction> builder)
      {
         builder
       .HasOne(pt => pt.Account)
       .WithMany(p => p.AccountTransactions)
       .HasForeignKey(pt => pt.AccountId);

         builder
             .HasOne(pt => pt.Transaction)
             .WithMany(t => t.AccountTransactions)
             .HasForeignKey(pt => pt.TransactionId);
         builder.HasIndex(x => new { x.AccountId, x.TransactionId }, "UniqueAccount_Transaction").IsUnique(true);
      }
   }
}
