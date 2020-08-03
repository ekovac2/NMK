using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Zadaća_NMK
{
    public partial class FormaAdministrator : Form
    {
        static int konst = 100;
        bool dozvoliPrelazak;
        Klinika k;
        public FormaAdministrator(ref Klinika or)
        {
            DozvoliPrelazak = true;
            K = or;
            InitializeComponent();
        }

        public Klinika K { get => k; set => k = value; }
        public bool DozvoliPrelazak { get => dozvoliPrelazak; set => dozvoliPrelazak = value; }

        private void RegistrujDiliT_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            MD5 md5Hash = MD5.Create();
            string hash = GetMd5Hash(md5Hash, Klozinka.Text);

            int spol = 0;
            if (ZenskoK.Checked == true) spol = 1;
            else if (MuskoK.Checked == true) spol = 2;

            int brak = 0;
            if (UdataK.Checked) brak = 1;
            else if (SlobodnaK.Checked) brak = 2;
            else brak = 0;


            bool registrovan = false;
            if (brak==0 || ImeK.Text == "" || PrezimeK.Text == "" || JMBGK.Text == "" || spol == 0 || Kime.Text=="" || Klozinka.Text=="") StatusLabela.Text = "Nisu uneseni svi potrebni podaci da bi se registrovao korisnik!";
            else if (DoktorB.Checked == false && TehnicarB.Checked == false) StatusLabela.Text = "Nije označen korisnik koji se želi unijeti!";
            else if (DoktorB.Checked == true) {
                registrovan = true;
                k.Doktori.Add(new Doktor(ImeK.Text, PrezimeK.Text, JMBGK.Text, DateTime.Parse(dateTimePicker1.Text), spol, Kime.Text,hash));
            }
            else if (TehnicarB.Checked == true)
            {
                registrovan = true;
                k.Tehnicari.Add(new Tehnicar(ImeK.Text, PrezimeK.Text, JMBGK.Text, DateTime.Parse(dateTimePicker1.Text), spol, Kime.Text, hash, 600));
               
            }

            if(registrovan) Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZatvoriK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void ZatvoriBrisanje_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObrisiPacijentaF_Click(object sender, EventArgs e)
        {

        bool pronadjen = false;

            if ((Doktorbrisanje.Checked == false && TehnicarBrisanje.Checked == false) || JMBGbrisanjeF.Text == "") StatusLabela.Text = "Nisu uneseni svi potrebni podaci!";
            else
            {
                if (Doktorbrisanje.Checked)
                {
                    for (int i = 0; i < k.Doktori.Count; i++)
                    {

                        if (k.Doktori[i].MaticniBroj == JMBGbrisanjeF.Text) { k.Doktori.RemoveAt(i); pronadjen = true; }
                        }
                }
                if (TehnicarBrisanje.Checked)
                {
                    for (int i = 0; i < k.Tehnicari.Count; i++)
                    {

                        if (k.Tehnicari[i].MaticniBroj == JMBGbrisanjeF.Text) { k.Tehnicari.RemoveAt(i); pronadjen = true; }
                        }
                }
            }
            if (pronadjen) Close();
            else {
                StatusLabela.Text = "Nije pronadjen korisnik sa unesenim JMBGom!";
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void UkloniError(Control C)
        {
            errorProvider1.SetError(C, "");
        }

        private void ValidirajTextBox(TextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length < 3)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void ValidirajDatum(DateTimePicker t, string Text, CancelEventArgs e)
        {
            if (DateTime.Parse(t.Text) > DateTime.Now)
            {
                errorProvider1.SetError(t, "Nevaljan datum!");
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void ImeK_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Ime mora sadržavati minimalno tri znaka.", e);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ImeK_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void PrezimeK_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Prezime mora sadržavati minimalno tri znaka.", e);
        }

        private void PrezimeK_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neisparavan datum", e);
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void Kime_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Korisničko ime mora sadržavati minimalno tri znaka.", e);
        }

        private void Kime_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void Klozinka_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Password mora sadržavati minimalno tri znaka.", e);
        }

        private void Klozinka_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void astanovanja_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Adresa stanovanja mora sadržavati minimalno tri znaka.", e);
        }

        private void astanovanja_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void ValidirajTextBoxjmbg(TextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length != 13)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }


        private void JMBGbrisanjeF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBoxjmbg(sender as TextBox, "JMBG mora sadržavati 13 brojeva!", e);
        }

        private void JMBGbrisanjeF_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length == 13) UkloniError(t);
        }


        private void ValidirajJmbg(TextBox t, string Text, CancelEventArgs e)
        {
            string pom = t.Text;

            if (t.Text.Length != 13)
            {
                errorProvider1.SetError(t, "JMBG se sastoji od 13 cifara!");
                e.Cancel = !DozvoliPrelazak;
            }
            else if (t.Text.Length == 13)
            {
                string novi = dateTimePicker1.Value.ToShortDateString();

                string p = "" + pom[0] + pom[1] + "." + pom[2] + pom[3] + "." + novi[6] + pom[4] + pom[5] + pom[6] + ".";


                if (p != novi)
                {
                    errorProvider1.SetError(t, "JMBG se ne podudara sa datumom rođenja!");
                    e.Cancel = !DozvoliPrelazak;
                }
            }
        }


        private void JMBGK_Validating(object sender, CancelEventArgs e)
        {
            ValidirajJmbg(sender as TextBox, " ", e);
        }

        private void JMBGK_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string pom = t.Text;
            string p = "";
            string novi = dateTimePicker1.Value.ToShortDateString();
            if (t.Text.Length == 13)
            {
                p = "" + pom[0] + pom[1] + "." + pom[2] + pom[3] + "." + novi[6] + pom[4] + pom[5] + pom[6] + ".";
            }
            if (t.Text.Length == 13 && novi == p) UkloniError(t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach(var d in k.Doktori){
                richTextBox1.Text += d.Ime + " " + d.Prezime + "\n";
            }

            foreach (var d in k.Tehnicari)
            {
                richTextBox2.Text += d.Ime + " " + d.Prezime + "\n";
            }

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void izlazToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void obrišiPoljeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PieChart f1 = new PieChart(ref k);
            f1.ShowDialog();
        }
    }
}
