using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaća_NMK
{
    public class Karton
    {
        Pacijent pacijent;
        string alergija;
        string prijasnjebolesti;
        string sadasnjebolesti;
        string bolestiUporodici;
        string zakljucakDoktora;

        public Karton(Pacijent p, string alergija, string prijasnjebolesti, string sadasnjebolesti, string bolestiUporodici, string zakljucakDoktora)
        {
            this.Pacijent = p;
            this.Alergija = alergija;
            this.Prijasnjebolesti = prijasnjebolesti;
            this.Sadasnjebolesti = sadasnjebolesti;
            this.BolestiUporodici = bolestiUporodici;
            this.ZakljucakDoktora = zakljucakDoktora;
        }

        public string Alergija { get => alergija; set => alergija = value; }
        public string Prijasnjebolesti { get => prijasnjebolesti; set => prijasnjebolesti = value; }
        public string Sadasnjebolesti { get => sadasnjebolesti; set => sadasnjebolesti = value; }
        public string BolestiUporodici { get => bolestiUporodici; set => bolestiUporodici = value; }
        public string ZakljucakDoktora { get => zakljucakDoktora; set => zakljucakDoktora = value; }
        internal Pacijent Pacijent { get => pacijent; set => pacijent = value; }
    }
}
