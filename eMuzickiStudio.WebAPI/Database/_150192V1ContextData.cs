using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eMuzickiStudio.WebAPI.Database
{
    public partial class _150192V1Context
    {
        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            //gradovi
            WebAPI.Database.Grad grad1 = new WebAPI.Database.Grad()
            {
                GradId = 1,
                Naziv = "Trebinje"
            };
            modelBuilder.Entity<Grad>().HasData(grad1);

            WebAPI.Database.Grad grad2 = new WebAPI.Database.Grad()
            {
                GradId = 2,
                Naziv = "Mostar"
            };
            modelBuilder.Entity<Grad>().HasData(grad2);

            WebAPI.Database.Grad grad3 = new WebAPI.Database.Grad()
            {
                GradId = 3,
                Naziv = "Sarajevo"
            };
            modelBuilder.Entity<Grad>().HasData(grad3);

            //vrste muzickih instrumenata
            WebAPI.Database.Vrsta vrsta1 = new WebAPI.Database.Vrsta()
            {
                VrstaId = 1,
                Naziv = "Duvacki instrumenti"
            };
            modelBuilder.Entity<Vrsta>().HasData(vrsta1);

            WebAPI.Database.Vrsta vrsta2 = new WebAPI.Database.Vrsta()
            {
                VrstaId = 2,
                Naziv = "Zicani instrumenti"
            };
            modelBuilder.Entity<Vrsta>().HasData(vrsta2);

            WebAPI.Database.Vrsta vrsta3 = new WebAPI.Database.Vrsta()
            {
                VrstaId = 3,
                Naziv = "Udaracki instrumenti"
            };
            modelBuilder.Entity<Vrsta>().HasData(vrsta3);

            WebAPI.Database.Vrsta vrsta4 = new WebAPI.Database.Vrsta()
            {
                VrstaId = 4,
                Naziv = "Elektronski instrumenti"
            };
            modelBuilder.Entity<Vrsta>().HasData(vrsta4);

            WebAPI.Database.Vrsta vrsta5 = new WebAPI.Database.Vrsta()
            {
                VrstaId = 5,
                Naziv = "Instrumenti sa tipkama"
            };
            modelBuilder.Entity<Vrsta>().HasData(vrsta5);

            WebAPI.Database.Vrsta vrsta6 = new WebAPI.Database.Vrsta()
            {
                VrstaId = 6,
                Naziv = "Miksete"
            };
            modelBuilder.Entity<Vrsta>().HasData(vrsta6);

            WebAPI.Database.Vrsta vrsta7 = new WebAPI.Database.Vrsta()
            {
                VrstaId = 7,
                Naziv = "Mikrofoni"
            };
            modelBuilder.Entity<Vrsta>().HasData(vrsta7);

            //muzicki instrumenti

            WebAPI.Database.MuzickaOprema muzickaOprema1 = new WebAPI.Database.MuzickaOprema()
            {
                MuzickaOpremaId = 1,
                Naziv = "Bubanj",
                VrstaId = 3,
                NaStanju = 40,
                Slika = File.ReadAllBytes("img/muzickiInstrument1.jpg"),
                Cijena = 200
            };
            modelBuilder.Entity<MuzickaOprema>().HasData(muzickaOprema1);


            WebAPI.Database.MuzickaOprema muzickaOprema2 = new WebAPI.Database.MuzickaOprema()
            {
                MuzickaOpremaId = 2,
                Naziv = "Elektricna gitara",
                VrstaId = 2,
                NaStanju = 40,
                Slika = File.ReadAllBytes("img/muzickiInstrument2.jpg"),
                Cijena = 250
            };
            modelBuilder.Entity<MuzickaOprema>().HasData(muzickaOprema2);


            WebAPI.Database.MuzickaOprema muzickaOprema3 = new WebAPI.Database.MuzickaOprema()
            {
                MuzickaOpremaId = 3,
                Naziv = "Klavijatura",
                VrstaId = 5,
                NaStanju = 40,
                Slika = File.ReadAllBytes("img/muzickiInstrument3.jpg"),
                Cijena = 250
            };
            modelBuilder.Entity<MuzickaOprema>().HasData(muzickaOprema3);


            WebAPI.Database.MuzickaOprema muzickaOprema4 = new WebAPI.Database.MuzickaOprema()
            {
                MuzickaOpremaId = 4,
                Naziv = "Mikseta",
                VrstaId = 6,
                NaStanju = 40,
                Slika = File.ReadAllBytes("img/muzickiInstrument4.jpg"),
                Cijena = 250
            };
            modelBuilder.Entity<MuzickaOprema>().HasData(muzickaOprema4);


            WebAPI.Database.MuzickaOprema muzickaOprema5 = new WebAPI.Database.MuzickaOprema()
            {
                MuzickaOpremaId = 5,
                Naziv = "Mikrofon",
                VrstaId = 7,
                NaStanju = 40,
                Slika = File.ReadAllBytes("img/muzickiInstrument5.jpg"),
                Cijena = 150
            };
            modelBuilder.Entity<MuzickaOprema>().HasData(muzickaOprema5);


            WebAPI.Database.MuzickaOprema muzickaOprema6 = new WebAPI.Database.MuzickaOprema()
            {
                MuzickaOpremaId = 6,
                Naziv = "Violina",
                VrstaId = 2,
                NaStanju = 40,
                Slika = File.ReadAllBytes("img/muzickiInstrument6.jpg"),
                Cijena = 180
            };
            modelBuilder.Entity<MuzickaOprema>().HasData(muzickaOprema6);


            WebAPI.Database.MuzickaOprema muzickaOprema7 = new WebAPI.Database.MuzickaOprema()
            {
                MuzickaOpremaId = 7,
                Naziv = "Truba",
                VrstaId = 1,
                NaStanju = 40,
                Slika = File.ReadAllBytes("img/muzickiInstrument7.jpg"),
                Cijena = 250
            };
            modelBuilder.Entity<MuzickaOprema>().HasData(muzickaOprema7);

            //uloge

            WebAPI.Database.Uloge uloga1 = new WebAPI.Database.Uloge()
            {
                UlogaId = 1,
                Naziv = "Administrator",
                Opis = "Dodavanje korisnika i sve opcije kao radnik. "
            };
            modelBuilder.Entity<Uloge>().HasData(uloga1);

            WebAPI.Database.Uloge uloga2 = new WebAPI.Database.Uloge()
            {
                UlogaId = 2,
                Naziv = "Radnik",
                Opis = "Pregled klijenata, rezervacija, dodavanje muzickih instrumenata, povecavanje kolicine na stanju, dodavanje slobodnih termina"
            };
            modelBuilder.Entity<Uloge>().HasData(uloga2);

            //korisnici

            WebAPI.Database.Korisnici korisnik1 = new WebAPI.Database.Korisnici()
            {
                KorisnikId = 1,
                Ime = "Admin",
                Prezime = "Adminovic",
                Email = "admin@hotmail.com",
                Telefon = "065777888",
                KorisnickoIme = "admin",
                UlogaId = 1
            };
            korisnik1.LozinkaSalt = GenerateSalt();
            korisnik1.LozinkaHash = GenerateHash(korisnik1.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnici>().HasData(korisnik1);

            WebAPI.Database.Korisnici korisnik2 = new WebAPI.Database.Korisnici()
            {
                KorisnikId = 2,
                Ime = "Radnik",
                Prezime = "Radnikovic",
                Email = "radnik@hotmail.com",
                Telefon = "066555888",
                KorisnickoIme = "radnik",
                UlogaId = 2
            };
            korisnik2.LozinkaSalt = GenerateSalt();
            korisnik2.LozinkaHash = GenerateHash(korisnik2.LozinkaSalt, "test");
            modelBuilder.Entity<Korisnici>().HasData(korisnik2);

            //klijenti

            WebAPI.Database.Klijenti klijent1 = new WebAPI.Database.Klijenti()
            {
                KlijentId = 1,
                Ime = "Marko",
                Prezime = "Markovic",
                Email = "marko@hotmail.com",
                Telefon = "065888777",
                KorisnickoIme = "mobile",
                Banovan=false,
                GradId = 1,
                Slika = File.ReadAllBytes("img/klijent1.jpg")
            };
            klijent1.LozinkaSalt = GenerateSalt();
            klijent1.LozinkaHash = GenerateHash(klijent1.LozinkaSalt, "test");
            modelBuilder.Entity<Klijenti>().HasData(klijent1);

            WebAPI.Database.Klijenti klijent2 = new WebAPI.Database.Klijenti()
            {
                KlijentId = 2,
                Ime = "Mirko",
                Prezime = "Mirkovic",
                Email = "mirko@hotmail.com",
                Telefon = "065222777",
                KorisnickoIme = "mobile1",
                Banovan=false,
                GradId = 2,
                Slika = File.ReadAllBytes("img/klijent2.jpg")
            };
            klijent2.LozinkaSalt = GenerateSalt();
            klijent2.LozinkaHash = GenerateHash(klijent2.LozinkaSalt, "test");
            modelBuilder.Entity<Klijenti>().HasData(klijent2);

            WebAPI.Database.Klijenti klijent3 = new WebAPI.Database.Klijenti()
            {
                KlijentId = 3,
                Ime = "Matija",
                Prezime = "Matkovic",
                Email = "matija@hotmail.com",
                Telefon = "065238777",
                KorisnickoIme = "mobile2",
                Banovan=true,
                GradId = 3,
                Slika = File.ReadAllBytes("img/klijent3.jpg")
            };
            klijent3.LozinkaSalt = GenerateSalt();
            klijent3.LozinkaHash = GenerateHash(klijent3.LozinkaSalt, "test");
            modelBuilder.Entity<Klijenti>().HasData(klijent3);

            //ocjene

            WebAPI.Database.Ocjene ocjena1 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 1,
                Datum = new DateTime(2021, 10, 10),
                Ocjena = 5,
                KlijentId = 1,
                MuzickaOpremaId = 1
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena1);

            WebAPI.Database.Ocjene ocjena2 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 2,
                Datum = new DateTime(2021, 11, 11),
                Ocjena = 4,
                KlijentId = 1,
                MuzickaOpremaId = 2
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena2);

            WebAPI.Database.Ocjene ocjena3 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 3,
                Datum = new DateTime(2021, 10, 11),
                Ocjena = 2,
                KlijentId = 1,
                MuzickaOpremaId = 3
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena3);

            WebAPI.Database.Ocjene ocjena4 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 4,
                Datum = new DateTime(2021, 11, 10),
                Ocjena = 4,
                KlijentId = 1,
                MuzickaOpremaId = 4
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena4);

            WebAPI.Database.Ocjene ocjena5 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 5,
                Datum = new DateTime(2021, 9, 10),
                Ocjena = 5,
                KlijentId = 1,
                MuzickaOpremaId = 5
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena5);

            WebAPI.Database.Ocjene ocjena6 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 6,
                Datum = new DateTime(2021, 10, 10),
                Ocjena = 5,
                KlijentId = 2,
                MuzickaOpremaId = 1
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena6);

            WebAPI.Database.Ocjene ocjena7 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 7,
                Datum = new DateTime(2021, 9, 10),
                Ocjena = 4,
                KlijentId = 2,
                MuzickaOpremaId = 2
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena7);

            WebAPI.Database.Ocjene ocjena8 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 8,
                Datum = new DateTime(2021, 10, 10),
                Ocjena = 5,
                KlijentId = 2,
                MuzickaOpremaId = 3
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena8);

            WebAPI.Database.Ocjene ocjena9 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 9,
                Datum = new DateTime(2021, 10, 10),
                Ocjena = 5,
                KlijentId = 3,
                MuzickaOpremaId = 1
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena9);

            WebAPI.Database.Ocjene ocjena10 = new WebAPI.Database.Ocjene()
            {
                OcjenaId = 10,
                Datum = new DateTime(2021, 10, 10),
                Ocjena = 5,
                KlijentId = 3,
                MuzickaOpremaId = 2
            };
            modelBuilder.Entity<Ocjene>().HasData(ocjena10);

            //termini

            WebAPI.Database.Termini termin1 = new WebAPI.Database.Termini()
            {
                TerminId = 1,
                Datum = new DateTime(2021, 10, 10),
                KorisnikId = 1,
                Aktivan = true,
                VrijemeOd = new TimeSpan(14, 00, 00),
                VrijemeDo = new TimeSpan(15, 00, 00)
            };
            modelBuilder.Entity<Termini>().HasData(termin1);

            WebAPI.Database.Termini termin2 = new WebAPI.Database.Termini()
            {
                TerminId = 2,
                Datum = new DateTime(2021, 10, 10),
                KorisnikId = 1,
                Aktivan = true,
                VrijemeOd = new TimeSpan(11, 00, 00),
                VrijemeDo = new TimeSpan(15, 00, 00)
            };
            modelBuilder.Entity<Termini>().HasData(termin2);

            WebAPI.Database.Termini termin3 = new WebAPI.Database.Termini()
            {
                TerminId = 3,
                Datum = new DateTime(2021, 10, 10),
                KorisnikId = 1,
                Aktivan = true,
                VrijemeOd = new TimeSpan(12, 00, 00),
                VrijemeDo = new TimeSpan(14, 00, 00)
            };
            modelBuilder.Entity<Termini>().HasData(termin3);

            WebAPI.Database.Termini termin4 = new WebAPI.Database.Termini()
            {
                TerminId = 4,
                Datum = new DateTime(2021, 9, 10),
                KorisnikId = 2,
                Aktivan = true,
                VrijemeOd = new TimeSpan(14, 00, 00),
                VrijemeDo = new TimeSpan(15, 00, 00)
            };
            modelBuilder.Entity<Termini>().HasData(termin4);

            //rezervacije gluve sobe

            WebAPI.Database.RezervacijeGluveSobe rezervacijaGluveSobe1 = new WebAPI.Database.RezervacijeGluveSobe()
            {
                RezervacijeGluveSobeId = 1,
                Datum = new DateTime(2021, 10, 10),
                KlijentId = 1,
                VrijemeOd = new TimeSpan(14, 00, 00),
                VrijemeDo = new TimeSpan(15, 00, 00)
            };
            modelBuilder.Entity<RezervacijeGluveSobe>().HasData(rezervacijaGluveSobe1);

            WebAPI.Database.RezervacijeGluveSobe rezervacijaGluveSobe2 = new WebAPI.Database.RezervacijeGluveSobe()
            {
                RezervacijeGluveSobeId = 2,
                Datum = new DateTime(2021, 9, 10),
                KlijentId = 1,
                VrijemeOd = new TimeSpan(14, 00, 00),
                VrijemeDo = new TimeSpan(15, 00, 00)
            };
            modelBuilder.Entity<RezervacijeGluveSobe>().HasData(rezervacijaGluveSobe2);

            WebAPI.Database.RezervacijeGluveSobe rezervacijaGluveSobe3 = new WebAPI.Database.RezervacijeGluveSobe()
            {
                RezervacijeGluveSobeId = 3,
                Datum = new DateTime(2021, 10, 10),
                KlijentId = 2,
                VrijemeOd = new TimeSpan(14, 00, 00),
                VrijemeDo = new TimeSpan(15, 00, 00)
            };
            modelBuilder.Entity<RezervacijeGluveSobe>().HasData(rezervacijaGluveSobe3);

            //rezervacije

            WebAPI.Database.Rezervacije rezervacija1 = new WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 1,
                BrojRezervacije = 1,
                Datum = new DateTime(2021, 10, 10),
                Otkazano = false,
                KlijentId = 1,
                KorisnikId = 1,
                Status = true,
                Cijena = 400,
                DatumRezervacije = new DateTime(2021, 11, 10),
                Arhivirana = false
            };
            modelBuilder.Entity<Rezervacije>().HasData(rezervacija1);

            WebAPI.Database.Rezervacije rezervacija2 = new WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 2,
                BrojRezervacije = 2,
                Datum = new DateTime(2021, 10, 10),
                Otkazano = false,
                KlijentId = 1,
                KorisnikId = 1,
                Status = true,
                Cijena = 500,
                DatumRezervacije = new DateTime(2021, 10, 11),
                Arhivirana=false
            };
            modelBuilder.Entity<Rezervacije>().HasData(rezervacija2);

            WebAPI.Database.Rezervacije rezervacija3 = new WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 3,
                BrojRezervacije = 3,
                Datum = new DateTime(2021, 10, 10),
                Otkazano = false,
                KlijentId = 1,
                KorisnikId = 1,
                Status = true,
                Cijena = 200,
                DatumRezervacije = new DateTime(2021, 11, 11),
                Arhivirana=false
            };
            modelBuilder.Entity<Rezervacije>().HasData(rezervacija3);

            WebAPI.Database.Rezervacije rezervacija4 = new WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 4,
                BrojRezervacije = 4,
                Datum = new DateTime(2021, 10, 10),
                Otkazano = false,
                KlijentId = 1,
                KorisnikId = 1,
                Status = false,
                Cijena = 400,
                DatumRezervacije = new DateTime(2021, 11, 13),
                Arhivirana = false
            };
            modelBuilder.Entity<Rezervacije>().HasData(rezervacija4);

            WebAPI.Database.Rezervacije rezervacija5 = new WebAPI.Database.Rezervacije()
            {
                RezervacijaId = 5,
                BrojRezervacije = 5,
                Datum = new DateTime(2021, 10, 10),
                Otkazano = false,
                KlijentId = 1,
                KorisnikId = 1,
                Status = true,
                Cijena = 450,
                DatumRezervacije = new DateTime(2021, 11, 17),
                Arhivirana=false
            };
            modelBuilder.Entity<Rezervacije>().HasData(rezervacija5);

            //rezervacijaStavke

            WebAPI.Database.RezervacijaStavke rezervacijaStavke1 = new WebAPI.Database.RezervacijaStavke()
            {
                RezervacijaStavkaId = 1,
                RezervacijaId = 1,
                MuzickaOpremaId = 1,
                Kolicina = 2
            };
            modelBuilder.Entity<RezervacijaStavke>().HasData(rezervacijaStavke1);

            WebAPI.Database.RezervacijaStavke rezervacijaStavke2 = new WebAPI.Database.RezervacijaStavke()
            {
                RezervacijaStavkaId = 2,
                RezervacijaId = 1,
                MuzickaOpremaId = 2,
                Kolicina = 1
            };
            modelBuilder.Entity<RezervacijaStavke>().HasData(rezervacijaStavke2);

            WebAPI.Database.RezervacijaStavke rezervacijaStavke3 = new WebAPI.Database.RezervacijaStavke()
            {
                RezervacijaStavkaId = 3,
                RezervacijaId = 1,
                MuzickaOpremaId = 3,
                Kolicina = 1
            };
            modelBuilder.Entity<RezervacijaStavke>().HasData(rezervacijaStavke3);

            WebAPI.Database.RezervacijaStavke rezervacijaStavke4 = new WebAPI.Database.RezervacijaStavke()
            {
                RezervacijaStavkaId = 4,
                RezervacijaId = 2,
                MuzickaOpremaId = 1,
                Kolicina = 2
            };
            modelBuilder.Entity<RezervacijaStavke>().HasData(rezervacijaStavke4);

            WebAPI.Database.RezervacijaStavke rezervacijaStavke5 = new WebAPI.Database.RezervacijaStavke()
            {
                RezervacijaStavkaId = 5,
                RezervacijaId = 3,
                MuzickaOpremaId = 4,
                Kolicina = 2
            };
            modelBuilder.Entity<RezervacijaStavke>().HasData(rezervacijaStavke5);

            WebAPI.Database.RezervacijaStavke rezervacijaStavke6 = new WebAPI.Database.RezervacijaStavke()
            {
                RezervacijaStavkaId = 6,
                RezervacijaId = 4,
                MuzickaOpremaId = 5,
                Kolicina = 1
            };
            modelBuilder.Entity<RezervacijaStavke>().HasData(rezervacijaStavke6);

            WebAPI.Database.RezervacijaStavke rezervacijaStavke7 = new WebAPI.Database.RezervacijaStavke()
            {
                RezervacijaStavkaId = 7,
                RezervacijaId = 5,
                MuzickaOpremaId = 1,
                Kolicina = 3
            };
            modelBuilder.Entity<RezervacijaStavke>().HasData(rezervacijaStavke7);
        }
    }
}
