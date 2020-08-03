using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_NMK
{
    public class Pregled
    {
        string jmbg;
        string terapija;
        string misljenjeDoktora;

        public Pregled(string jmbg, string terapija, string misljenjeDoktora)
        {
            Jmbg = jmbg;
            Terapija = terapija;
            MisljenjeDoktora = misljenjeDoktora;
        }

        public string Jmbg { get => jmbg; set => jmbg = value; }
        public string Terapija { get => terapija; set => terapija = value; }
        public string MisljenjeDoktora { get => misljenjeDoktora; set => misljenjeDoktora = value; }
    }
}
