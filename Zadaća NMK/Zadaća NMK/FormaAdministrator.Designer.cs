namespace Zadaća_NMK
{
    partial class FormaAdministrator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.astanovanja = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ZenskoK = new System.Windows.Forms.RadioButton();
            this.MuskoK = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SlobodnaK = new System.Windows.Forms.RadioButton();
            this.UdataK = new System.Windows.Forms.RadioButton();
            this.Klozinka = new System.Windows.Forms.TextBox();
            this.Kime = new System.Windows.Forms.TextBox();
            this.JMBGK = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PrezimeK = new System.Windows.Forms.TextBox();
            this.ImeK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DoktorB = new System.Windows.Forms.RadioButton();
            this.TehnicarB = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ZatvoriK = new System.Windows.Forms.Button();
            this.PotvrdiK = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Doktorbrisanje = new System.Windows.Forms.RadioButton();
            this.TehnicarBrisanje = new System.Windows.Forms.RadioButton();
            this.ZatvoriBrisanje = new System.Windows.Forms.Button();
            this.ObrisiPacijentaF = new System.Windows.Forms.Button();
            this.JMBGbrisanjeF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiPoljeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabela = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.astanovanja);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Klozinka);
            this.groupBox1.Controls.Add(this.Kime);
            this.groupBox1.Controls.Add(this.JMBGK);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.PrezimeK);
            this.groupBox1.Controls.Add(this.ImeK);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(15, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 410);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci: ";
            // 
            // astanovanja
            // 
            this.astanovanja.Location = new System.Drawing.Point(129, 202);
            this.astanovanja.Name = "astanovanja";
            this.astanovanja.Size = new System.Drawing.Size(123, 23);
            this.astanovanja.TabIndex = 22;
            this.astanovanja.Validating += new System.ComponentModel.CancelEventHandler(this.astanovanja_Validating);
            this.astanovanja.Validated += new System.EventHandler(this.astanovanja_Validated);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Adresa stanovanja:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ZenskoK);
            this.groupBox3.Controls.Add(this.MuskoK);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(28, 323);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 76);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Spol:";
            // 
            // ZenskoK
            // 
            this.ZenskoK.AutoSize = true;
            this.ZenskoK.Location = new System.Drawing.Point(129, 33);
            this.ZenskoK.Name = "ZenskoK";
            this.ZenskoK.Size = new System.Drawing.Size(63, 19);
            this.ZenskoK.TabIndex = 16;
            this.ZenskoK.TabStop = true;
            this.ZenskoK.Text = "Žensko";
            this.ZenskoK.UseVisualStyleBackColor = true;
            // 
            // MuskoK
            // 
            this.MuskoK.AutoSize = true;
            this.MuskoK.Location = new System.Drawing.Point(16, 33);
            this.MuskoK.Name = "MuskoK";
            this.MuskoK.Size = new System.Drawing.Size(62, 19);
            this.MuskoK.TabIndex = 15;
            this.MuskoK.TabStop = true;
            this.MuskoK.Text = "Muško";
            this.MuskoK.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SlobodnaK);
            this.groupBox2.Controls.Add(this.UdataK);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(28, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 75);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bračno stanje:";
            // 
            // SlobodnaK
            // 
            this.SlobodnaK.AutoSize = true;
            this.SlobodnaK.Location = new System.Drawing.Point(129, 32);
            this.SlobodnaK.Name = "SlobodnaK";
            this.SlobodnaK.Size = new System.Drawing.Size(89, 19);
            this.SlobodnaK.TabIndex = 15;
            this.SlobodnaK.TabStop = true;
            this.SlobodnaK.Text = "Slobodan/a";
            this.SlobodnaK.UseVisualStyleBackColor = true;
            // 
            // UdataK
            // 
            this.UdataK.AutoSize = true;
            this.UdataK.Location = new System.Drawing.Point(16, 32);
            this.UdataK.Name = "UdataK";
            this.UdataK.Size = new System.Drawing.Size(107, 19);
            this.UdataK.TabIndex = 14;
            this.UdataK.TabStop = true;
            this.UdataK.Text = "Udata/Oženjen";
            this.UdataK.UseVisualStyleBackColor = true;
            // 
            // Klozinka
            // 
            this.Klozinka.Location = new System.Drawing.Point(129, 173);
            this.Klozinka.Name = "Klozinka";
            this.Klozinka.Size = new System.Drawing.Size(123, 23);
            this.Klozinka.TabIndex = 13;
            this.Klozinka.Validating += new System.ComponentModel.CancelEventHandler(this.Klozinka_Validating);
            this.Klozinka.Validated += new System.EventHandler(this.Klozinka_Validated);
            // 
            // Kime
            // 
            this.Kime.Location = new System.Drawing.Point(129, 144);
            this.Kime.Name = "Kime";
            this.Kime.Size = new System.Drawing.Size(123, 23);
            this.Kime.TabIndex = 12;
            this.Kime.Validating += new System.ComponentModel.CancelEventHandler(this.Kime_Validating);
            this.Kime.Validated += new System.EventHandler(this.Kime_Validated);
            // 
            // JMBGK
            // 
            this.JMBGK.Location = new System.Drawing.Point(129, 115);
            this.JMBGK.Name = "JMBGK";
            this.JMBGK.Size = new System.Drawing.Size(123, 23);
            this.JMBGK.TabIndex = 11;
            this.JMBGK.Validating += new System.ComponentModel.CancelEventHandler(this.JMBGK_Validating);
            this.JMBGK.Validated += new System.EventHandler(this.JMBGK_Validated);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 23);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker1_Validating);
            this.dateTimePicker1.Validated += new System.EventHandler(this.dateTimePicker1_Validated);
            // 
            // PrezimeK
            // 
            this.PrezimeK.Location = new System.Drawing.Point(129, 57);
            this.PrezimeK.Name = "PrezimeK";
            this.PrezimeK.Size = new System.Drawing.Size(123, 23);
            this.PrezimeK.TabIndex = 9;
            this.PrezimeK.Validating += new System.ComponentModel.CancelEventHandler(this.PrezimeK_Validating);
            this.PrezimeK.Validated += new System.EventHandler(this.PrezimeK_Validated);
            // 
            // ImeK
            // 
            this.ImeK.Location = new System.Drawing.Point(129, 28);
            this.ImeK.Name = "ImeK";
            this.ImeK.Size = new System.Drawing.Size(123, 23);
            this.ImeK.TabIndex = 8;
            this.ImeK.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.ImeK.Validating += new System.ComponentModel.CancelEventHandler(this.ImeK_Validating);
            this.ImeK.Validated += new System.EventHandler(this.ImeK_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Korisničko ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "JMBG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum rođenja:";
            // 
            // DoktorB
            // 
            this.DoktorB.AutoSize = true;
            this.DoktorB.Location = new System.Drawing.Point(48, 28);
            this.DoktorB.Name = "DoktorB";
            this.DoktorB.Size = new System.Drawing.Size(62, 19);
            this.DoktorB.TabIndex = 12;
            this.DoktorB.TabStop = true;
            this.DoktorB.Text = "Doktor";
            this.DoktorB.UseVisualStyleBackColor = true;
            // 
            // TehnicarB
            // 
            this.TehnicarB.AutoSize = true;
            this.TehnicarB.Location = new System.Drawing.Point(48, 53);
            this.TehnicarB.Name = "TehnicarB";
            this.TehnicarB.Size = new System.Drawing.Size(72, 19);
            this.TehnicarB.TabIndex = 13;
            this.TehnicarB.TabStop = true;
            this.TehnicarB.Text = "Tehničar";
            this.TehnicarB.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DoktorB);
            this.groupBox4.Controls.Add(this.TehnicarB);
            this.groupBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(309, 8);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(195, 96);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Korisnik:";
            // 
            // ZatvoriK
            // 
            this.ZatvoriK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZatvoriK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZatvoriK.Location = new System.Drawing.Point(358, 373);
            this.ZatvoriK.Name = "ZatvoriK";
            this.ZatvoriK.Size = new System.Drawing.Size(134, 34);
            this.ZatvoriK.TabIndex = 15;
            this.ZatvoriK.Text = "Zatvori";
            this.ZatvoriK.UseVisualStyleBackColor = true;
            this.ZatvoriK.Click += new System.EventHandler(this.ZatvoriK_Click);
            // 
            // PotvrdiK
            // 
            this.PotvrdiK.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PotvrdiK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PotvrdiK.Location = new System.Drawing.Point(357, 335);
            this.PotvrdiK.Name = "PotvrdiK";
            this.PotvrdiK.Size = new System.Drawing.Size(134, 32);
            this.PotvrdiK.TabIndex = 16;
            this.PotvrdiK.Text = "Potvrdi unos...";
            this.PotvrdiK.UseVisualStyleBackColor = true;
            this.PotvrdiK.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(538, 449);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.ZatvoriK);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.PotvrdiK);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(530, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registracija doktora/tehničara";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(530, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Brisanje doktora/tehničara";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.groupBox5);
            this.groupBox6.Controls.Add(this.ZatvoriBrisanje);
            this.groupBox6.Controls.Add(this.ObrisiPacijentaF);
            this.groupBox6.Controls.Add(this.JMBGbrisanjeF);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(293, 421);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Osoba koji se briše: ";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Doktorbrisanje);
            this.groupBox5.Controls.Add(this.TehnicarBrisanje);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(19, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(252, 81);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Odaberi osoblje";
            // 
            // Doktorbrisanje
            // 
            this.Doktorbrisanje.AutoSize = true;
            this.Doktorbrisanje.Location = new System.Drawing.Point(40, 22);
            this.Doktorbrisanje.Name = "Doktorbrisanje";
            this.Doktorbrisanje.Size = new System.Drawing.Size(62, 19);
            this.Doktorbrisanje.TabIndex = 4;
            this.Doktorbrisanje.TabStop = true;
            this.Doktorbrisanje.Text = "Doktor";
            this.Doktorbrisanje.UseVisualStyleBackColor = true;
            this.Doktorbrisanje.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TehnicarBrisanje
            // 
            this.TehnicarBrisanje.AutoSize = true;
            this.TehnicarBrisanje.Location = new System.Drawing.Point(40, 47);
            this.TehnicarBrisanje.Name = "TehnicarBrisanje";
            this.TehnicarBrisanje.Size = new System.Drawing.Size(72, 19);
            this.TehnicarBrisanje.TabIndex = 5;
            this.TehnicarBrisanje.TabStop = true;
            this.TehnicarBrisanje.Text = "Tehničar";
            this.TehnicarBrisanje.UseVisualStyleBackColor = true;
            // 
            // ZatvoriBrisanje
            // 
            this.ZatvoriBrisanje.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ZatvoriBrisanje.Location = new System.Drawing.Point(176, 366);
            this.ZatvoriBrisanje.Name = "ZatvoriBrisanje";
            this.ZatvoriBrisanje.Size = new System.Drawing.Size(83, 28);
            this.ZatvoriBrisanje.TabIndex = 3;
            this.ZatvoriBrisanje.Text = "Zatvori";
            this.ZatvoriBrisanje.UseVisualStyleBackColor = true;
            this.ZatvoriBrisanje.Click += new System.EventHandler(this.ZatvoriBrisanje_Click);
            // 
            // ObrisiPacijentaF
            // 
            this.ObrisiPacijentaF.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ObrisiPacijentaF.Location = new System.Drawing.Point(87, 366);
            this.ObrisiPacijentaF.Name = "ObrisiPacijentaF";
            this.ObrisiPacijentaF.Size = new System.Drawing.Size(83, 28);
            this.ObrisiPacijentaF.TabIndex = 2;
            this.ObrisiPacijentaF.Text = "Obriši";
            this.ObrisiPacijentaF.UseVisualStyleBackColor = true;
            this.ObrisiPacijentaF.Click += new System.EventHandler(this.ObrisiPacijentaF_Click);
            // 
            // JMBGbrisanjeF
            // 
            this.JMBGbrisanjeF.Location = new System.Drawing.Point(87, 127);
            this.JMBGbrisanjeF.Name = "JMBGbrisanjeF";
            this.JMBGbrisanjeF.Size = new System.Drawing.Size(122, 23);
            this.JMBGbrisanjeF.TabIndex = 1;
            this.JMBGbrisanjeF.Validating += new System.ComponentModel.CancelEventHandler(this.JMBGbrisanjeF_Validating);
            this.JMBGbrisanjeF.Validated += new System.EventHandler(this.JMBGbrisanjeF_Validated);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "JMBG:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(530, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pretraži osoblje";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(352, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zatvori";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(208, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Potvrdi unos...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(281, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tehničari:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Doktori:";
            // 
            // richTextBox2
            // 
            this.richTextBox2.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox2.Location = new System.Drawing.Point(284, 41);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(186, 312);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem,
            this.obrišiPoljeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click_1);
            // 
            // obrišiPoljeToolStripMenuItem
            // 
            this.obrišiPoljeToolStripMenuItem.Name = "obrišiPoljeToolStripMenuItem";
            this.obrišiPoljeToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.obrišiPoljeToolStripMenuItem.Text = "Obriši polje";
            this.obrišiPoljeToolStripMenuItem.Click += new System.EventHandler(this.obrišiPoljeToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.richTextBox1.Location = new System.Drawing.Point(31, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(198, 312);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabela});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(544, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabela
            // 
            this.StatusLabela.ForeColor = System.Drawing.Color.Red;
            this.StatusLabela.Name = "StatusLabela";
            this.StatusLabela.Size = new System.Drawing.Size(0, 17);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage4.Controls.Add(this.linkLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(530, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Analiza sadržaja";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.LinkColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(34, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(206, 15);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Analiza tehničara po broju sati rada";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormaAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(544, 480);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FormaAdministrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.RegistrujDiliT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox astanovanja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ZenskoK;
        private System.Windows.Forms.RadioButton MuskoK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SlobodnaK;
        private System.Windows.Forms.RadioButton UdataK;
        private System.Windows.Forms.TextBox Klozinka;
        private System.Windows.Forms.TextBox Kime;
        private System.Windows.Forms.TextBox JMBGK;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox PrezimeK;
        private System.Windows.Forms.TextBox ImeK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton DoktorB;
        private System.Windows.Forms.RadioButton TehnicarB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ZatvoriK;
        private System.Windows.Forms.Button PotvrdiK;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ZatvoriBrisanje;
        private System.Windows.Forms.Button ObrisiPacijentaF;
        private System.Windows.Forms.TextBox JMBGbrisanjeF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton Doktorbrisanje;
        private System.Windows.Forms.RadioButton TehnicarBrisanje;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiPoljeToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}