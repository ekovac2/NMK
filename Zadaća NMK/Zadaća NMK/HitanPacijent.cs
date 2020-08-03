using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Zadaća_NMK
{
    public class HitanPacijent: Pacijent
    {
        string prvaPomoc;

        public HitanPacijent(string prvaPomoc, string ime, string prezime, string JMBG, DateTime datumRodjenja, int spol, string adresaStanovanja, int bracnoStanje, DateTime datumPrijema, string korisnickoIme, string password, Image slika) : base(ime, prezime, JMBG, datumRodjenja, spol, adresaStanovanja, bracnoStanje, datumPrijema, korisnickoIme, password, slika)
        {
            this.PrvaPomoc = prvaPomoc;
        }

        public string PrvaPomoc { get => prvaPomoc; set => prvaPomoc = value; }
    }
}
