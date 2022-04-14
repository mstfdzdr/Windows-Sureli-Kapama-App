namespace Windows_Sureli_Kapama_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.autoBtn = new System.Windows.Forms.Button();
            this.manuBtn = new System.Windows.Forms.Button();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.aktifKapamaBilgiLbl = new System.Windows.Forms.Label();
            this.aktifKapamaDurumuLbl = new System.Windows.Forms.Label();
            this.autoOkBtn = new System.Windows.Forms.Button();
            this.autoCancelBtn = new System.Windows.Forms.Button();
            this.manOkBtn = new System.Windows.Forms.Button();
            this.manCancelBtn = new System.Windows.Forms.Button();
            this.secimCbBox = new System.Windows.Forms.ComboBox();
            this.manTxtBox = new System.Windows.Forms.TextBox();
            this.dkStr = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.kucultBtn = new System.Windows.Forms.Button();
            this.surecCancelBtn = new System.Windows.Forms.Button();
            this.programiKapatBtn = new System.Windows.Forms.Button();
            this.gbox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox1
            // 
            this.gbox1.Controls.Add(this.bilgiLabel);
            this.gbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbox1.ForeColor = System.Drawing.Color.Black;
            this.gbox1.Location = new System.Drawing.Point(52, 82);
            this.gbox1.Name = "gbox1";
            this.gbox1.Size = new System.Drawing.Size(460, 96);
            this.gbox1.TabIndex = 0;
            this.gbox1.TabStop = false;
            this.gbox1.Text = "bilgilendirme";
            // 
            // autoBtn
            // 
            this.autoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.autoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.autoBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.autoBtn.Location = new System.Drawing.Point(103, 184);
            this.autoBtn.Name = "autoBtn";
            this.autoBtn.Size = new System.Drawing.Size(179, 66);
            this.autoBtn.TabIndex = 1;
            this.autoBtn.Text = "programdan seçeyim";
            this.autoBtn.UseVisualStyleBackColor = false;
            this.autoBtn.Click += new System.EventHandler(this.autoBtn_Click);
            // 
            // manuBtn
            // 
            this.manuBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.manuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manuBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manuBtn.ForeColor = System.Drawing.Color.White;
            this.manuBtn.Location = new System.Drawing.Point(288, 184);
            this.manuBtn.Name = "manuBtn";
            this.manuBtn.Size = new System.Drawing.Size(179, 66);
            this.manuBtn.TabIndex = 2;
            this.manuBtn.Text = "kendim gireyim";
            this.manuBtn.UseVisualStyleBackColor = false;
            this.manuBtn.Click += new System.EventHandler(this.manuBtn_Click);
            // 
            // bilgiLabel
            // 
            this.bilgiLabel.AutoSize = true;
            this.bilgiLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.bilgiLabel.Location = new System.Drawing.Point(35, 44);
            this.bilgiLabel.Name = "bilgiLabel";
            this.bilgiLabel.Size = new System.Drawing.Size(393, 20);
            this.bilgiLabel.TabIndex = 0;
            this.bilgiLabel.Text = "lütfen kapatma süresini nasıl gireceğinizi seçiniz";
            // 
            // aktifKapamaBilgiLbl
            // 
            this.aktifKapamaBilgiLbl.AutoSize = true;
            this.aktifKapamaBilgiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aktifKapamaBilgiLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(33)))), ((int)(((byte)(72)))));
            this.aktifKapamaBilgiLbl.Location = new System.Drawing.Point(387, 17);
            this.aktifKapamaBilgiLbl.Name = "aktifKapamaBilgiLbl";
            this.aktifKapamaBilgiLbl.Size = new System.Drawing.Size(123, 13);
            this.aktifKapamaBilgiLbl.TabIndex = 1;
            this.aktifKapamaBilgiLbl.Text = "aktif kapatma işlemi:";
            // 
            // aktifKapamaDurumuLbl
            // 
            this.aktifKapamaDurumuLbl.AutoSize = true;
            this.aktifKapamaDurumuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aktifKapamaDurumuLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.aktifKapamaDurumuLbl.Location = new System.Drawing.Point(516, 17);
            this.aktifKapamaDurumuLbl.Name = "aktifKapamaDurumuLbl";
            this.aktifKapamaDurumuLbl.Size = new System.Drawing.Size(27, 13);
            this.aktifKapamaDurumuLbl.TabIndex = 3;
            this.aktifKapamaDurumuLbl.Text = "yok";
            // 
            // autoOkBtn
            // 
            this.autoOkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.autoOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoOkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.autoOkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.autoOkBtn.Location = new System.Drawing.Point(103, 262);
            this.autoOkBtn.Name = "autoOkBtn";
            this.autoOkBtn.Size = new System.Drawing.Size(179, 66);
            this.autoOkBtn.TabIndex = 4;
            this.autoOkBtn.Text = "tamamdır ;)";
            this.autoOkBtn.UseVisualStyleBackColor = false;
            this.autoOkBtn.Click += new System.EventHandler(this.autoOkBtn_Click);
            // 
            // autoCancelBtn
            // 
            this.autoCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.autoCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.autoCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.autoCancelBtn.ForeColor = System.Drawing.Color.White;
            this.autoCancelBtn.Location = new System.Drawing.Point(288, 262);
            this.autoCancelBtn.Name = "autoCancelBtn";
            this.autoCancelBtn.Size = new System.Drawing.Size(179, 66);
            this.autoCancelBtn.TabIndex = 5;
            this.autoCancelBtn.Text = "sil baştan..";
            this.autoCancelBtn.UseVisualStyleBackColor = false;
            this.autoCancelBtn.Click += new System.EventHandler(this.autoCancelBtn_Click);
            // 
            // manOkBtn
            // 
            this.manOkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(190)))), ((int)(((byte)(120)))));
            this.manOkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manOkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manOkBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.manOkBtn.Location = new System.Drawing.Point(103, 262);
            this.manOkBtn.Name = "manOkBtn";
            this.manOkBtn.Size = new System.Drawing.Size(179, 66);
            this.manOkBtn.TabIndex = 6;
            this.manOkBtn.Text = "tamamdır ;)";
            this.manOkBtn.UseVisualStyleBackColor = false;
            this.manOkBtn.Click += new System.EventHandler(this.manOkBtn_Click);
            // 
            // manCancelBtn
            // 
            this.manCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.manCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.manCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manCancelBtn.ForeColor = System.Drawing.Color.White;
            this.manCancelBtn.Location = new System.Drawing.Point(288, 262);
            this.manCancelBtn.Name = "manCancelBtn";
            this.manCancelBtn.Size = new System.Drawing.Size(179, 66);
            this.manCancelBtn.TabIndex = 7;
            this.manCancelBtn.Text = "sil baştan..";
            this.manCancelBtn.UseVisualStyleBackColor = false;
            this.manCancelBtn.Click += new System.EventHandler(this.manCancelBtn_Click);
            // 
            // secimCbBox
            // 
            this.secimCbBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.secimCbBox.FormattingEnabled = true;
            this.secimCbBox.Items.AddRange(new object[] {
            "Seçmek için tıklayınız.",
            "Yarım saate kapat.",
            "1 saate kapat.",
            "2 saate kapat.",
            "4 saate kapat."});
            this.secimCbBox.Location = new System.Drawing.Point(103, 204);
            this.secimCbBox.Name = "secimCbBox";
            this.secimCbBox.Size = new System.Drawing.Size(364, 28);
            this.secimCbBox.TabIndex = 1;
            // 
            // manTxtBox
            // 
            this.manTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manTxtBox.Location = new System.Drawing.Point(103, 204);
            this.manTxtBox.Name = "manTxtBox";
            this.manTxtBox.Size = new System.Drawing.Size(277, 26);
            this.manTxtBox.TabIndex = 1;
            // 
            // dkStr
            // 
            this.dkStr.AutoSize = true;
            this.dkStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dkStr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.dkStr.Location = new System.Drawing.Point(386, 207);
            this.dkStr.Name = "dkStr";
            this.dkStr.Size = new System.Drawing.Size(26, 20);
            this.dkStr.TabIndex = 1;
            this.dkStr.Text = "dk";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Program burada çalışıyor..";
            this.notifyIcon.BalloonTipTitle = "Bilgisayar Kapatıcı v.1";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Bilgisayar Kapatıcı @mstfdzdr";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // kucultBtn
            // 
            this.kucultBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.kucultBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kucultBtn.ForeColor = System.Drawing.Color.White;
            this.kucultBtn.Location = new System.Drawing.Point(12, 12);
            this.kucultBtn.Name = "kucultBtn";
            this.kucultBtn.Size = new System.Drawing.Size(75, 23);
            this.kucultBtn.TabIndex = 8;
            this.kucultBtn.Text = "gizle";
            this.kucultBtn.UseVisualStyleBackColor = false;
            this.kucultBtn.Click += new System.EventHandler(this.kucultBtn_Click);
            // 
            // surecCancelBtn
            // 
            this.surecCancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(6)))), ((int)(((byte)(0)))));
            this.surecCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.surecCancelBtn.ForeColor = System.Drawing.Color.White;
            this.surecCancelBtn.Location = new System.Drawing.Point(91, 12);
            this.surecCancelBtn.Name = "surecCancelBtn";
            this.surecCancelBtn.Size = new System.Drawing.Size(109, 23);
            this.surecCancelBtn.TabIndex = 9;
            this.surecCancelBtn.Text = "kapatmayı durdur!";
            this.surecCancelBtn.UseVisualStyleBackColor = false;
            this.surecCancelBtn.Visible = false;
            this.surecCancelBtn.Click += new System.EventHandler(this.surecCancelBtn_Click);
            // 
            // programiKapatBtn
            // 
            this.programiKapatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(0)))));
            this.programiKapatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programiKapatBtn.ForeColor = System.Drawing.Color.White;
            this.programiKapatBtn.Location = new System.Drawing.Point(91, 12);
            this.programiKapatBtn.Name = "programiKapatBtn";
            this.programiKapatBtn.Size = new System.Drawing.Size(109, 23);
            this.programiKapatBtn.TabIndex = 10;
            this.programiKapatBtn.Text = "programdan çık";
            this.programiKapatBtn.UseVisualStyleBackColor = false;
            this.programiKapatBtn.Click += new System.EventHandler(this.programiKapatBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(563, 340);
            this.Controls.Add(this.programiKapatBtn);
            this.Controls.Add(this.surecCancelBtn);
            this.Controls.Add(this.kucultBtn);
            this.Controls.Add(this.dkStr);
            this.Controls.Add(this.manTxtBox);
            this.Controls.Add(this.secimCbBox);
            this.Controls.Add(this.manCancelBtn);
            this.Controls.Add(this.manOkBtn);
            this.Controls.Add(this.autoCancelBtn);
            this.Controls.Add(this.autoOkBtn);
            this.Controls.Add(this.aktifKapamaDurumuLbl);
            this.Controls.Add(this.aktifKapamaBilgiLbl);
            this.Controls.Add(this.manuBtn);
            this.Controls.Add(this.autoBtn);
            this.Controls.Add(this.gbox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilgisayar Kapatıcı v.1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gbox1.ResumeLayout(false);
            this.gbox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox1;
        private System.Windows.Forms.Button autoBtn;
        private System.Windows.Forms.Button manuBtn;
        private System.Windows.Forms.Label bilgiLabel;
        private System.Windows.Forms.Label aktifKapamaBilgiLbl;
        private System.Windows.Forms.Label aktifKapamaDurumuLbl;
        private System.Windows.Forms.Button autoOkBtn;
        private System.Windows.Forms.Button autoCancelBtn;
        private System.Windows.Forms.Button manOkBtn;
        private System.Windows.Forms.Button manCancelBtn;
        private System.Windows.Forms.ComboBox secimCbBox;
        private System.Windows.Forms.TextBox manTxtBox;
        private System.Windows.Forms.Label dkStr;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button kucultBtn;
        private System.Windows.Forms.Button surecCancelBtn;
        private System.Windows.Forms.Button programiKapatBtn;
    }
}

