namespace Zadaća_NMK
{
    partial class FormaDoktor
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ZatvoriTerapiju = new System.Windows.Forms.Button();
            this.RegistrujTerapiju = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.laboratorijskaDoktor = new System.Windows.Forms.CheckBox();
            this.oftamoloskaDoktor = new System.Windows.Forms.CheckBox();
            this.internistickaDoktor = new System.Windows.Forms.CheckBox();
            this.ortopedijaDoktor = new System.Windows.Forms.CheckBox();
            this.opstaDoktor = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.sistematskiDoktor = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MisljenjeDoktor = new System.Windows.Forms.RichTextBox();
            this.TerapijaDoktor = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pretragaKartona = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.JMBGDoktor = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabela = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.lab = new System.Windows.Forms.CheckBox();
            this.oft = new System.Windows.Forms.CheckBox();
            this.inte = new System.Windows.Forms.CheckBox();
            this.ort = new System.Windows.Forms.CheckBox();
            this.opm = new System.Windows.Forms.CheckBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.ZatvoriTerapiju);
            this.tabPage1.Controls.Add(this.RegistrujTerapiju);
            this.tabPage1.Controls.Add(this.groupBox11);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Upis terapije u karton";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ZatvoriTerapiju
            // 
            this.ZatvoriTerapiju.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ZatvoriTerapiju.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ZatvoriTerapiju.Location = new System.Drawing.Point(549, 312);
            this.ZatvoriTerapiju.Name = "ZatvoriTerapiju";
            this.ZatvoriTerapiju.Size = new System.Drawing.Size(79, 33);
            this.ZatvoriTerapiju.TabIndex = 28;
            this.ZatvoriTerapiju.Text = "Zatvori";
            this.ZatvoriTerapiju.UseVisualStyleBackColor = true;
            this.ZatvoriTerapiju.Click += new System.EventHandler(this.ZatvoriTerapiju_Click);
            // 
            // RegistrujTerapiju
            // 
            this.RegistrujTerapiju.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RegistrujTerapiju.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegistrujTerapiju.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegistrujTerapiju.Location = new System.Drawing.Point(464, 312);
            this.RegistrujTerapiju.Name = "RegistrujTerapiju";
            this.RegistrujTerapiju.Size = new System.Drawing.Size(79, 33);
            this.RegistrujTerapiju.TabIndex = 27;
            this.RegistrujTerapiju.Text = "Registruj ";
            this.RegistrujTerapiju.UseVisualStyleBackColor = true;
            this.RegistrujTerapiju.Click += new System.EventHandler(this.RegistrujTerapiju_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.laboratorijskaDoktor);
            this.groupBox11.Controls.Add(this.oftamoloskaDoktor);
            this.groupBox11.Controls.Add(this.internistickaDoktor);
            this.groupBox11.Controls.Add(this.ortopedijaDoktor);
            this.groupBox11.Controls.Add(this.opstaDoktor);
            this.groupBox11.Controls.Add(this.label25);
            this.groupBox11.Controls.Add(this.sistematskiDoktor);
            this.groupBox11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox11.Location = new System.Drawing.Point(15, 147);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(376, 202);
            this.groupBox11.TabIndex = 26;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Vrsta pregleda:";
            // 
            // laboratorijskaDoktor
            // 
            this.laboratorijskaDoktor.AutoSize = true;
            this.laboratorijskaDoktor.Location = new System.Drawing.Point(229, 165);
            this.laboratorijskaDoktor.Name = "laboratorijskaDoktor";
            this.laboratorijskaDoktor.Size = new System.Drawing.Size(106, 19);
            this.laboratorijskaDoktor.TabIndex = 10;
            this.laboratorijskaDoktor.Text = "laboratorijska";
            this.laboratorijskaDoktor.UseVisualStyleBackColor = true;
            // 
            // oftamoloskaDoktor
            // 
            this.oftamoloskaDoktor.AutoSize = true;
            this.oftamoloskaDoktor.Location = new System.Drawing.Point(229, 140);
            this.oftamoloskaDoktor.Name = "oftamoloskaDoktor";
            this.oftamoloskaDoktor.Size = new System.Drawing.Size(95, 19);
            this.oftamoloskaDoktor.TabIndex = 9;
            this.oftamoloskaDoktor.Text = "oftamoloska";
            this.oftamoloskaDoktor.UseVisualStyleBackColor = true;
            // 
            // internistickaDoktor
            // 
            this.internistickaDoktor.AutoSize = true;
            this.internistickaDoktor.Location = new System.Drawing.Point(229, 115);
            this.internistickaDoktor.Name = "internistickaDoktor";
            this.internistickaDoktor.Size = new System.Drawing.Size(95, 19);
            this.internistickaDoktor.TabIndex = 8;
            this.internistickaDoktor.Text = "internisticka";
            this.internistickaDoktor.UseVisualStyleBackColor = true;
            // 
            // ortopedijaDoktor
            // 
            this.ortopedijaDoktor.AutoSize = true;
            this.ortopedijaDoktor.Location = new System.Drawing.Point(229, 90);
            this.ortopedijaDoktor.Name = "ortopedijaDoktor";
            this.ortopedijaDoktor.Size = new System.Drawing.Size(84, 19);
            this.ortopedijaDoktor.TabIndex = 7;
            this.ortopedijaDoktor.Text = "ortopedija";
            this.ortopedijaDoktor.UseVisualStyleBackColor = true;
            // 
            // opstaDoktor
            // 
            this.opstaDoktor.AutoSize = true;
            this.opstaDoktor.Location = new System.Drawing.Point(229, 65);
            this.opstaDoktor.Name = "opstaDoktor";
            this.opstaDoktor.Size = new System.Drawing.Size(111, 19);
            this.opstaDoktor.TabIndex = 6;
            this.opstaDoktor.Text = "opsta medicina";
            this.opstaDoktor.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(212, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(128, 15);
            this.label25.TabIndex = 5;
            this.label25.Text = "Druga vrsta pregleda: ";
            // 
            // sistematskiDoktor
            // 
            this.sistematskiDoktor.AutoSize = true;
            this.sistematskiDoktor.Location = new System.Drawing.Point(23, 38);
            this.sistematskiDoktor.Name = "sistematskiDoktor";
            this.sistematskiDoktor.Size = new System.Drawing.Size(133, 19);
            this.sistematskiDoktor.TabIndex = 4;
            this.sistematskiDoktor.Text = "Sistematski pregled";
            this.sistematskiDoktor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.MisljenjeDoktor);
            this.groupBox1.Controls.Add(this.TerapijaDoktor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(397, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 283);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos u karton: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Terapija:";
            // 
            // MisljenjeDoktor
            // 
            this.MisljenjeDoktor.Location = new System.Drawing.Point(21, 170);
            this.MisljenjeDoktor.Name = "MisljenjeDoktor";
            this.MisljenjeDoktor.Size = new System.Drawing.Size(211, 84);
            this.MisljenjeDoktor.TabIndex = 9;
            this.MisljenjeDoktor.Text = "";
            this.MisljenjeDoktor.Validating += new System.ComponentModel.CancelEventHandler(this.MisljenjeDoktor_Validating);
            this.MisljenjeDoktor.Validated += new System.EventHandler(this.MisljenjeDoktor_Validated);
            // 
            // TerapijaDoktor
            // 
            this.TerapijaDoktor.Location = new System.Drawing.Point(21, 52);
            this.TerapijaDoktor.Name = "TerapijaDoktor";
            this.TerapijaDoktor.Size = new System.Drawing.Size(211, 74);
            this.TerapijaDoktor.TabIndex = 8;
            this.TerapijaDoktor.Text = "";
            this.TerapijaDoktor.Validating += new System.ComponentModel.CancelEventHandler(this.TerapijaDoktor_Validating);
            this.TerapijaDoktor.Validated += new System.EventHandler(this.TerapijaDoktor_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mišljenje doktora:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.pretragaKartona);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Controls.Add(this.JMBGDoktor);
            this.groupBox7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(15, 15);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(376, 126);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Pretražite pacijenta: ";
            // 
            // pretragaKartona
            // 
            this.pretragaKartona.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pretragaKartona.Location = new System.Drawing.Point(281, 84);
            this.pretragaKartona.Name = "pretragaKartona";
            this.pretragaKartona.Size = new System.Drawing.Size(75, 23);
            this.pretragaKartona.TabIndex = 2;
            this.pretragaKartona.Text = "Pretraži...";
            this.pretragaKartona.UseVisualStyleBackColor = true;
            this.pretragaKartona.Click += new System.EventHandler(this.pretragaKartona_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "JMBG:";
            // 
            // JMBGDoktor
            // 
            this.JMBGDoktor.Location = new System.Drawing.Point(125, 30);
            this.JMBGDoktor.Name = "JMBGDoktor";
            this.JMBGDoktor.Size = new System.Drawing.Size(231, 23);
            this.JMBGDoktor.TabIndex = 1;
            this.JMBGDoktor.Validating += new System.ComponentModel.CancelEventHandler(this.JMBGDoktor_Validating);
            this.JMBGDoktor.Validated += new System.EventHandler(this.JMBGDoktor_Validated);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Evidencija pregleda";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.label41);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.groupBox16);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(654, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Redovi čekanja";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabela});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(675, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabela
            // 
            this.StatusLabela.ForeColor = System.Drawing.Color.Red;
            this.StatusLabela.Name = "StatusLabela";
            this.StatusLabela.Size = new System.Drawing.Size(0, 17);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(512, 299);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Zatvori...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(346, 299);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 36);
            this.button2.TabIndex = 22;
            this.button2.Text = "Potvrdi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label41.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label41.Location = new System.Drawing.Point(214, 29);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(148, 15);
            this.label41.TabIndex = 21;
            this.label41.Text = "Čekanje po ordinacijama:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox1.Location = new System.Drawing.Point(217, 59);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 217);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.lab);
            this.groupBox16.Controls.Add(this.oft);
            this.groupBox16.Controls.Add(this.inte);
            this.groupBox16.Controls.Add(this.ort);
            this.groupBox16.Controls.Add(this.opm);
            this.groupBox16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox16.Location = new System.Drawing.Point(16, 29);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(173, 243);
            this.groupBox16.TabIndex = 19;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Ordinacija:";
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(34, 107);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(106, 19);
            this.lab.TabIndex = 10;
            this.lab.Text = "laboratorijska";
            this.lab.UseVisualStyleBackColor = true;
            // 
            // oft
            // 
            this.oft.AutoSize = true;
            this.oft.Location = new System.Drawing.Point(34, 132);
            this.oft.Name = "oft";
            this.oft.Size = new System.Drawing.Size(95, 19);
            this.oft.TabIndex = 9;
            this.oft.Text = "oftamološka";
            this.oft.UseVisualStyleBackColor = true;
            // 
            // inte
            // 
            this.inte.AutoSize = true;
            this.inte.Location = new System.Drawing.Point(34, 82);
            this.inte.Name = "inte";
            this.inte.Size = new System.Drawing.Size(95, 19);
            this.inte.TabIndex = 8;
            this.inte.Text = "internistička";
            this.inte.UseVisualStyleBackColor = true;
            // 
            // ort
            // 
            this.ort.AutoSize = true;
            this.ort.Location = new System.Drawing.Point(34, 57);
            this.ort.Name = "ort";
            this.ort.Size = new System.Drawing.Size(84, 19);
            this.ort.TabIndex = 7;
            this.ort.Text = "ortopedija";
            this.ort.UseVisualStyleBackColor = true;
            // 
            // opm
            // 
            this.opm.AutoSize = true;
            this.opm.Location = new System.Drawing.Point(34, 32);
            this.opm.Name = "opm";
            this.opm.Size = new System.Drawing.Size(111, 19);
            this.opm.TabIndex = 6;
            this.opm.Text = "opšta medicina";
            this.opm.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(47, 34);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(561, 278);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(47, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trenutno evidentirani pregledi: ";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(529, 318);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 33);
            this.button3.TabIndex = 30;
            this.button3.Text = "Zatvori";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(444, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 33);
            this.button4.TabIndex = 29;
            this.button4.Text = "Potvrdi";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DoktorForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(675, 420);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "DoktorForma";
            this.Text = "Pristup";
            this.Load += new System.EventHandler(this.DoktorForma_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox MisljenjeDoktor;
        private System.Windows.Forms.RichTextBox TerapijaDoktor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button pretragaKartona;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox JMBGDoktor;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.CheckBox laboratorijskaDoktor;
        private System.Windows.Forms.CheckBox oftamoloskaDoktor;
        private System.Windows.Forms.CheckBox internistickaDoktor;
        private System.Windows.Forms.CheckBox ortopedijaDoktor;
        private System.Windows.Forms.CheckBox opstaDoktor;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.CheckBox sistematskiDoktor;
        private System.Windows.Forms.Button ZatvoriTerapiju;
        private System.Windows.Forms.Button RegistrujTerapiju;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabela;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.CheckBox lab;
        private System.Windows.Forms.CheckBox oft;
        private System.Windows.Forms.CheckBox inte;
        private System.Windows.Forms.CheckBox ort;
        private System.Windows.Forms.CheckBox opm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}