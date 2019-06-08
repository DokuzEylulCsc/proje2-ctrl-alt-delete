namespace Otel_Rezervasyon_Sistemi
{
    partial class FormUyeOl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mSIFRET = new System.Windows.Forms.MaskedTextBox();
            this.mSIFRE = new System.Windows.Forms.MaskedTextBox();
            this.mID = new System.Windows.Forms.MaskedTextBox();
            this.btnGeri = new System.Windows.Forms.Button();
            this.TXTSOYAD = new System.Windows.Forms.TextBox();
            this.btnKayit = new System.Windows.Forms.Button();
            this.TXTAD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.mSIFRET);
            this.panel1.Controls.Add(this.mSIFRE);
            this.panel1.Controls.Add(this.mID);
            this.panel1.Controls.Add(this.btnGeri);
            this.panel1.Controls.Add(this.TXTSOYAD);
            this.panel1.Controls.Add(this.btnKayit);
            this.panel1.Controls.Add(this.TXTAD);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(28, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 346);
            this.panel1.TabIndex = 0;
            // 
            // mSIFRET
            // 
            this.mSIFRET.Location = new System.Drawing.Point(117, 229);
            this.mSIFRET.Mask = "00000";
            this.mSIFRET.Name = "mSIFRET";
            this.mSIFRET.Size = new System.Drawing.Size(103, 20);
            this.mSIFRET.TabIndex = 16;
            this.mSIFRET.UseSystemPasswordChar = true;
            this.mSIFRET.ValidatingType = typeof(int);
            // 
            // mSIFRE
            // 
            this.mSIFRE.Location = new System.Drawing.Point(117, 181);
            this.mSIFRE.Mask = "00000";
            this.mSIFRE.Name = "mSIFRE";
            this.mSIFRE.Size = new System.Drawing.Size(103, 20);
            this.mSIFRE.TabIndex = 15;
            this.mSIFRE.UseSystemPasswordChar = true;
            this.mSIFRE.ValidatingType = typeof(int);
            // 
            // mID
            // 
            this.mID.Location = new System.Drawing.Point(120, 39);
            this.mID.Mask = "00000";
            this.mID.Name = "mID";
            this.mID.Size = new System.Drawing.Size(100, 20);
            this.mID.TabIndex = 14;
            this.mID.ValidatingType = typeof(int);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGeri.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGeri.Location = new System.Drawing.Point(12, 287);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(92, 31);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "Geri";
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // TXTSOYAD
            // 
            this.TXTSOYAD.Location = new System.Drawing.Point(120, 132);
            this.TXTSOYAD.Name = "TXTSOYAD";
            this.TXTSOYAD.Size = new System.Drawing.Size(100, 20);
            this.TXTSOYAD.TabIndex = 13;
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKayit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnKayit.Location = new System.Drawing.Point(139, 287);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(92, 31);
            this.btnKayit.TabIndex = 6;
            this.btnKayit.Text = "Kayit";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // TXTAD
            // 
            this.TXTAD.Location = new System.Drawing.Point(120, 85);
            this.TXTAD.Name = "TXTAD";
            this.TXTAD.Size = new System.Drawing.Size(100, 20);
            this.TXTAD.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(20, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "SOYAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "AD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sifre Tekrarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "KullaniciID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(112, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Uye OL";
            // 
            // FormUyeOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(316, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FormUyeOl";
            this.Text = "Uye OL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUyeOl_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTSOYAD;
        private System.Windows.Forms.TextBox TXTAD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mSIFRET;
        private System.Windows.Forms.MaskedTextBox mSIFRE;
        private System.Windows.Forms.MaskedTextBox mID;
    }
}