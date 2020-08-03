namespace Zadaća_NMK
{
    partial class Forma1
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
            this.Lozinka = new System.Windows.Forms.Label();
            this.KorisnickoIme = new System.Windows.Forms.Label();
            this.Doktor_button = new System.Windows.Forms.RadioButton();
            this.Pacijent_button = new System.Windows.Forms.RadioButton();
            this.Tehnicar_button = new System.Windows.Forms.RadioButton();
            this.KorisnikLozinka = new System.Windows.Forms.TextBox();
            this.KorisnikIme = new System.Windows.Forms.TextBox();
            this.PotvrdaUnosa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrujKorisnika = new System.Windows.Forms.LinkLabel();
            this.admin = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.striplabela = new System.Windows.Forms.ToolStripStatusLabel();
            this.Meni = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lozinka
            // 
            this.Lozinka.AutoSize = true;
            this.Lozinka.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lozinka.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Lozinka.Location = new System.Drawing.Point(94, 197);
            this.Lozinka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lozinka.Name = "Lozinka";
            this.Lozinka.Size = new System.Drawing.Size(88, 21);
            this.Lozinka.TabIndex = 2;
            this.Lozinka.Text = "Password: ";
            // 
            // KorisnickoIme
            // 
            this.KorisnickoIme.AutoSize = true;
            this.KorisnickoIme.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KorisnickoIme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.KorisnickoIme.Location = new System.Drawing.Point(57, 162);
            this.KorisnickoIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KorisnickoIme.Name = "KorisnickoIme";
            this.KorisnickoIme.Size = new System.Drawing.Size(125, 21);
            this.KorisnickoIme.TabIndex = 3;
            this.KorisnickoIme.Text = "Korisničko ime:";
            // 
            // Doktor_button
            // 
            this.Doktor_button.AutoSize = true;
            this.Doktor_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Doktor_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Doktor_button.Location = new System.Drawing.Point(388, 140);
            this.Doktor_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Doktor_button.Name = "Doktor_button";
            this.Doktor_button.Size = new System.Drawing.Size(77, 24);
            this.Doktor_button.TabIndex = 4;
            this.Doktor_button.TabStop = true;
            this.Doktor_button.Text = "Doktor";
            this.Doktor_button.UseVisualStyleBackColor = true;
            this.Doktor_button.CheckedChanged += new System.EventHandler(this.Doktor_CheckedChanged);
            // 
            // Pacijent_button
            // 
            this.Pacijent_button.AutoSize = true;
            this.Pacijent_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pacijent_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pacijent_button.Location = new System.Drawing.Point(388, 170);
            this.Pacijent_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Pacijent_button.Name = "Pacijent_button";
            this.Pacijent_button.Size = new System.Drawing.Size(83, 24);
            this.Pacijent_button.TabIndex = 5;
            this.Pacijent_button.TabStop = true;
            this.Pacijent_button.Text = "Pacijent";
            this.Pacijent_button.UseVisualStyleBackColor = true;
            this.Pacijent_button.CheckedChanged += new System.EventHandler(this.Pacijent_button_CheckedChanged);
            // 
            // Tehnicar_button
            // 
            this.Tehnicar_button.AutoSize = true;
            this.Tehnicar_button.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tehnicar_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Tehnicar_button.Location = new System.Drawing.Point(388, 197);
            this.Tehnicar_button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tehnicar_button.Name = "Tehnicar_button";
            this.Tehnicar_button.Size = new System.Drawing.Size(89, 24);
            this.Tehnicar_button.TabIndex = 6;
            this.Tehnicar_button.TabStop = true;
            this.Tehnicar_button.Text = "Tehničar";
            this.Tehnicar_button.UseVisualStyleBackColor = true;
            // 
            // KorisnikLozinka
            // 
            this.KorisnikLozinka.Location = new System.Drawing.Point(190, 197);
            this.KorisnikLozinka.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KorisnikLozinka.Name = "KorisnikLozinka";
            this.KorisnikLozinka.PasswordChar = '*';
            this.KorisnikLozinka.Size = new System.Drawing.Size(132, 24);
            this.KorisnikLozinka.TabIndex = 7;
            this.KorisnikLozinka.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.KorisnikLozinka.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnikLozinka_Validating);
            this.KorisnikLozinka.Validated += new System.EventHandler(this.KorisnikLozinka_Validated);
            // 
            // KorisnikIme
            // 
            this.KorisnikIme.AccessibleDescription = " ";
            this.KorisnikIme.ForeColor = System.Drawing.Color.Black;
            this.KorisnikIme.Location = new System.Drawing.Point(190, 162);
            this.KorisnikIme.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.KorisnikIme.Name = "KorisnikIme";
            this.KorisnikIme.Size = new System.Drawing.Size(132, 24);
            this.KorisnikIme.TabIndex = 8;
            this.KorisnikIme.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.KorisnikIme.Validating += new System.ComponentModel.CancelEventHandler(this.KorisnikIme_Validating);
            this.KorisnikIme.Validated += new System.EventHandler(this.KorisnikIme_Validated);
            // 
            // PotvrdaUnosa
            // 
            this.PotvrdaUnosa.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PotvrdaUnosa.ForeColor = System.Drawing.Color.Black;
            this.PotvrdaUnosa.Location = new System.Drawing.Point(388, 266);
            this.PotvrdaUnosa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PotvrdaUnosa.Name = "PotvrdaUnosa";
            this.PotvrdaUnosa.Size = new System.Drawing.Size(132, 26);
            this.PotvrdaUnosa.TabIndex = 9;
            this.PotvrdaUnosa.Text = "Potvrda..";
            this.PotvrdaUnosa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.PotvrdaUnosa.UseVisualStyleBackColor = true;
            this.PotvrdaUnosa.Click += new System.EventHandler(this.button1_Click);
            this.PotvrdaUnosa.Validating += new System.ComponentModel.CancelEventHandler(this.PotvrdaUnosa_Validating);
            this.PotvrdaUnosa.Validated += new System.EventHandler(this.PotvrdaUnosa_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(301, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "NAŠA";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(301, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "MALA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(301, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "KLINIKA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(388, 298);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 26);
            this.button1.TabIndex = 14;
            this.button1.Text = "Zatvori";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RegistrujKorisnika
            // 
            this.RegistrujKorisnika.AutoSize = true;
            this.RegistrujKorisnika.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.RegistrujKorisnika.Location = new System.Drawing.Point(96, 243);
            this.RegistrujKorisnika.Name = "RegistrujKorisnika";
            this.RegistrujKorisnika.Size = new System.Drawing.Size(226, 17);
            this.RegistrujKorisnika.TabIndex = 15;
            this.RegistrujKorisnika.TabStop = true;
            this.RegistrujKorisnika.Text = "Registracija novog doktora/tehničara";
            this.RegistrujKorisnika.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.admin.Location = new System.Drawing.Point(388, 224);
            this.admin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(128, 24);
            this.admin.TabIndex = 16;
            this.admin.TabStop = true;
            this.admin.Text = "Administrator";
            this.admin.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.striplabela});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(547, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // striplabela
            // 
            this.striplabela.ForeColor = System.Drawing.Color.Red;
            this.striplabela.Name = "striplabela";
            this.striplabela.Size = new System.Drawing.Size(10, 17);
            this.striplabela.Text = " ";
            // 
            // Meni
            // 
            this.Meni.Name = "Meni";
            this.Meni.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Forma1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(547, 356);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.RegistrujKorisnika);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PotvrdaUnosa);
            this.Controls.Add(this.KorisnikIme);
            this.Controls.Add(this.KorisnikLozinka);
            this.Controls.Add(this.Tehnicar_button);
            this.Controls.Add(this.Pacijent_button);
            this.Controls.Add(this.Doktor_button);
            this.Controls.Add(this.KorisnickoIme);
            this.Controls.Add(this.Lozinka);
            this.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Forma1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Dobro došli!";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lozinka;
        private System.Windows.Forms.Label KorisnickoIme;
        private System.Windows.Forms.RadioButton Doktor_button;
        private System.Windows.Forms.RadioButton Pacijent_button;
        private System.Windows.Forms.RadioButton Tehnicar_button;
        private System.Windows.Forms.TextBox KorisnikLozinka;
        private System.Windows.Forms.TextBox KorisnikIme;
        private System.Windows.Forms.Button PotvrdaUnosa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel RegistrujKorisnika;
        private System.Windows.Forms.RadioButton admin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel striplabela;
        private System.Windows.Forms.ContextMenuStrip Meni;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

