using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;


namespace Zadaća_NMK
{
    public partial class Forma1 : Form
    {
        Klinika k = new Klinika();
        bool dozvoliPrelazak;
       

        public Klinika K { get => k; set => k = value; }
        public bool DozvoliPrelazak { get => dozvoliPrelazak; set => dozvoliPrelazak = value; }

        public Forma1()
        {
           
            DozvoliPrelazak = true;
            InitializeComponent();
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics objekat;
            objekat = this.CreateGraphics();

            Pen mojPen = new Pen(System.Drawing.Color.AliceBlue, 6);


            SolidBrush mojBrush = new SolidBrush(System.Drawing.Color.Red);

            objekat.DrawLine(mojPen, 280, 20, 280, 140);

            
           // objekat.DrawRectangle(mojPen, 140, 50, 110, 50);
           // objekat.DrawRectangle(mojPen, 170, 20, 50, 110);

            Rectangle rect1 = new Rectangle(172, 22, 48, 108);
            Rectangle rect2 = new Rectangle(143, 51, 106, 49);

            e.Graphics.FillRectangle(mojBrush, rect1);
            e.Graphics.FillRectangle(mojBrush, rect2);

            Point[] points1 = {
                new Point(171,20),
                new Point(170, 50)
            };
            Point[] points2 = {
                new Point(168,20),
                new Point(223, 20)
            };
            Point[] points3 = {
                new Point(220,20),
                new Point(220,50)
            };
            Point[] points4 = {
                new Point(140,50),
                new Point(174,50)
            };
            Point[] points5 = {
                new Point(217,50),
                new Point(252,50)
            };
            Point[] points6 = {
                new Point(142,47),
                new Point(142,103)
            };
            Point[] points7 = {
                new Point(250,47),
                new Point(250,103)
            };
            Point[] points8 = {
                new Point(220,103),
                new Point(253,103)
            };
            Point[] points9 = {
                new Point(139,103),
                new Point(173,103),
            };
            Point[] points10 = {
                new Point(170,103),
                new Point(170, 130)
            };
            Point[] points11 = {
                new Point(223,103),
                new Point(223, 130)
            };

            Point[] points12 = {
                new Point(167,133),
                new Point(226, 133)
            };

            objekat.DrawLines(mojPen,points1);
            objekat.DrawLines(mojPen, points2);
            objekat.DrawLines(mojPen, points3);
            objekat.DrawLines(mojPen, points4);
            objekat.DrawLines(mojPen, points5);
            objekat.DrawLines(mojPen, points6);
            objekat.DrawLines(mojPen, points7);
            objekat.DrawLines(mojPen, points8);
            objekat.DrawLines(mojPen, points9);
            objekat.DrawLines(mojPen, points10);
            objekat.DrawLines(mojPen, points11);
            objekat.DrawLines(mojPen, points12);

            objekat.FillEllipse(mojBrush, 395, 50, 20, 20);


            Point[] polygonTacke = new Point[3]; 
            polygonTacke[0] = new Point(405, 40);
            polygonTacke[1] = new Point(416, 60);
            polygonTacke[2] = new Point(395, 60);

            objekat.FillPolygon(mojBrush, polygonTacke);
        }


        private void Form1_Resize(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, KorisnikLozinka.Text);

            if (Doktor_button.Checked==true)
            {
                for (int i = 0; i < K.Doktori.Count(); i++)
                {
                    bool ima = false;
                    if (K.Doktori[i].Password == hash && K.Doktori[i].KorisnickoIme==KorisnikIme.Text)
                    {
                        
                        ima = true;
                        FormaDoktor f1 = new FormaDoktor(ref k,K.Doktori[i]);
                        f1.ShowDialog();
                    }

                    if(!ima) striplabela.Text = "Ne postoji doktor sa unesenim podacima!";
                    


                }
            }

            if (Tehnicar_button.Checked == true) {

                bool ima = false;
                for (int i = 0; i < K.Tehnicari.Count(); i++)
                {
                    
                    if (K.Tehnicari[i].KorisnickoIme == KorisnikIme.Text && K.Tehnicari[i].Password == hash)
                    {
                        ima = true;
                        FormaTehnicar f1 = new FormaTehnicar(ref k);
                        f1.ShowDialog();
                    }
                }
                    if(!ima) striplabela.Text = "Ne postoji tehničar sa unesenim podacima!";
                   
                
               
            }

            if (Pacijent_button.Checked == true)
            {
                bool ima = false;

                for (int i = 0; i < K.Pacijenti.Count(); i++)
                {
                    if (K.Pacijenti[i].KorisnickoIme == KorisnikIme.Text && K.Pacijenti[i].Password == hash)
                    {
                        ima = true;
                        FormaPacijent f1 = new FormaPacijent(ref k,K.Pacijenti[i]);
                        f1.ShowDialog();
                    }
                }
                if(!ima) striplabela.Text = "Ne postoji pacijent sa unesenim podacima!";
                
            }

            if (admin.Checked) {
                striplabela.Text = "Administrator je zadužen za unos i ažuriranje doktora!";
               
            }


        }

        private void Doktor_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, KorisnikLozinka.Text);

            if (admin.Checked)
            {
                bool pronadjen = false;
                if (k.Admin.KorisnickoIme == KorisnikIme.Text && K.Admin.Password == hash)
                {
                    pronadjen = true;
                    FormaAdministrator f1 = new FormaAdministrator(ref k);
                    f1.ShowDialog();
                }

                if(!pronadjen) striplabela.Text = "Ne postoji administrator sa unesenim podacima!";
                
            }
            else striplabela.Text = "Samo administrator može registrovati nove korisnike!";


        }

        private void Pacijent_button_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void KorisnikIme_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Korisničko ime mora sadržavati minimalno tri znaka.", e);
        }

        private void ValidirajTextBox(TextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length < 3)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void UkloniError(Control C)
        {
            
            errorProvider1.SetError(C, "");
        }

        private void KorisnikIme_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void KorisnikLozinka_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Password mora sadržavati minimalno tri znaka.", e);
        }

        private void KorisnikLozinka_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void PotvrdaUnosa_Validating(object sender, CancelEventArgs e)
        {
                   
        }

        private void ValidirajUnos(TextBox t, string Text, CancelEventArgs e)
        {
          

        }

        private void PotvrdaUnosa_Validated(object sender, EventArgs e)
        {
           
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
