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
    public partial class FormaPacijent : Form
    {
        Pacijent p;
        Klinika k;
        bool dozvoliPrelazak; 

        public bool DozvoliPrelazak { get => dozvoliPrelazak; set => dozvoliPrelazak = value; }
        public Klinika K { get => k; set => k = value; }

        public FormaPacijent(ref Klinika kl, Pacijent pac)
        {
            k = kl;
            p = pac;
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ValidirajNumericUpDown(NumericUpDown t, string Text, CancelEventArgs e)
        {
            if (t.Value > 24)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void UkloniError(Control C)
        {

            errorProvider1.SetError(C, "");
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_Validating(object sender, CancelEventArgs e)
        {
            ValidirajNumericUpDown(sender as NumericUpDown, "Broj rata ne može biti veći od 24.", e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
            if (radioButton1.Checked == false && radioButton2.Checked == false) StatusLabela.Text = "Nisu unijeti svi podaci!";
            if (numericUpDown1.Value == 0) richTextBox3.Text += p.obracun();
            else {
                richTextBox3.Text += "Prva rata iznosi: " + p.obracun() / numericUpDown1.Value;
            }
        }

        private void numericUpDown1_Validated(object sender, EventArgs e)
        {
            NumericUpDown t = sender as NumericUpDown;
            if (t.Value < 25) UkloniError(t);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void informacijeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pacijentima je dostupan njihov zauzetost po ordinacijama," +
                "pregled kartona, te mogu dobiti iznos računa");
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button6_Click(object sender, EventArgs e)
        {
            int brojac = 1;
            foreach (var ord in k.Ordinacije) {
                foreach (var pac in ord.Pacijenti) {
                    if (pac == p) {
                        richTextBox2.Text += Convert.ToString(brojac) + ". " + ord.Ime + "\n";
                        brojac++;
                    }
                }
            }

            if (brojac == 1) richTextBox2.Text += "Pacijent nema registrovanih pregleda!";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool pronadjen1 = false;
            bool pronadjen2 = false;
            foreach (var pr in k.Pregledi) {
                if (pr.Jmbg == p.MaticniBroj)
                {
                    pronadjen1 = true;
                    richTextBox4.Text += pr.MisljenjeDoktora;
                    richTextBox6.Text += pr.Terapija;
                }
                else {
                    richTextBox4.Text += "Doktor nije unio mišljenje";
                    richTextBox6.Text += "Doktor nije unio terapiju";
                }
            }

            foreach (var pr in k.Kartoni) {
                if (pr.Pacijent == p)
                {
                    pronadjen2 = true;
                    richTextBox5.Text += pr.ZakljucakDoktora;
                }

                else {
                    richTextBox5.Text += "Nije unesen zaključak doktora";
                }
            }
            if (pronadjen1 == false || pronadjen2 == false) StatusLabela.Text = "Vaš karton još nije unesen, pokušajte ponovo nakon nekog vremena!";
        }

        

    }
}
