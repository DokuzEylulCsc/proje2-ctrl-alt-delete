namespace Otel_Rezervasyon_Sistemi
{
    partial class FormMusteriRez
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
            this.listBoxUygunOteller = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkKlima = new System.Windows.Forms.CheckBox();
            this.checkWifi = new System.Windows.Forms.CheckBox();
            this.checkMinibar = new System.Windows.Forms.CheckBox();
            this.checkTv = new System.Windows.Forms.CheckBox();
            this.BtnRezAra = new System.Windows.Forms.Button();
            this.btnRezListele = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bilgileriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifreDegisikliğiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnRezListele);
            this.panel1.Controls.Add(this.checkTv);
            this.panel1.Controls.Add(this.BtnRezAra);
            this.panel1.Controls.Add(this.checkMinibar);
            this.panel1.Controls.Add(this.checkWifi);
            this.panel1.Controls.Add(this.checkKlima);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 200);
            this.panel1.TabIndex = 0;
            // 
            // listBoxUygunOteller
            // 
            this.listBoxUygunOteller.FormattingEnabled = true;
            this.listBoxUygunOteller.Location = new System.Drawing.Point(32, 323);
            this.listBoxUygunOteller.Name = "listBoxUygunOteller";
            this.listBoxUygunOteller.Size = new System.Drawing.Size(336, 108);
            this.listBoxUygunOteller.TabIndex = 0;
            this.listBoxUygunOteller.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uygun Oteller:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(285, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rezervasyon Paneli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Filtreleme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(33, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tarih Aralığı:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(33, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fiyat Aralığı:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(364, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Oda Tipi:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(367, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 3;
            this.label7.Text = "Oda Özelliği";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 26);
            this.textBox1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(202, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "---";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 26);
            this.textBox2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kral Dairesi",
            "Manzaralı",
            "Standart"});
            this.comboBox1.Location = new System.Drawing.Point(456, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkKlima
            // 
            this.checkKlima.AutoSize = true;
            this.checkKlima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkKlima.Location = new System.Drawing.Point(478, 112);
            this.checkKlima.Name = "checkKlima";
            this.checkKlima.Size = new System.Drawing.Size(58, 19);
            this.checkKlima.TabIndex = 9;
            this.checkKlima.Text = "Klima";
            this.checkKlima.UseVisualStyleBackColor = true;
            // 
            // checkWifi
            // 
            this.checkWifi.AutoSize = true;
            this.checkWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkWifi.Location = new System.Drawing.Point(570, 112);
            this.checkWifi.Name = "checkWifi";
            this.checkWifi.Size = new System.Drawing.Size(46, 19);
            this.checkWifi.TabIndex = 10;
            this.checkWifi.Text = "Wifi";
            this.checkWifi.UseVisualStyleBackColor = true;
            // 
            // checkMinibar
            // 
            this.checkMinibar.AutoSize = true;
            this.checkMinibar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkMinibar.Location = new System.Drawing.Point(478, 144);
            this.checkMinibar.Name = "checkMinibar";
            this.checkMinibar.Size = new System.Drawing.Size(68, 19);
            this.checkMinibar.TabIndex = 11;
            this.checkMinibar.Text = "Minibar";
            this.checkMinibar.UseVisualStyleBackColor = true;
            // 
            // checkTv
            // 
            this.checkTv.AutoSize = true;
            this.checkTv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkTv.Location = new System.Drawing.Point(570, 144);
            this.checkTv.Name = "checkTv";
            this.checkTv.Size = new System.Drawing.Size(38, 19);
            this.checkTv.TabIndex = 12;
            this.checkTv.Text = "Tv";
            this.checkTv.UseVisualStyleBackColor = true;
            // 
            // BtnRezAra
            // 
            this.BtnRezAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnRezAra.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnRezAra.Location = new System.Drawing.Point(628, 78);
            this.BtnRezAra.Name = "BtnRezAra";
            this.BtnRezAra.Size = new System.Drawing.Size(133, 42);
            this.BtnRezAra.TabIndex = 4;
            this.BtnRezAra.Text = "Rezervasyon Ara";
            this.BtnRezAra.UseVisualStyleBackColor = true;
            // 
            // btnRezListele
            // 
            this.btnRezListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRezListele.Location = new System.Drawing.Point(628, 144);
            this.btnRezListele.Name = "btnRezListele";
            this.btnRezListele.Size = new System.Drawing.Size(133, 39);
            this.btnRezListele.TabIndex = 5;
            this.btnRezListele.Text = "Önceki Rez. Listele";
            this.btnRezListele.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(416, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Önceki Rezervasyonlar:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(419, 323);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(354, 108);
            this.listBox1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilgileriGüncelleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bilgileriGüncelleToolStripMenuItem
            // 
            this.bilgileriGüncelleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sifreDegisikliğiToolStripMenuItem});
            this.bilgileriGüncelleToolStripMenuItem.Name = "bilgileriGüncelleToolStripMenuItem";
            this.bilgileriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.bilgileriGüncelleToolStripMenuItem.Text = "Bilgileri Güncelle";
            // 
            // sifreDegisikliğiToolStripMenuItem
            // 
            this.sifreDegisikliğiToolStripMenuItem.Name = "sifreDegisikliğiToolStripMenuItem";
            this.sifreDegisikliğiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sifreDegisikliğiToolStripMenuItem.Text = "Sifre Degisikliği";
            // 
            // FormMusteriRez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUygunOteller);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMusteriRez";
            this.Text = "FormMusteriRez";
            this.Load += new System.EventHandler(this.FormMusteriRez_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxUygunOteller;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkTv;
        private System.Windows.Forms.CheckBox checkMinibar;
        private System.Windows.Forms.CheckBox checkWifi;
        private System.Windows.Forms.CheckBox checkKlima;
        private System.Windows.Forms.Button btnRezListele;
        private System.Windows.Forms.Button BtnRezAra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bilgileriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifreDegisikliğiToolStripMenuItem;
    }
}