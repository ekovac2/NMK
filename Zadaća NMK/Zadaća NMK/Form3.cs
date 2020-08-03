using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaća_NMK
{
    public partial class Doktori_forma : Form
    {
        Doktor d;


        public Doktor D { get => d; set => d = value; }
        public Doktori_forma(Doktor d)
        {
            
            InitializeComponent();
            D = d;
        }

        

        private void Doktori_forma_Load(object sender, EventArgs e)
        {

        }
    }
}
