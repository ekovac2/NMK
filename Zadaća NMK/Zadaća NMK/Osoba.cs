using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace Zadaća_NMK
{
    public abstract class Osoba
    {
        string ime;
        string prezime;
        string maticniBroj;
        DateTime datumRodjenja;
        int spol;
        string korisnickoIme;
        string password;

        public Osoba(string ime, string prezime, string maticniBroj, DateTime datumRodjenja, int spol,string korisnickoIme,string Lozika)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.MaticniBroj = maticniBroj;
            this.DatumRodjenja = datumRodjenja;
            this.Spol = spol;
            this.KorisnickoIme = korisnickoIme;
            this.Password = Lozika;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string MaticniBroj { get => maticniBroj; set => maticniBroj = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public int Spol { get => spol; set => spol = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Password { get => password; set => password = value; }
    }
}
