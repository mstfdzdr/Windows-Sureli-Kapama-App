using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            secimCbBox.SelectedIndex = 0;
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

        public bool SayiSinirlarDahilindeMi(int sayi)
        {
            if (sayi > 0 && sayi < 600){
                return true;
            }
            return false;
        }
        
        public bool SayidaMetinVarMi(string sayi)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(sayi))
            {
                return true;
            }
            return false;
        }

        private void manOkBtn_Click(object sender, EventArgs e)
        {
            if (!SayidaMetinVarMi(manTxtBox.Text))
            {
                MessageBox.Show("Doğru düzgün sayı gir!", "Hata!!!11", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!SayiSinirlarDahilindeMi(int.Parse(manTxtBox.Text)))
                {
                    MessageBox.Show("Sayı izin verilen sınırlar içinde değil!", "Hata!!!11", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    int s = int.Parse(manTxtBox.Text) * 60;
                    sureciBaslat(s.ToString());
                }
            }
            
        }

        public void aktifKapamaMetniDegistir(bool durum)
        {
            if (durum == true)
            {
                aktifKapamaDurumuLbl.Text = "var!";
                aktifKapamaDurumuLbl.ForeColor = Color.Green;
                surecCancelBtn.Visible = true;
                programiKapatBtn.Visible = false;
            }
            else
            {
                aktifKapamaDurumuLbl.Text = "yok";
                aktifKapamaDurumuLbl.ForeColor = Color.Black;
                surecCancelBtn.Visible = false;
                programiKapatBtn.Visible = true;
            }
        }
        private void sureciBaslat(string sure)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -s -t " + sure;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
            aktifKapamaMetniDegistir(true);
        }

        private void sureciIptalEt()
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C shutdown -a ";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
            aktifKapamaMetniDegistir(false);
        }

        private void ProgramiSistemTrayKucult()
        {
            Hide();
            notifyIcon.Visible = true;
            notifyIcon.ShowBalloonTip(1000);
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void kucultBtn_Click(object sender, EventArgs e)
        {
            ProgramiSistemTrayKucult();
        }

        private void surecCancelBtn_Click(object sender, EventArgs e)
        {
            sureciIptalEt();
        }

        private void autoOkBtn_Click(object sender, EventArgs e)
        {
            if (secimCbBox.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen bir seçim yapın!", "Hata!!!11", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(secimCbBox.SelectedIndex == 1)
            { sureciBaslat("1800"); }
            else if(secimCbBox.SelectedIndex == 2)
            { sureciBaslat("3600"); }
            else if(secimCbBox.SelectedIndex == 3)
            { sureciBaslat("7200"); }
            else if (secimCbBox.SelectedIndex == 4)
            { sureciBaslat("14400"); }
        }

        private void programiKapatBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
