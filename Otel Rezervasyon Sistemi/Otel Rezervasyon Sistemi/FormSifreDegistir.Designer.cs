namespace Otel_Rezervasyon_Sistemi
{
    partial class FormSifreDegistir
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnGERİ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskYeniSifre = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mskSifreTekrari = new System.Windows.Forms.MaskedTextBox();
            this.mskEskiSifre = new System.Windows.Forms.MaskedTextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eski Sifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(17, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre Tekrarı:";
            // 
            // btnDegistir
            // 
            this.btnDegistir.BackColor = System.Drawing.Color.Black;
            this.btnDegistir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDegistir.Location = new System.Drawing.Point(148, 241);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(83, 31);
            this.btnDegistir.TabIndex = 6;
            this.btnDegistir.Text = "DEĞİSTİR";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnGERİ
            // 
            this.btnGERİ.BackColor = System.Drawing.Color.Black;
            this.btnGERİ.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGERİ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGERİ.Location = new System.Drawing.Point(20, 241);
            this.btnGERİ.Name = "btnGERİ";
            this.btnGERİ.Size = new System.Drawing.Size(81, 31);
            this.btnGERİ.TabIndex = 7;
            this.btnGERİ.Text = "GERİ";
            this.btnGERİ.UseVisualStyleBackColor = false;
            this.btnGERİ.Click += new System.EventHandler(this.btnGERİ_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.mskYeniSifre);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mskSifreTekrari);
            this.panel1.Controls.Add(this.mskEskiSifre);
            this.panel1.Controls.Add(this.btnDegistir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnGERİ);
            this.panel1.Location = new System.Drawing.Point(43, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 309);
            this.panel1.TabIndex = 12;
            // 
            // mskYeniSifre
            // 
            this.mskYeniSifre.Location = new System.Drawing.Point(131, 131);
            this.mskYeniSifre.Mask = "00000";
            this.mskYeniSifre.Name = "mskYeniSifre";
            this.mskYeniSifre.Size = new System.Drawing.Size(100, 20);
            this.mskYeniSifre.TabIndex = 16;
            this.mskYeniSifre.UseSystemPasswordChar = true;
            this.mskYeniSifre.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(16, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Yeni Sifre:";
            // 
            // mskSifreTekrari
            // 
            this.mskSifreTekrari.Location = new System.Drawing.Point(131, 181);
            this.mskSifreTekrari.Mask = "00000";
            this.mskSifreTekrari.Name = "mskSifreTekrari";
            this.mskSifreTekrari.Size = new System.Drawing.Size(100, 20);
            this.mskSifreTekrari.TabIndex = 14;
            this.mskSifreTekrari.UseSystemPasswordChar = true;
            this.mskSifreTekrari.ValidatingType = typeof(int);
            // 
            // mskEskiSifre
            // 
            this.mskEskiSifre.Location = new System.Drawing.Point(130, 89);
            this.mskEskiSifre.Mask = "00000";
            this.mskEskiSifre.Name = "mskEskiSifre";
            this.mskEskiSifre.Size = new System.Drawing.Size(101, 20);
            this.mskEskiSifre.TabIndex = 13;
            this.mskEskiSifre.UseSystemPasswordChar = true;
            this.mskEskiSifre.ValidatingType = typeof(int);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 17;
            // 
            // FormSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(354, 391);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSifreDegistir";
            this.Text = "Sifre Değiştir";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnGERİ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mskSifreTekrari;
        private System.Windows.Forms.MaskedTextBox mskEskiSifre;
        private System.Windows.Forms.MaskedTextBox mskYeniSifre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
    }
}