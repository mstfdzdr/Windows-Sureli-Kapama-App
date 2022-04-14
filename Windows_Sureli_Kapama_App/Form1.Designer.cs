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
            this.gbox1 = new System.Windows.Forms.GroupBox();
            this.autoBtn = new System.Windows.Forms.Button();
            this.manuBtn = new System.Windows.Forms.Button();
            this.bilgiLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoOkBtn = new System.Windows.Forms.Button();
            this.autoCancelBtn = new System.Windows.Forms.Button();
            this.manOkBtn = new System.Windows.Forms.Button();
            this.manCancelBtn = new System.Windows.Forms.Button();
            this.secimCbBox = new System.Windows.Forms.ComboBox();
            this.manTxtBox = new System.Windows.Forms.TextBox();
            this.dkStr = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(33)))), ((int)(((byte)(72)))));
            this.label2.Location = new System.Drawing.Point(372, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "aktif kapatma işlemi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(29)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(501, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "yok";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(563, 340);
            this.Controls.Add(this.dkStr);
            this.Controls.Add(this.manTxtBox);
            this.Controls.Add(this.secimCbBox);
            this.Controls.Add(this.manCancelBtn);
            this.Controls.Add(this.manOkBtn);
            this.Controls.Add(this.autoCancelBtn);
            this.Controls.Add(this.autoOkBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manuBtn);
            this.Controls.Add(this.autoBtn);
            this.Controls.Add(this.gbox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button autoOkBtn;
        private System.Windows.Forms.Button autoCancelBtn;
        private System.Windows.Forms.Button manOkBtn;
        private System.Windows.Forms.Button manCancelBtn;
        private System.Windows.Forms.ComboBox secimCbBox;
        private System.Windows.Forms.TextBox manTxtBox;
        private System.Windows.Forms.Label dkStr;
    }
}

