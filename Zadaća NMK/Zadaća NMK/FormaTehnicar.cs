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
    public partial class FormaTehnicar : Form
    {
        Klinika k;
        bool dozvoliPrelazak;

        public Klinika K { get => k; set => k = value; }
        public bool DozvoliPrelazak { get => dozvoliPrelazak; set => dozvoliPrelazak = value; }

        public FormaTehnicar(ref Klinika klin)
        {
            dozvoliPrelazak = true;
            K = klin;
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool pronadjen = false;
            if (jmbgKarton.Text == "" || alergijeK.Text == "" || bolestiPrije.Text == "" || bolestiSada.Text == "" || bolestiUPorodici.Text == "" || misljenjeDok.Text == "") StatusLabela.Text = "Nisu uneseni svi podaci potrebni da se registruje karton!";
            else
            {
                for (int i = 0; i < k.Pacijenti.Count; i++)
                {
                    if (k.Pacijenti[i].MaticniBroj == jmbgKarton.Text)
                    {
                        pronadjen = true;
                        k.Kartoni.Add(new Karton(k.Pacijenti[i], alergijeK.Text, bolestiPrije.Text, bolestiSada.Text, bolestiUPorodici.Text, misljenjeDok.Text));
                    }
                }
            }

            if (pronadjen) Close();
            else StatusLabela.Text = "Nije pronađen karton pacijenta sa unesenim jbmgom!";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
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
            bool registrovan = false;
            bool postoji = false;
            foreach (var pac in k.Pacijenti) {
                if (pac.MaticniBroj == JMBGP.Text) postoji = true;
            }

            if (postoji) StatusLabela.Text = "Pacijent sa unesenim JMBGom već postoji!";

            else
            {
                int spol = 0;
                if (MuskoP.Checked) spol = 2;
                else if (ZenskoP.Checked) spol = 1;
                else spol = 0;

                int brak = 0;
                if (UdataP.Checked) brak = 1;
                else if (SlobodanP.Checked) brak = 2;
                else brak = 0;

                MD5 md5Hash = MD5.Create();
                string hash = GetMd5Hash(md5Hash, LozinkaP.Text);


                

                if (spol == 0 || brak == 0 || imeP.Text == "" || PrezimeP.Text == "" || JMBGP.Text == "" || AdresaStP.Text == "" || KimeP.Text == "" || LozinkaP.Text == "") StatusLabela.Text = "Nisu popunjena sva polja za unos pacijenta!";
                else if (ortopedijaO.Checked == false && InternistickaO.Checked == false && oftamoloskaO.Checked == false &&
                    laboratorijskaO.Checked == false && OMedicina.Checked == false && sistematskiobicni.Checked == false) StatusLabela.Text = "Nije unesen nijedan pregled!";
                else
                {
                    Pacijent p = new Pacijent(imeP.Text, PrezimeP.Text, JMBGP.Text, DateTime.Parse(dateTimePicker1.Text), spol, AdresaStP.Text, brak, DateTime.Parse(dateTimePicker2.Text), KimeP.Text, hash, userControl11.Slika);
                    k.Pacijenti.Add(p);

                    registrovan = true;
                    if (sistematskiobicni.Checked)
                    {
                        k.Ordinacije[0].Pacijenti.Add(p);
                        k.Ordinacije[2].Pacijenti.Add(p);
                        k.Ordinacije[3].Pacijenti.Add(p);

                    }

                    if (ortopedijaO.Checked) k.Ordinacije[1].Pacijenti.Add(p);
                    if (InternistickaO.Checked) k.Ordinacije[2].Pacijenti.Add(p);
                    if (oftamoloskaO.Checked) k.Ordinacije[3].Pacijenti.Add(p);
                    if (laboratorijskaO.Checked) k.Ordinacije[4].Pacijenti.Add(p);
                    if (OMedicina.Checked) k.Ordinacije[0].Pacijenti.Add(p);

                }

            }
            if(registrovan) Close();
        }

        private void RegistrujHitnogPacijenta_Click(object sender, EventArgs e)
        {
            bool registrovan = false;
            bool postoji = false;
            foreach (var pac in k.Pacijenti)
            {
                if (pac.MaticniBroj == JMBGF.Text) postoji = true;
            }

            if (postoji) StatusLabela.Text = "Pacijent sa unesenim JMBGom već postoji!";
            else
            {
                int spol = 0;
                if (muskoF.Checked) spol = 2;
                else if (zenskoF.Checked) spol = 1;

                int brak = 0;
                if (udataF.Checked) brak = 1;
                else if (slobodanF.Checked) brak = 2;


                

                if (spol == 0 || brak == 0 || PrvaPomocF.Text == "" || imeF.Text == "" || prezimeF.Text == "" || JMBGF.Text == "" || stanovanjeF.Text == "" || kimeF.Text == "" || klozinkaF.Text == "") StatusLabela.Text = "Nisu popunjena sva polja za unos pacijenta!";
                else if (ortopedijaFp.Checked == false && internistickaFp.Checked == false && oftamoloskaFp.Checked == false &&
                    laboratorijskaFp.Checked == false && opstaFp.Checked == false && sistematskiFp.Checked == false) StatusLabela.Text = "Nije unesen nijedan pregled!";
                else
                {
                    MD5 md5Hash = MD5.Create();
                    string hash = GetMd5Hash(md5Hash, klozinkaF.Text);

                    registrovan = true;
                    HitanPacijent p = new HitanPacijent(PrvaPomocF.Text, imeF.Text, prezimeF.Text, JMBGF.Text, DateTime.Parse(dateTimePicker4.Text), spol, stanovanjeF.Text, brak, DateTime.Parse(dateTimePicker3.Text), kimeF.Text, hash, userControl12.Slika);
                    k.Pacijenti.Add(p);

                    if (sistematskiobicni.Checked)
                    {
                        k.Ordinacije[0].Pacijenti.Add(p);
                        k.Ordinacije[2].Pacijenti.Add(p);
                        k.Ordinacije[3].Pacijenti.Add(p);

                    }


                    if (ortopedijaFp.Checked) k.Ordinacije[1].Pacijenti.Add(p);
                    if (internistickaFp.Checked) k.Ordinacije[2].Pacijenti.Add(p);
                    if (oftamoloskaFp.Checked) k.Ordinacije[3].Pacijenti.Add(p);
                    if (laboratorijskaFp.Checked) k.Ordinacije[4].Pacijenti.Add(p);
                    if (opstaFp.Checked) k.Ordinacije[0].Pacijenti.Add(p);
                }
            }
            if(registrovan) Close();
        }

        private void RegistrujUmrlogPacijenta_Click(object sender, EventArgs e)
        {

            bool registrovan = false;
            bool postoji = false;
            foreach (var pac in k.Pacijenti)
            {
                if (pac.MaticniBroj == JMBGHP.Text) postoji = true;
            }

            if (postoji) StatusLabela.Text = "Pacijent sa unesenim JMBGom već postoji!";
            else
            {

                int spol = 0;
                if (MuskoHP.Checked) spol = 2;
                else if (ZenskoHP.Checked) spol = 1;

                int brak = 0;
                if (UdataHP.Checked) brak = 1;
                else if (SlobodnaHP.Checked) brak = 2;

                MD5 md5Hash = MD5.Create();
                string hash = GetMd5Hash(md5Hash, LozinkaHP.Text);



                if (spol == 0 || brak == 0 || PrvaPomocHP.Text == "" || ImeHP.Text == "" || PrezimeHP.Text == "" || JMBGHP.Text == "" || AdresaStanovanjaHP.Text == "" || KimeHP.Text == "" || LozinkaHP.Text == "" || UzrokSmrtiHP.Text == "") StatusLabela.Text = "Nisu popunjena sva polja za unos pacijenta!";
                else
                {
                    registrovan = true;
                    Umrli p = new Umrli(PrvaPomocHP.Text, ImeHP.Text, PrezimeHP.Text, JMBGHP.Text, DateTime.Parse(dateTimePicker6.Text), spol, AdresaStanovanjaHP.Text, brak, DateTime.Parse(dateTimePicker5.Text), DateTime.Parse(dateTimePicker7.Text), UzrokSmrtiHP.Text, DateTime.Parse(dateTimePicker8.Text), KimeHP.Text, hash, userControl13.Slika);
                    k.Pacijenti.Add(p);
                }
            }
            if(registrovan) Close();
        }

        private void ZatvoriF1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ObrisiPacijenta_Click(object sender, EventArgs e)
        {
            bool pronadjen = false;
            for (int i = 0; i < k.Pacijenti.Count; i++) {
                if (k.Pacijenti[i].MaticniBroj == JMBGbrisanje.Text) {
                    pronadjen = true;
                    k.Pacijenti.RemoveAt(i); }
            }

            if(!pronadjen) StatusLabela.Text = "Nije pronađen pacijent sa unesenim JMBGom!";

            if (pronadjen) Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBoxSlika_Click(object sender, EventArgs e)
        {

        }

        private void ucitajF_Click(object sender, EventArgs e)
        {
            
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


        private void imeP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Ime mora sadržavati minimalno tri znaka.", e);

        }

        private void imeP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void PrezimeP_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrezimeP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Prezime mora sadržavati minimalno tri znaka.", e);
        }

        private void PrezimeP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neisparavan datum", e);

        }

        private void ValidirajDatum(DateTimePicker t, string Text, CancelEventArgs e)
        {
            if (DateTime.Parse(t.Text)>DateTime.Now)
            {
                errorProvider1.SetError(t, "Nevaljan datum!");
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }

        }

        private void JMBGP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajJmbg(sender as TextBox, " ", e);
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

                string p = "" + pom[0] + pom[1]+ "." + pom[2] + pom[3]+"." +novi[6] + pom[4] + pom[5] + pom[6]+".";
                

                if (p != novi)
                {
                    errorProvider1.SetError(t, "JMBG se ne podudara sa datumom rođenja!");
                    e.Cancel = !DozvoliPrelazak;
                }
            }
        }

        private void JMBGP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            string pom = t.Text;
            string p = "";
            string novi = dateTimePicker1.Value.ToShortDateString();
            if (t.Text.Length == 13)
            {
                p = "" + pom[0] + pom[1] + "." + pom[2] + pom[3] + "." + novi[6] + pom[4] + pom[5] + pom[6]+"." ;
            }
                if (t.Text.Length == 13 && novi==p) UkloniError(t);
        }

        private void KimeP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Korisničko ime mora sadržavati minimalno tri znaka.", e);
        }

        private void KimeP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void LozinkaP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Password mora sadržavati minimalno tri znaka.", e);
        }

        private void LozinkaP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void AdresaStP_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdresaStP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Password mora sadržavati minimalno tri znaka.", e);
        }

        private void AdresaStP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void dateTimePicker2_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, " ", e);

        }

        private void dateTimePicker2_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void imeF_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void imeF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Ime mora sadržavati minimalno tri znaka.", e);
        }

        private void prezimeF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Prezime mora sadržavati minimalno tri znaka.", e);
        }

        private void prezimeF_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void dateTimePicker4_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neispravan datum!", e);
        }

        private void dateTimePicker4_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void dateTimePicker3_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neispravan datum!", e);
        }

        private void dateTimePicker3_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void JMBGF_TextChanged(object sender, EventArgs e)
        {

        }

        private void JMBGF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajJmbg(sender as TextBox, " ", e);
        }

        private void kimeF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Korisničko ime mora sadržavati minimalno tri znaka.", e);
        }

        private void kimeF_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void klozinkaF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Password mora sadržavati minimalno tri znaka.", e);
        }

        private void klozinkaF_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void stanovanjeF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Adresa stanovanja mora sadržavati minimalno tri znaka.", e);
        }

        private void stanovanjeF_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void PrvaPomocF_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBox(sender as RichTextBox, "Prva pomoć mora sadržavati minimalno tri znaka.", e);
        }

        private void ValidirajRichTextBox(RichTextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length < 3)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void PrvaPomocF_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void ImeHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Ime mora sadržavati minimalno tri znaka.", e);
        }

        private void ImeHP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void PrezimeHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Prezime mora sadržavati minimalno tri znaka.", e);
        }

        private void PrezimeHP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void KimeHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Korisničko ime mora sadržavati minimalno tri znaka.", e);
        }

        private void KimeHP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void LozinkaHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Password mora sadržavati minimalno tri znaka.", e);
        }

        private void LozinkaHP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void AdresaStanovanjaHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBox(sender as TextBox, "Adresa stanovanja mora sadržavati minimalno tri znaka.", e);
        }

        private void AdresaStanovanjaHP_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void PrvaPomocHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBox(sender as RichTextBox, "Prva pomoć mora sadržavati minimalno tri znaka.", e);

        }

        private void PrvaPomocHP_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void UzrokSmrtiHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBox(sender as RichTextBox, "Uzrok smrti mora sadržavati minimalno tri znaka.", e);
        }

        private void UzrokSmrtiHP_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 3) UkloniError(t);
        }

        private void dateTimePicker6_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neispravan datum!", e);
        }

        private void dateTimePicker6_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void dateTimePicker5_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neispravan datum!", e);
        }

        private void dateTimePicker5_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void dateTimePicker7_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neispravan datum!", e);
        }

        private void dateTimePicker7_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void dateTimePicker8_Validating(object sender, CancelEventArgs e)
        {
            ValidirajDatum(sender as DateTimePicker, "Neispravan datum!", e);
        }

        private void dateTimePicker8_Validated(object sender, EventArgs e)
        {
            DateTimePicker t = sender as DateTimePicker;
            if (DateTime.Parse(t.Text) < DateTime.Now)
            {
                UkloniError(t);
            }
        }

        private void JMBGbrisanje_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBoxjmbg(sender as TextBox, "JMBG mora sadržavati 13 brojeva!", e);
        }

        private void ValidirajTextBoxjmbg(TextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length != 13)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void JMBGbrisanje_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length ==13) UkloniError(t);
        }

        private void pretragaKartona_Click(object sender, EventArgs e)
        {
            bool pronadjen = false;
            foreach(var kar in k.Kartoni){
                if (kar.Pacijent.MaticniBroj == jmbgKarton.Text) pronadjen = true;
            }

            if(!pronadjen) StatusLabela.Text = "Ne postoji karton pacijenta sa unesenim jmbgom!";
        }

        private void jmbgKarton_Validating(object sender, CancelEventArgs e)
        {
            ValidirajTextBoxjmbg(sender as TextBox, "JMBG mora sadržavati 13 brojeva!", e);
        }

        private void jmbgKarton_Validated(object sender, EventArgs e)
        {
            TextBox t = sender as TextBox;
            if (t.Text.Length == 13) UkloniError(t);
        }

        private void misljenjeDok_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBoxKarton(sender as RichTextBox, "Mišljenje doktora mora sadržavati barem jedan karakter.", e);
        }

        private void ValidirajRichTextBoxKarton(RichTextBox t, string Text, CancelEventArgs e)
        {
            if (t.Text.Length < 1)
            {
                errorProvider1.SetError(t, Text);
                e.Cancel = !DozvoliPrelazak;
            }

        }

        private void misljenjeDok_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 1) UkloniError(t);
        }

        private void alergijeK_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBoxKarton(sender as RichTextBox, "Polje za alergije mora sadržavati barem jedan karakter.", e);
        }

        private void alergijeK_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 1) UkloniError(t);
        }

        private void bolestiPrije_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBoxKarton(sender as RichTextBox, "Polje za prijašnje bolesti mora sadržavati barem jedan karakter.", e);
        }

        private void bolestiPrije_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 1) UkloniError(t);
        }

        private void bolestiSada_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBoxKarton(sender as RichTextBox, "Polje za sadašnje bolesti mora sadržavati barem jedan karakter.", e);
        }

        private void bolestiSada_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 1) UkloniError(t);
        }

        private void bolestiUPorodici_Validating(object sender, CancelEventArgs e)
        {
            ValidirajRichTextBoxKarton(sender as RichTextBox, "Polje za bolesti u porodici mora sadržavati barem jedan karakter.", e);
        }

        private void bolestiUPorodici_Validated(object sender, EventArgs e)
        {
            RichTextBox t = sender as RichTextBox;
            if (t.Text.Length >= 1) UkloniError(t);
        }

        private void JMBGF_Validated(object sender, EventArgs e)
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

        private void JMBGHP_Validating(object sender, CancelEventArgs e)
        {
            ValidirajJmbg(sender as TextBox, " ", e);
        }

        private void JMBGHP_Validated(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Name=="Node1") {
                richTextBox1.Text += "Ordinacija: "+ k.Ordinacije[0].Ime + " ima zakazanih " + k.Ordinacije[0].Pacijenti.Count +". pregleda\n";
            }

            if (treeView1.SelectedNode.Name == "Node2")
            {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[1].Ime + " ima zakazanih " + k.Ordinacije[1].Pacijenti.Count + ". pregleda!\n";
            }

            if (treeView1.SelectedNode.Name == "Node3") {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[2].Ime + " ima zakazanih " + k.Ordinacije[2].Pacijenti.Count + ". pregleda!\n";
            }

            if (treeView1.SelectedNode.Name == "Node4") {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[3].Ime + " ima zakazanih " + k.Ordinacije[3].Pacijenti.Count + ". pregleda!\n";
            }

            if (treeView1.SelectedNode.Name == "Node5") {
                richTextBox1.Text += "Ordinacija: " + k.Ordinacije[4].Ime + " ima zakazanih " + k.Ordinacije[4].Pacijenti.Count + ". pregleda!\n";
            }

            //if (ort.Checked == false && lab.Checked == false && inte.Checked == false && opm.Checked == false && oft.Checked == false) StatusLabela.Text = "Niste označili nijednu ordinaciju!";

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
