using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Zadaća_NMK
{
    public class Umrli: HitanPacijent
    {
        DateTime vrijemeSmrti;
        string uzrokSmrti;
        DateTime vrijemeObdukcije;

        public Umrli(string prvaPomoc, string ime, string prezime, string JMBG, DateTime datumRodjenja, int spol, string adresaStanovanja, int bracnoStanje, DateTime datumPrijema, DateTime vrijemeSmrti, string uzrokSmrti, DateTime vrijemeObdukcije, string korisnickoIme, string password, Image slika) : base(prvaPomoc, ime, prezime, JMBG, datumRodjenja, spol, adresaStanovanja, bracnoStanje, datumPrijema, korisnickoIme,password, slika)
        {
            this.VrijemeSmrti = vrijemeSmrti;
            this.UzrokSmrti = uzrokSmrti;
            this.VrijemeObdukcije = vrijemeObdukcije;
        }

        public DateTime VrijemeSmrti { get => vrijemeSmrti; set => vrijemeSmrti = value; }
        public string UzrokSmrti { get => uzrokSmrti; set => uzrokSmrti = value; }
        public DateTime VrijemeObdukcije { get => vrijemeObdukcije; set => vrijemeObdukcije = value; }
    }
}
