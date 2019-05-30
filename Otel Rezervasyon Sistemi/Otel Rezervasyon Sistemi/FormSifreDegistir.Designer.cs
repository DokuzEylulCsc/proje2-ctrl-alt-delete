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
            this.txtsdID = new System.Windows.Forms.TextBox();
            this.txtsdS = new System.Windows.Forms.TextBox();
            this.txtsdST = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnGERİ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanici ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sifre Tekrarı:";
            // 
            // txtsdID
            // 
            this.txtsdID.Location = new System.Drawing.Point(145, 30);
            this.txtsdID.Name = "txtsdID";
            this.txtsdID.Size = new System.Drawing.Size(100, 20);
            this.txtsdID.TabIndex = 3;
            // 
            // txtsdS
            // 
            this.txtsdS.Location = new System.Drawing.Point(145, 80);
            this.txtsdS.Name = "txtsdS";
            this.txtsdS.Size = new System.Drawing.Size(100, 20);
            this.txtsdS.TabIndex = 4;
            // 
            // txtsdST
            // 
            this.txtsdST.Location = new System.Drawing.Point(145, 130);
            this.txtsdST.Name = "txtsdST";
            this.txtsdST.Size = new System.Drawing.Size(100, 20);
            this.txtsdST.TabIndex = 5;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(187, 180);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(83, 31);
            this.btnDegistir.TabIndex = 6;
            this.btnDegistir.Text = "DEGİSTİR";
            this.btnDegistir.UseVisualStyleBackColor = true;
            // 
            // btnGERİ
            // 
            this.btnGERİ.Location = new System.Drawing.Point(29, 180);
            this.btnGERİ.Name = "btnGERİ";
            this.btnGERİ.Size = new System.Drawing.Size(81, 31);
            this.btnGERİ.TabIndex = 7;
            this.btnGERİ.Text = "GERİ";
            this.btnGERİ.UseVisualStyleBackColor = true;
            this.btnGERİ.Click += new System.EventHandler(this.btnGERİ_Click);
            // 
            // FormSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(309, 223);
            this.Controls.Add(this.btnGERİ);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtsdST);
            this.Controls.Add(this.txtsdS);
            this.Controls.Add(this.txtsdID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSifreDegistir";
            this.Text = "Sifre Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsdID;
        private System.Windows.Forms.TextBox txtsdS;
        private System.Windows.Forms.TextBox txtsdST;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnGERİ;
    }
}