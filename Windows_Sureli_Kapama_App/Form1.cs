using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Sureli_Kapama_App
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void manuelSecimButonlariniGizle()
        {
            manOkBtn.Visible = false;
            manCancelBtn.Visible = false;
        }

        public void manuelSecimButonlariniGoster()
        {
            manOkBtn.Visible = true;
            manCancelBtn.Visible = true;
        }

        public void autoSecimButonlariniGizle()
        {
            autoOkBtn.Visible = false;
            autoCancelBtn.Visible = false;
        }

        public void autoSecimButonlariniGoster()
        {
            autoOkBtn.Visible = true;
            autoCancelBtn.Visible = true;
        }

        public void autoSecimEkraniniGoster()
        {
            bilgiLabel.Text = "Lütfen bir seçim yapınız.";
            secimCbBox.Visible = true;
            autoSecimButonlariniGoster();

        }

        public void autoSecimEkraniniGizle()
        {
            secimCbBox.Visible = false;
            autoSecimButonlariniGizle();
        }

        public void manuelSecimEkraniniGoster()
        {
            bilgiLabel.Text = "Kutuya sayısal bir ifade giriniz. (Max 600dk)";
            //buraya label gelecek
            manuelSecimButonlariniGoster();
            manTxtBox.Visible = true;
            dkStr.Visible = true;
        }

        public void manuelSecimEkraniniGizle()
        {
            manuelSecimButonlariniGizle();
            manTxtBox.Visible = false;
            dkStr.Visible = false;
        }

        public void anaEkranGoster()
        {
            autoBtn.Visible = true;
            manuBtn.Visible = true;
            bilgiLabel.Text = "lütfen kapatma süresini nasıl gireceğinizi seçiniz";
        }

        public void anaEkranGizle()
        {
            autoBtn.Visible = false;
            manuBtn.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            manuelSecimButonlariniGizle();
            autoSecimButonlariniGizle();
            secimCbBox.Visible = false;
            manTxtBox.Visible = false;
            dkStr.Visible = false;
        }

        private void autoBtn_Click(object sender, EventArgs e)
        {
            autoSecimEkraniniGoster();
            anaEkranGizle();
        }

        private void manuBtn_Click(object sender, EventArgs e)
        {
            manuelSecimEkraniniGoster();
            anaEkranGizle();
        }

        private void autoCancelBtn_Click(object sender, EventArgs e)
        {
            autoSecimEkraniniGizle();
            anaEkranGoster();
        }

        private void manCancelBtn_Click(object sender, EventArgs e)
        {
            manuelSecimEkraniniGizle();
            anaEkranGoster();
        }
    }
}
