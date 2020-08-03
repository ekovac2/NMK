using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_NMK
{
    public class Administrator : Osoba
    {
        public Administrator(string ime, string prezime, string maticniBroj, DateTime datumRodjenja, int spol, string korisnickoIme, string Lozika) : base(ime, prezime, maticniBroj, datumRodjenja, spol, korisnickoIme, Lozika)
        {
        }
    }
}
