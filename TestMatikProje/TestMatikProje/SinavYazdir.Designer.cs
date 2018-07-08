namespace TestMatikProje
{
    partial class SinavYazdir
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tSinavAdiAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bListele = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            this.bYazdir = new System.Windows.Forms.Button();
            this.lbCevapAnahtari = new System.Windows.Forms.ListBox();
            this.bAnahtarYaz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SINAVLAR";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 295);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(219, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(341, 264);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarihe Göre Listele:";
            // 
            // tSinavAdiAra
            // 
            this.tSinavAdiAra.Location = new System.Drawing.Point(169, 324);
            this.tSinavAdiAra.Name = "tSinavAdiAra";
            this.tSinavAdiAra.Size = new System.Drawing.Size(187, 20);
            this.tSinavAdiAra.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sınav Adına Göre Listele:";
            // 
            // bListele
            // 
            this.bListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bListele.Location = new System.Drawing.Point(12, 350);
            this.bListele.Name = "bListele";
            this.bListele.Size = new System.Drawing.Size(344, 47);
            this.bListele.TabIndex = 5;
            this.bListele.Text = "Listele";
            this.bListele.UseVisualStyleBackColor = true;
            this.bListele.Click += new System.EventHandler(this.bListele_Click);
            // 
            // bSil
            // 
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.Location = new System.Drawing.Point(12, 403);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(344, 47);
            this.bSil.TabIndex = 8;
            this.bSil.Text = "Seçili Sınavı Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // bYazdir
            // 
            this.bYazdir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bYazdir.Location = new System.Drawing.Point(12, 456);
            this.bYazdir.Name = "bYazdir";
            this.bYazdir.Size = new System.Drawing.Size(344, 55);
            this.bYazdir.TabIndex = 9;
            this.bYazdir.Text = "Seçili Sınavı Yazdır";
            this.bYazdir.UseVisualStyleBackColor = true;
            this.bYazdir.Click += new System.EventHandler(this.bYazdir_Click);
            // 
            // lbCevapAnahtari
            // 
            this.lbCevapAnahtari.FormattingEnabled = true;
            this.lbCevapAnahtari.Location = new System.Drawing.Point(362, 156);
            this.lbCevapAnahtari.Name = "lbCevapAnahtari";
            this.lbCevapAnahtari.Size = new System.Drawing.Size(82, 355);
            this.lbCevapAnahtari.TabIndex = 11;
            // 
            // bAnahtarYaz
            // 
            this.bAnahtarYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAnahtarYaz.Location = new System.Drawing.Point(362, 25);
            this.bAnahtarYaz.Name = "bAnahtarYaz";
            this.bAnahtarYaz.Size = new System.Drawing.Size(82, 118);
            this.bAnahtarYaz.TabIndex = 12;
            this.bAnahtarYaz.Text = "Seçili Sınavın Cevap Anahtarını Text Dosyasına Kaydet";
            this.bAnahtarYaz.UseVisualStyleBackColor = true;
            this.bAnahtarYaz.Click += new System.EventHandler(this.bAnahtarYaz_Click);
            // 
            // SinavYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 523);
            this.Controls.Add(this.bAnahtarYaz);
            this.Controls.Add(this.lbCevapAnahtari);
            this.Controls.Add(this.bYazdir);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tSinavAdiAra);
            this.Controls.Add(this.bListele);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SinavYazdir";
            this.Text = "Sınav Yazdır";
            this.Load += new System.EventHandler(this.SinavYazdir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tSinavAdiAra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bListele;
        private System.Windows.Forms.Button bSil;
        private System.Windows.Forms.Button bYazdir;
        private System.Windows.Forms.ListBox lbCevapAnahtari;
        private System.Windows.Forms.Button bAnahtarYaz;
    }
}