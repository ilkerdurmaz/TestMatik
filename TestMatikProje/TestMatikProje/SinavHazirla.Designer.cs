namespace TestMatikProje
{
    partial class SinavHazirla
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bEkle = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tSoruAra = new System.Windows.Forms.TextBox();
            this.bAra = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tSoruNoAra = new System.Windows.Forms.TextBox();
            this.cbZorluk = new System.Windows.Forms.ComboBox();
            this.cbDers = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bListele = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.bKaydet = new System.Windows.Forms.Button();
            this.tSinavAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.laSoruSayisi = new System.Windows.Forms.Label();
            this.bMiktarlaSoruEkle = new System.Windows.Forms.Button();
            this.rbTek = new System.Windows.Forms.RadioButton();
            this.rbAlfa = new System.Windows.Forms.RadioButton();
            this.rbNum = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.tGrup = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(419, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(516, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(419, 409);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SORU BANKASI:";
            // 
            // bEkle
            // 
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.Location = new System.Drawing.Point(440, 48);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(75, 92);
            this.bEkle.TabIndex = 3;
            this.bEkle.Text = "Seçili Soruyu Ekle";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // bSil
            // 
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.Location = new System.Drawing.Point(521, 440);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(415, 40);
            this.bSil.TabIndex = 5;
            this.bSil.Text = "Seçili Olan Soruyu Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(518, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SINAV SORULARI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Soru İle Ara:";
            // 
            // tSoruAra
            // 
            this.tSoruAra.Location = new System.Drawing.Point(12, 468);
            this.tSoruAra.Multiline = true;
            this.tSoruAra.Name = "tSoruAra";
            this.tSoruAra.Size = new System.Drawing.Size(280, 59);
            this.tSoruAra.TabIndex = 12;
            // 
            // bAra
            // 
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.Location = new System.Drawing.Point(303, 468);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(131, 59);
            this.bAra.TabIndex = 13;
            this.bAra.Text = "Soru İle Ara";
            this.bAra.UseVisualStyleBackColor = true;
            this.bAra.Click += new System.EventHandler(this.bAra_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(9, 600);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 79;
            this.label18.Text = "Soru No İle Ara : ";
            // 
            // tSoruNoAra
            // 
            this.tSoruNoAra.Location = new System.Drawing.Point(121, 597);
            this.tSoruNoAra.Name = "tSoruNoAra";
            this.tSoruNoAra.Size = new System.Drawing.Size(171, 20);
            this.tSoruNoAra.TabIndex = 78;
            this.tSoruNoAra.TextChanged += new System.EventHandler(this.tSoruNoAra_TextChanged);
            // 
            // cbZorluk
            // 
            this.cbZorluk.FormattingEnabled = true;
            this.cbZorluk.Items.AddRange(new object[] {
            "Kolay",
            "Orta",
            "Zor"});
            this.cbZorluk.Location = new System.Drawing.Point(78, 565);
            this.cbZorluk.Name = "cbZorluk";
            this.cbZorluk.Size = new System.Drawing.Size(214, 21);
            this.cbZorluk.TabIndex = 77;
            // 
            // cbDers
            // 
            this.cbDers.FormattingEnabled = true;
            this.cbDers.Location = new System.Drawing.Point(78, 542);
            this.cbDers.Name = "cbDers";
            this.cbDers.Size = new System.Drawing.Size(214, 21);
            this.cbDers.TabIndex = 76;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(9, 569);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(73, 13);
            this.label22.TabIndex = 75;
            this.label22.Text = "Zorluk İle : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(9, 545);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 13);
            this.label21.TabIndex = 74;
            this.label21.Text = "Ders İle : ";
            // 
            // bListele
            // 
            this.bListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bListele.Location = new System.Drawing.Point(303, 542);
            this.bListele.Name = "bListele";
            this.bListele.Size = new System.Drawing.Size(131, 44);
            this.bListele.TabIndex = 80;
            this.bListele.Text = "Listele";
            this.bListele.UseVisualStyleBackColor = true;
            this.bListele.Click += new System.EventHandler(this.bListele_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle.Location = new System.Drawing.Point(303, 592);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(131, 25);
            this.bTemizle.TabIndex = 81;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            // 
            // bKaydet
            // 
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.Location = new System.Drawing.Point(521, 527);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(201, 90);
            this.bKaydet.TabIndex = 82;
            this.bKaydet.Text = "Sınavı Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // tSinavAdi
            // 
            this.tSinavAdi.Location = new System.Drawing.Point(589, 501);
            this.tSinavAdi.Name = "tSinavAdi";
            this.tSinavAdi.Size = new System.Drawing.Size(347, 20);
            this.tSinavAdi.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(518, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "Sınav Adı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(440, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Soru Sayısı";
            // 
            // laSoruSayisi
            // 
            this.laSoruSayisi.AutoSize = true;
            this.laSoruSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.laSoruSayisi.Location = new System.Drawing.Point(459, 323);
            this.laSoruSayisi.Name = "laSoruSayisi";
            this.laSoruSayisi.Size = new System.Drawing.Size(30, 31);
            this.laSoruSayisi.TabIndex = 86;
            this.laSoruSayisi.Text = "0";
            // 
            // bMiktarlaSoruEkle
            // 
            this.bMiktarlaSoruEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bMiktarlaSoruEkle.Location = new System.Drawing.Point(440, 146);
            this.bMiktarlaSoruEkle.Name = "bMiktarlaSoruEkle";
            this.bMiktarlaSoruEkle.Size = new System.Drawing.Size(75, 92);
            this.bMiktarlaSoruEkle.TabIndex = 87;
            this.bMiktarlaSoruEkle.Text = "Belirli Miktarda Soru Ekle";
            this.bMiktarlaSoruEkle.UseVisualStyleBackColor = true;
            this.bMiktarlaSoruEkle.Click += new System.EventHandler(this.bMiktarlaSoruEkle_Click);
            // 
            // rbTek
            // 
            this.rbTek.AutoSize = true;
            this.rbTek.Checked = true;
            this.rbTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTek.Location = new System.Drawing.Point(728, 527);
            this.rbTek.Name = "rbTek";
            this.rbTek.Size = new System.Drawing.Size(83, 17);
            this.rbTek.TabIndex = 88;
            this.rbTek.TabStop = true;
            this.rbTek.Text = "Tek Sınav";
            this.rbTek.UseVisualStyleBackColor = true;
            this.rbTek.CheckedChanged += new System.EventHandler(this.rbTek_CheckedChanged);
            // 
            // rbAlfa
            // 
            this.rbAlfa.AutoSize = true;
            this.rbAlfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbAlfa.Location = new System.Drawing.Point(728, 573);
            this.rbAlfa.Name = "rbAlfa";
            this.rbAlfa.Size = new System.Drawing.Size(116, 17);
            this.rbAlfa.TabIndex = 89;
            this.rbAlfa.TabStop = true;
            this.rbAlfa.Text = "Alfabetik Gruplu";
            this.rbAlfa.UseVisualStyleBackColor = true;
            this.rbAlfa.CheckedChanged += new System.EventHandler(this.rbAlfa_CheckedChanged);
            // 
            // rbNum
            // 
            this.rbNum.AutoSize = true;
            this.rbNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNum.Location = new System.Drawing.Point(728, 550);
            this.rbNum.Name = "rbNum";
            this.rbNum.Size = new System.Drawing.Size(112, 17);
            this.rbNum.TabIndex = 90;
            this.rbNum.TabStop = true;
            this.rbNum.Text = "Nümerik Gruplu";
            this.rbNum.UseVisualStyleBackColor = true;
            this.rbNum.CheckedChanged += new System.EventHandler(this.rbNum_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(728, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Grup Sayısı:";
            // 
            // tGrup
            // 
            this.tGrup.Enabled = false;
            this.tGrup.Location = new System.Drawing.Point(805, 597);
            this.tGrup.Name = "tGrup";
            this.tGrup.Size = new System.Drawing.Size(100, 20);
            this.tGrup.TabIndex = 92;
            // 
            // SinavHazirla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 629);
            this.Controls.Add(this.tGrup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbNum);
            this.Controls.Add(this.rbAlfa);
            this.Controls.Add(this.rbTek);
            this.Controls.Add(this.bMiktarlaSoruEkle);
            this.Controls.Add(this.laSoruSayisi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tSinavAdi);
            this.Controls.Add(this.bKaydet);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bListele);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tSoruNoAra);
            this.Controls.Add(this.cbZorluk);
            this.Controls.Add(this.cbDers);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.bAra);
            this.Controls.Add(this.tSoruAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SinavHazirla";
            this.Text = "Sınav Hazırla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SinavOlustur_FormClosing);
            this.Load += new System.EventHandler(this.SinavHazirla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tSoruAra;
        private System.Windows.Forms.Button bAra;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tSoruNoAra;
        private System.Windows.Forms.ComboBox cbZorluk;
        private System.Windows.Forms.ComboBox cbDers;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button bListele;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Button bKaydet;
        private System.Windows.Forms.TextBox tSinavAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label laSoruSayisi;
        private System.Windows.Forms.Button bMiktarlaSoruEkle;
        private System.Windows.Forms.RadioButton rbTek;
        private System.Windows.Forms.RadioButton rbAlfa;
        private System.Windows.Forms.RadioButton rbNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tGrup;
    }
}