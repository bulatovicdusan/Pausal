﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pausal.DAL;

#nullable disable

namespace Pausal.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pausal.DAL.Model.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Currency")
                        .HasColumnType("int");

                    b.Property<int?>("EntrepreneurId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Number")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EntrepreneurId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("Pausal.DAL.Model.AccountTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("TransactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TransactionId");

                    b.HasIndex(new[] { "AccountId", "TransactionId" }, "UniqueAccount_Transaction")
                        .IsUnique();

                    b.ToTable("AccountTransaction");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Activity");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Postcode")
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int?>("EntrepreneurId")
                        .HasColumnType("int");

                    b.Property<int>("IdentificationNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PIB")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("AddressId");

                    b.HasIndex("EntrepreneurId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Entrepreneur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<int>("IdentificationNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("PIB")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<int?>("PrimaryActivityId")
                        .HasColumnType("int");

                    b.Property<int?>("SecondaryActivityId")
                        .HasColumnType("int");

                    b.Property<int?>("TaxId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("PrimaryActivityId");

                    b.HasIndex("SecondaryActivityId");

                    b.HasIndex("TaxId");

                    b.HasIndex("UserId");

                    b.ToTable("Entrepreneur");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ActivityId")
                        .HasColumnType("int");

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("EntrepreneurId")
                        .HasColumnType("int");

                    b.Property<string>("InvoiceNumber")
                        .HasColumnType("longtext");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ClientId");

                    b.HasIndex("EntrepreneurId");

                    b.HasIndex("PaymentId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("Pausal.DAL.Model.InvoiceItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Rebate")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("UnitOfMeasure")
                        .HasColumnType("longtext");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.ToTable("InvoiceItem");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("EntrepreneurId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalRevenue")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("EntrepreneurId");

                    b.ToTable("KPOBook");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOBookItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int?>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int?>("KPOBookId")
                        .HasColumnType("int");

                    b.Property<decimal>("SalesRevenue")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("ServiceRevenue")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("TotalRevenue")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("KPOBookId");

                    b.ToTable("KPOBookItem");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Advance")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Date")
                        .HasColumnType("longtext");

                    b.Property<string>("Method")
                        .HasColumnType("longtext");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Tax", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("HealthCare")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("IncomeTax")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PIO")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Unemployment")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Tax");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("Entry")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Pausal.DAL.Model.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Lastname")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Account", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Entrepreneur", null)
                        .WithMany("Accounts")
                        .HasForeignKey("EntrepreneurId");
                });

            modelBuilder.Entity("Pausal.DAL.Model.AccountTransaction", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Account", "Account")
                        .WithMany("AccountTransactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pausal.DAL.Model.Transaction", "Transaction")
                        .WithMany("AccountTransactions")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Client", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("Pausal.DAL.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Pausal.DAL.Model.Entrepreneur", null)
                        .WithMany("Clients")
                        .HasForeignKey("EntrepreneurId");

                    b.Navigation("Account");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Entrepreneur", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("Pausal.DAL.Model.Activity", "PrimaryActivity")
                        .WithMany()
                        .HasForeignKey("PrimaryActivityId");

                    b.HasOne("Pausal.DAL.Model.Activity", "SecondaryActivity")
                        .WithMany()
                        .HasForeignKey("SecondaryActivityId");

                    b.HasOne("Pausal.DAL.Model.Tax", "Tax")
                        .WithMany()
                        .HasForeignKey("TaxId");

                    b.HasOne("Pausal.DAL.Model.User", null)
                        .WithMany("Entrepreneur")
                        .HasForeignKey("UserId");

                    b.Navigation("Address");

                    b.Navigation("PrimaryActivity");

                    b.Navigation("SecondaryActivity");

                    b.Navigation("Tax");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Invoice", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId");

                    b.HasOne("Pausal.DAL.Model.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.HasOne("Pausal.DAL.Model.Entrepreneur", "Entrepreneur")
                        .WithMany()
                        .HasForeignKey("EntrepreneurId");

                    b.HasOne("Pausal.DAL.Model.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId");

                    b.Navigation("Activity");

                    b.Navigation("Client");

                    b.Navigation("Entrepreneur");

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Pausal.DAL.Model.InvoiceItem", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Invoice", null)
                        .WithMany("InvoiceItems")
                        .HasForeignKey("InvoiceId");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOBook", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Entrepreneur", "Entrepreneur")
                        .WithMany()
                        .HasForeignKey("EntrepreneurId");

                    b.Navigation("Entrepreneur");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOBookItem", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Invoice", "Invoice")
                        .WithMany()
                        .HasForeignKey("InvoiceId");

                    b.HasOne("Pausal.DAL.Model.KPOBook", null)
                        .WithMany("KPOBookItems")
                        .HasForeignKey("KPOBookId");

                    b.Navigation("Invoice");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Account", b =>
                {
                    b.Navigation("AccountTransactions");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Entrepreneur", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Clients");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Invoice", b =>
                {
                    b.Navigation("InvoiceItems");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOBook", b =>
                {
                    b.Navigation("KPOBookItems");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Transaction", b =>
                {
                    b.Navigation("AccountTransactions");
                });

            modelBuilder.Entity("Pausal.DAL.Model.User", b =>
                {
                    b.Navigation("Entrepreneur");
                });
#pragma warning restore 612, 618
        }
    }
}
