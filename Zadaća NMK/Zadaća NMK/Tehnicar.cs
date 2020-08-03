using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_NMK
{
    public class Tehnicar : Osoba
    {
        int brojSatiRada;
        public Tehnicar(string ime, string prezime, string maticniBroj, DateTime datumRodjenja, int spol, string korisnickoIme, string Lozika, int brojSati) : base(ime, prezime, maticniBroj, datumRodjenja, spol, korisnickoIme, Lozika)
        {
            BrojSatiRada = brojSati;
        }

        public int BrojSatiRada { get => brojSatiRada; set => brojSatiRada = value; }
    }
}
