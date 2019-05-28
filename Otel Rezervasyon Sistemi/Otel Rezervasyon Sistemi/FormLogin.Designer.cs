namespace Otel_Rezervasyon_Sistemi
{
    partial class FormLogin
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
            System.Windows.Forms.Button btnTemizle;
            this.label1 = new System.Windows.Forms.Label();
            this.lblKullaniciID = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.linklbluyeol = new System.Windows.Forms.LinkLabel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kullaniciGirisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanıtımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şikayetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSifree = new System.Windows.Forms.TextBox();
            btnTemizle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnTemizle.Cursor = System.Windows.Forms.Cursors.No;
            btnTemizle.Location = new System.Drawing.Point(117, 281);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new System.Drawing.Size(88, 32);
            btnTemizle.TabIndex = 7;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 0;
            // 
            // lblKullaniciID
            // 
            this.lblKullaniciID.AutoSize = true;
            this.lblKullaniciID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKullaniciID.Location = new System.Drawing.Point(48, 144);
            this.lblKullaniciID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKullaniciID.Name = "lblKullaniciID";
            this.lblKullaniciID.Size = new System.Drawing.Size(88, 20);
            this.lblKullaniciID.TabIndex = 1;
            this.lblKullaniciID.Text = "KullaniciAdi:";
            this.lblKullaniciID.Click += new System.EventHandler(this.lblkullaniciad_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSifre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSifre.Location = new System.Drawing.Point(92, 191);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(44, 20);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Sifre:";
            this.lblSifre.Click += new System.EventHandler(this.lblsifre_Click);
            // 
            // linklbluyeol
            // 
            this.linklbluyeol.AutoSize = true;
            this.linklbluyeol.Location = new System.Drawing.Point(179, 223);
            this.linklbluyeol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linklbluyeol.Name = "linklbluyeol";
            this.linklbluyeol.Size = new System.Drawing.Size(58, 18);
            this.linklbluyeol.TabIndex = 3;
            this.linklbluyeol.TabStop = true;
            this.linklbluyeol.Text = "Uye OL";
            this.linklbluyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbluyeol_LinkClicked);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(162, 137);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(199, 24);
            this.txtID.TabIndex = 4;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(253, 281);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(98, 32);
            this.btnGiris.TabIndex = 6;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(156, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = " Giris Paneli";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullaniciGirisiToolStripMenuItem,
            this.tanıtımToolStripMenuItem,
            this.iletişimToolStripMenuItem,
            this.şikayetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kullaniciGirisiToolStripMenuItem
            // 
            this.kullaniciGirisiToolStripMenuItem.Name = "kullaniciGirisiToolStripMenuItem";
            this.kullaniciGirisiToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.kullaniciGirisiToolStripMenuItem.Text = "Giris Yap";
            // 
            // tanıtımToolStripMenuItem
            // 
            this.tanıtımToolStripMenuItem.Name = "tanıtımToolStripMenuItem";
            this.tanıtımToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.tanıtımToolStripMenuItem.Text = "Tanıtım";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            // 
            // şikayetToolStripMenuItem
            // 
            this.şikayetToolStripMenuItem.Name = "şikayetToolStripMenuItem";
            this.şikayetToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.şikayetToolStripMenuItem.Text = "Şikayet ";
            // 
            // txtSifree
            // 
            this.txtSifree.Location = new System.Drawing.Point(162, 187);
            this.txtSifree.Name = "txtSifree";
            this.txtSifree.Size = new System.Drawing.Size(199, 24);
            this.txtSifree.TabIndex = 10;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 390);
            this.Controls.Add(this.txtSifree);
            this.Controls.Add(this.label2);
            this.Controls.Add(btnTemizle);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.linklbluyeol);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblKullaniciID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKullaniciID;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.LinkLabel linklbluyeol;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kullaniciGirisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanıtımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şikayetToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSifree;
    }
}

