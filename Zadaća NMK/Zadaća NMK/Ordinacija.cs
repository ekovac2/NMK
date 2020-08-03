using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_NMK
{
    public class Ordinacija
    {

        string ime;
        Doktor doktor;
        List<Pacijent> pacijenti = new List<Pacijent>();
        int broj_posjeta;

        public Ordinacija(string ime, Doktor doktor)
        {
            this.Ime = ime;
            this.Doktor = doktor;
            this.Broj_posjeta = 0;
        }

        public string Ime { get => ime; set => ime = value; }
        public int Broj_posjeta { get => broj_posjeta; set => broj_posjeta = value; }
        public Doktor Doktor { get => doktor; set => doktor = value; }
        public List<Pacijent> Pacijenti { get => pacijenti; set => pacijenti = value; }

        public void DodajPacijenta(Pacijent p)
        {
            pacijenti.Add(p);
            broj_posjeta++;
        }
    }
}
