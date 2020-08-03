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
    public partial class FormaDoktor : Form
    {
        static bool ima = false;
        Klinika k;
        bool dozvoliPrelazak;
        Doktor d;

        public FormaDoktor(ref Klinika kl, Doktor dr)
        {
            D = dr;
            DozvoliPrelazak = true;
            K = kl;
            InitializeComponent();
        }

        public Klinika K { get => k; set => k = value; }
        public bool DozvoliPrelazak { get => dozvoliPrelazak; set => dozvoliPrelazak = value; }
        public Doktor D { get => d; set => d = value; }

        private void UkloniError(Control C)
        {

            errorProvider1.SetError(C, "");
        }

        private void pretragaKartona_Click(object sender, EventArgs e)
        {
            bool pretraga = false;
            for (int i = 0; i < k.Pacijenti.Count; i++) {
                if (k.Pacijenti[i].MaticniBroj == JMBGDoktor.Text) pretraga = true;
            }

            if (!pretraga) StatusLabela.Text = "Nije pronadjen pacijent sa datim JBMGom";
        }

        private void RegistrujTerapiju_Click(object sender, EventArgs e)
        {

            bool pretraga = false;
            for (int i = 0; i < k.Pacijenti.Count; i++)
            {
                if (k.Pacijenti[i].MaticniBroj == JMBGDoktor.Text) pretraga = true;
            }


            if (pretraga == true)
            {

                if (JMBGDoktor.Text == "" || TerapijaDoktor.Text == "" || MisljenjeDoktor.Text == "" || (sistematskiDoktor.Checked == false &&
                    ortopedijaDoktor.Checked == false && internistickaDoktor.Checked == false && oftamoloskaDoktor.Checked == false &&
                    laboratorijskaDoktor.Checked == false && opstaDoktor.Checked == false)) StatusLabela.Text = "Nisu popunjena sva polja da bi se unio karton!";

                else
                {
                    Pregled pr = new Pregled(JMBGDoktor.Text, TerapijaDoktor.Text, MisljenjeDoktor.Text);
                    k.Pregledi.Add(pr);


                    int indeks = -1;
                    for (int i = 0; i < k.Pacijenti.Count; i++)
                    {
                        if (k.Pacijenti[i].MaticniBroj == JMBGDoktor.Text) indeks = i;
                    }

                    if (sistematskiDoktor.Checked)
                    {
                        k.Ordinacije[0].Pacijenti.Add(k.Pacijenti[indeks]);
                        k.Ordinacije[2].Pacijenti.Add(k.Pacijenti[indeks]);
                        k.Ordinacije[3].Pacijenti.Add(k.Pacijenti[indeks]);

                    }

                    if (ortopedijaDoktor.Checked) k.Ordinacije[1].Pacijenti.Add(k.Pacijenti[indeks]);
                    if (internistickaDoktor.Checked) k.Ordinacije[2].Pacijenti.Add(k.Pacijenti[indeks]);
                    if (oftamoloskaDoktor.Checked) k.Ordinacije[3].Pacijenti.Add(k.Pacijenti[indeks]);
                    if (laboratorijskaDoktor.Checked) k.Ordinacije[4].Pacijenti.Add(k.Pacijenti[indeks]);
                    if (opstaDoktor.Checked) k.Ordinacije[0].Pacijenti.Add(k.Pacijenti[indeks]);
                }
            }

            if (!pretraga) StatusLabela.Text = "Ne postoji pacijent sa unesenim JMBGom!";
        }


        private void ValidirajTextBoxjmbg(TextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length != 13)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }


        private void ValidirajRichTextBox(RichTextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length < 3)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void JMBGDoktor_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBoxjmbg(sender as TextBox, "JMBG mora sadržavati 13 brojeva!", e);
        }

        private void JMBGDoktor_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length == 13) UkloniError(t);
        }

        private void TerapijaDoktor_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBox(sender as RichTextBox, "Terapija mora sadržavati minimalno tri znaka.", e);
        }

        private void TerapijaDoktor_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void MisljenjeDoktor_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBox(sender as RichTextBox, "Terapija mora sadržavati minimalno tri znaka.", e);
        }

        private void MisljenjeDoktor_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 3) UkloniError(t);

        }

        private void DoktorForma_Load(object sender, EventArgs e)
        {

        }

        private void ZatvoriTerapiju_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opm.Checked)
            {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[0].Ime + " ima zakazanih " + k.Ordinacije[0].Pacijenti.Count + ". pregleda\n";
            }

            if (ort.Checked)
            {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[1].Ime + " ima zakazanih " + k.Ordinacije[1].Pacijenti.Count + ". pregleda!\n";
            }

            if (inte.Checked)
            {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[2].Ime + " ima zakazanih " + k.Ordinacije[2].Pacijenti.Count + ". pregleda!\n";
            }

            if (oft.Checked)
            {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[3].Ime + " ima zakazanih " + k.Ordinacije[3].Pacijenti.Count + ". pregleda!\n";
            }

            if (lab.Checked)
            {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[4].Ime + " ima zakazanih " + k.Ordinacije[4].Pacijenti.Count + ". pregleda!\n";
            }

            if (ort.Checked == false && lab.Checked == false && inte.Checked == false && opm.Checked == false && oft.Checked == false) StatusLabela.Text = "Niste označili nijednu ordinaciju!";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int brojac = 1;
            foreach (var ord in k.Ordinacije) {
                if (ord.Doktor == D) {
                    foreach (var pac in ord.Pacijenti)
                    {
                       richTextBox2.Text += Convert.ToString(brojac)+". " + pac.Ime + " " + pac.Prezime + "\n";
                       brojac++;
                    }
                }
            }
            
            if (brojac == 1) richTextBox2.Text += "Niko nema zakazan pregled";
        }
    }
}
