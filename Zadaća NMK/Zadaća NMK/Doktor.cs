using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_NMK
{
    public class Doktor: Osoba
    {
        int broj_pregleda;
        int plata;

        public Doktor(string ime, string prezime, string maticniBroj, DateTime datumRodjenja, int spol, string korisnickoIme, string password) : base(ime, prezime, maticniBroj, datumRodjenja, spol, korisnickoIme,password)
        {
            this.Broj_pregleda = 0;
            this.Plata = 1000;
        }

        public int Broj_pregleda { get => broj_pregleda; set => broj_pregleda = value; }

        public int Plata { get => plata; set => plata = value; }

        public int obracun()
        {
            int ukupna_plata = 0;
            if (broj_pregleda > 20)
            {
                ukupna_plata = plata + 20 * 100;
            }
            else ukupna_plata = plata + broj_pregleda * 100;

            return ukupna_plata;
        }

    }
}
