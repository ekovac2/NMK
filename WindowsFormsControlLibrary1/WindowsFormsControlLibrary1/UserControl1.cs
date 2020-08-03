using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class UserControl1: UserControl
    {
        Image slika;
        bool dozvoliPrelazak;


        public UserControl1()
        {
            InitializeComponent();
        }

        public Image Slika { get => slika; set => slika = value; }
        public bool DozvoliPrelazak { get => dozvoliPrelazak; set => dozvoliPrelazak = value; }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }


        public class DialogState
        {
            public DialogResult result;
            public FileDialog dialog;


            public void ThreadProcShowDialog()
            {
                result = dialog.ShowDialog();
            }
        }

        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new
                   System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.Join();
            return state.result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Izaberite sliku";
                dlg.Filter = "jpg files (.jpg)|.jpg";

                DialogResult rez = STAShowDialog(dlg);
                if ((DateTime.Now - dateTimePicker1.Value).TotalDays > 30*6)
                {
                    dateTimePicker1.Focus();
                    errorProvider1.SetError(dateTimePicker1, "Slika je starija od 6 mjeseci!");
                }
                else errorProvider1.SetError(dateTimePicker1, null);


                if (rez == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    Slika = pictureBox1.Image;
                }
            }
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if ((DateTime.Now - dateTimePicker1.Value).TotalDays > 30*6)
            {
                dateTimePicker1.Focus();
                errorProvider1.SetError(dateTimePicker1, "Slika je starija od 6 mjeseci.");
                e.Cancel = !DozvoliPrelazak;
            }
        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            if ((DateTime.Now - dateTimePicker1.Value).TotalDays < 30*6)
            {

                errorProvider1.SetError(dateTimePicker1, null);
            }
        }
    }
}
