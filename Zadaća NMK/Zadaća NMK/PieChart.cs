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
    public partial class PieChart : Form
    {
        Klinika k;
        public PieChart(ref Klinika kl)
        {
            k = kl;
            InitializeComponent();
        }

        private void PieChart_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics objekat;
            objekat = this.CreateGraphics();

           
            SolidBrush b = new SolidBrush(Color.Black);
            SolidBrush b1 = new SolidBrush(Color.Gray);
            SolidBrush b2 = new SolidBrush(Color.RosyBrown);

            Rectangle rt = new Rectangle(100, 50, 200, 200);
           
            //Nakon izračunatih granica za tri tehničara sa najviše sati rada dobijamo sljedeću statistiku: 

            objekat.FillPie(b1, rt,0,225);
            objekat.FillPie(b, rt, 0, -90);
            objekat.FillPie(b2, rt,-90, -70);

            Rectangle rect1 = new Rectangle(340, 50, 10, 10);
            Rectangle rect2 = new Rectangle(340, 70, 10, 10);
            Rectangle rect3 = new Rectangle(340, 90, 10, 10);

            e.Graphics.FillRectangle(b, rect1);
            e.Graphics.FillRectangle(b1, rect2);
            e.Graphics.FillRectangle(b2, rect3);
           

        }
    }
}
