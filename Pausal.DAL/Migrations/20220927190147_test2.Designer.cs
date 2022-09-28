﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pausal.DAL;

#nullable disable

namespace Pausal.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220927190147_test2")]
    partial class test2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pausal.DAL.Model.Adresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Grad")
                        .HasColumnType("longtext");

                    b.Property<string>("PostanskiBroj")
                        .HasColumnType("longtext");

                    b.Property<string>("Ulica")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Adresa");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Cenovnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly>("DatumVazenja")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.ToTable("Cenovnik");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Delatnost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.Property<bool>("Primarna")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Sifra")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("Delatnost");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Dobavljac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdresaId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("MIB")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<int>("PIB")
                        .HasColumnType("int");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("Dobavljac");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Doprinosi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Nezaposlenost")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PIO")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("PorezNaDobit")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("PoslovnaGodinaId")
                        .HasColumnType("int");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Zdravstveno")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("PoslovnaGodinaId");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("Doprinosi");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Faktura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BrojFakture")
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("DatumIzdavanja")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DatumValute")
                        .HasColumnType("date");

                    b.Property<int?>("KPOKnjigaId")
                        .HasColumnType("int");

                    b.Property<int?>("KupacId")
                        .HasColumnType("int");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.Property<decimal>("UkupanIznos")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("UkupanPDV")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("UkupanRabat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("UkupnaOsnovica")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("KPOKnjigaId");

                    b.HasIndex("KupacId");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("Faktura");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("Ime")
                        .HasColumnType("longtext");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("longtext");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("longtext");

                    b.Property<string>("Sifra")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOKnjiga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("PoslovnaGodinaId")
                        .HasColumnType("int");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.Property<decimal>("Ukupno")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("PoslovnaGodinaId");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("KPOKnjiga");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Kupac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdresaId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<int>("MIB")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<int>("PIB")
                        .HasColumnType("int");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Nalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateOnly?>("Datum")
                        .HasColumnType("date");

                    b.Property<string>("Duznik")
                        .HasColumnType("longtext");

                    b.Property<decimal?>("Iznos")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Poverilac")
                        .HasColumnType("longtext");

                    b.Property<string>("PozivNaBroj")
                        .HasColumnType("longtext");

                    b.Property<int?>("RacunPrimaocaId")
                        .HasColumnType("int");

                    b.Property<int?>("RacunUplatiocaId")
                        .HasColumnType("int");

                    b.Property<int>("SifraPlacanja")
                        .HasColumnType("int");

                    b.Property<string>("SvrhaPlacanja")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("RacunPrimaocaId");

                    b.HasIndex("RacunUplatiocaId");

                    b.ToTable("Nalog");
                });

            modelBuilder.Entity("Pausal.DAL.Model.PoslovnaGodina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Godina")
                        .HasColumnType("int");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.Property<bool>("Zakljucena")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("PoslovnaGodina");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Preduzece", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AdresaId")
                        .HasColumnType("int");

                    b.Property<int>("MIB")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<int>("PIB")
                        .HasColumnType("int");

                    b.Property<string>("Telefon")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("AdresaId");

                    b.ToTable("Preduzece");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Racun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Aktivan")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("BrojRacuna")
                        .HasColumnType("longtext");

                    b.Property<int?>("DobavljacId")
                        .HasColumnType("int");

                    b.Property<int?>("KupacId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.Property<int?>("PreduzeceId")
                        .HasColumnType("int");

                    b.Property<int>("Valuta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DobavljacId");

                    b.HasIndex("KupacId");

                    b.HasIndex("PreduzeceId");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("Pausal.DAL.Model.RobaUsluga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("RobaUsluga");
                });

            modelBuilder.Entity("Pausal.DAL.Model.StavkaCenovnika", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Cena")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("CenovnikId")
                        .HasColumnType("int");

                    b.Property<int?>("RobaUslugaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CenovnikId");

                    b.HasIndex("RobaUslugaId");

                    b.ToTable("StavkaCenovnika");
                });

            modelBuilder.Entity("Pausal.DAL.Model.StavkaFakture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FakturaId")
                        .HasColumnType("int");

                    b.Property<decimal>("JedinicnaCena")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Kolicina")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Osnovica")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Rabat")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("RobaUslugaId")
                        .HasColumnType("int");

                    b.Property<decimal>("UkupnaCena")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("FakturaId");

                    b.HasIndex("RobaUslugaId");

                    b.ToTable("StavkaFakture");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Delatnost", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Preduzece", null)
                        .WithMany("Delatnosti")
                        .HasForeignKey("PreduzeceId");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Dobavljac", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaId");

                    b.HasOne("Pausal.DAL.Model.Preduzece", null)
                        .WithMany("Dobavljaci")
                        .HasForeignKey("PreduzeceId");

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Doprinosi", b =>
                {
                    b.HasOne("Pausal.DAL.Model.PoslovnaGodina", "PoslovnaGodina")
                        .WithMany()
                        .HasForeignKey("PoslovnaGodinaId");

                    b.HasOne("Pausal.DAL.Model.Preduzece", null)
                        .WithMany("Doprinosi")
                        .HasForeignKey("PreduzeceId");

                    b.Navigation("PoslovnaGodina");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Faktura", b =>
                {
                    b.HasOne("Pausal.DAL.Model.KPOKnjiga", null)
                        .WithMany("Fakture")
                        .HasForeignKey("KPOKnjigaId");

                    b.HasOne("Pausal.DAL.Model.Kupac", "Kupac")
                        .WithMany("Fakture")
                        .HasForeignKey("KupacId");

                    b.HasOne("Pausal.DAL.Model.Preduzece", "Preduzece")
                        .WithMany("Fakture")
                        .HasForeignKey("PreduzeceId");

                    b.Navigation("Kupac");

                    b.Navigation("Preduzece");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Korisnik", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Preduzece", "Preduzece")
                        .WithMany("Korisnici")
                        .HasForeignKey("PreduzeceId");

                    b.Navigation("Preduzece");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOKnjiga", b =>
                {
                    b.HasOne("Pausal.DAL.Model.PoslovnaGodina", "PoslovnaGodina")
                        .WithMany()
                        .HasForeignKey("PoslovnaGodinaId");

                    b.HasOne("Pausal.DAL.Model.Preduzece", "Preduzece")
                        .WithMany()
                        .HasForeignKey("PreduzeceId");

                    b.Navigation("PoslovnaGodina");

                    b.Navigation("Preduzece");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Kupac", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaId");

                    b.HasOne("Pausal.DAL.Model.Preduzece", null)
                        .WithMany("Kupci")
                        .HasForeignKey("PreduzeceId");

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Nalog", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Racun", "RacunPrimaoca")
                        .WithMany()
                        .HasForeignKey("RacunPrimaocaId");

                    b.HasOne("Pausal.DAL.Model.Racun", "RacunUplatioca")
                        .WithMany()
                        .HasForeignKey("RacunUplatiocaId");

                    b.Navigation("RacunPrimaoca");

                    b.Navigation("RacunUplatioca");
                });

            modelBuilder.Entity("Pausal.DAL.Model.PoslovnaGodina", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Preduzece", null)
                        .WithMany("PoslovneGodine")
                        .HasForeignKey("PreduzeceId");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Preduzece", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Adresa", "Adresa")
                        .WithMany()
                        .HasForeignKey("AdresaId");

                    b.Navigation("Adresa");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Racun", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Dobavljac", null)
                        .WithMany("Racuni")
                        .HasForeignKey("DobavljacId");

                    b.HasOne("Pausal.DAL.Model.Kupac", null)
                        .WithMany("Racuni")
                        .HasForeignKey("KupacId");

                    b.HasOne("Pausal.DAL.Model.Preduzece", null)
                        .WithMany("Racuni")
                        .HasForeignKey("PreduzeceId");
                });

            modelBuilder.Entity("Pausal.DAL.Model.StavkaCenovnika", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Cenovnik", null)
                        .WithMany("StavkeCenovnika")
                        .HasForeignKey("CenovnikId");

                    b.HasOne("Pausal.DAL.Model.RobaUsluga", "RobaUsluga")
                        .WithMany()
                        .HasForeignKey("RobaUslugaId");

                    b.Navigation("RobaUsluga");
                });

            modelBuilder.Entity("Pausal.DAL.Model.StavkaFakture", b =>
                {
                    b.HasOne("Pausal.DAL.Model.Faktura", null)
                        .WithMany("StavkeFakture")
                        .HasForeignKey("FakturaId");

                    b.HasOne("Pausal.DAL.Model.RobaUsluga", "RobaUsluga")
                        .WithMany()
                        .HasForeignKey("RobaUslugaId");

                    b.Navigation("RobaUsluga");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Cenovnik", b =>
                {
                    b.Navigation("StavkeCenovnika");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Dobavljac", b =>
                {
                    b.Navigation("Racuni");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Faktura", b =>
                {
                    b.Navigation("StavkeFakture");
                });

            modelBuilder.Entity("Pausal.DAL.Model.KPOKnjiga", b =>
                {
                    b.Navigation("Fakture");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Kupac", b =>
                {
                    b.Navigation("Fakture");

                    b.Navigation("Racuni");
                });

            modelBuilder.Entity("Pausal.DAL.Model.Preduzece", b =>
                {
                    b.Navigation("Delatnosti");

                    b.Navigation("Dobavljaci");

                    b.Navigation("Doprinosi");

                    b.Navigation("Fakture");

                    b.Navigation("Korisnici");

                    b.Navigation("Kupci");

                    b.Navigation("PoslovneGodine");

                    b.Navigation("Racuni");
                });
#pragma warning restore 612, 618
        }
    }
}
