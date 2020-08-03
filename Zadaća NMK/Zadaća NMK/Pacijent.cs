using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaća_NMK
{
    public class Pacijent: Osoba
    {
        string adresaStanovanja;
        int bracnoStanje;
        DateTime datumPrijema;
        int broj_posjeta;
        int broj_ordinacija;
        Image slika;

        public Pacijent(string ime, string prezime, string maticniBroj, DateTime datumRodjenja, int spol, string adresaStanovanja, int bracnoStanje, DateTime datumPrijema,string korisnickoIme, string passoword, Image slika) : base(ime, prezime, maticniBroj, datumRodjenja, spol, korisnickoIme,passoword)
        {
            this.AdresaStanovanja = adresaStanovanja;
            this.BracnoStanje = bracnoStanje;
            this.DatumPrijema = datumPrijema;
            this.Broj_posjeta = 1;
            this.Broj_ordinacija = 0;
            this.Slika = slika;
        }

        public string AdresaStanovanja { get => adresaStanovanja; set => adresaStanovanja = value; }
        public int BracnoStanje { get => bracnoStanje; set => bracnoStanje = value; }
        public DateTime DatumPrijema { get => datumPrijema; set => datumPrijema = value; }
        public int Broj_posjeta { get => broj_posjeta; set => broj_posjeta = value; }
        public int Broj_ordinacija { get => broj_ordinacija; set => broj_ordinacija = value; }
        public Image Slika { get => slika; set => slika = value; }

        public int obracun()
        {
            int racun = 0;
            racun = 100;
            return racun;
        }
    }
}
