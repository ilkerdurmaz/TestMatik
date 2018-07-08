namespace TestMatikProje
{
    partial class Fakulteler
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bTemizle = new System.Windows.Forms.Button();
            this.bEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tFakulteAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bTemizle2 = new System.Windows.Forms.Button();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tFakulteAdi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tFakulteNoAra = new System.Windows.Forms.TextBox();
            this.tFakulteAdiAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(247, 161);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 179);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(247, 176);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bTemizle);
            this.tabPage1.Controls.Add(this.bEkle);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tFakulteAdi);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(239, 150);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fakulte Ekle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bTemizle
            // 
            this.bTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle.Location = new System.Drawing.Point(6, 116);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(227, 27);
            this.bTemizle.TabIndex = 3;
            this.bTemizle.Text = "TEMİZLE";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // bEkle
            // 
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.Location = new System.Drawing.Point(6, 83);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(227, 27);
            this.bEkle.TabIndex = 2;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "FAKÜLTE ADI:";
            // 
            // tFakulteAdi
            // 
            this.tFakulteAdi.Location = new System.Drawing.Point(6, 27);
            this.tFakulteAdi.Multiline = true;
            this.tFakulteAdi.Name = "tFakulteAdi";
            this.tFakulteAdi.Size = new System.Drawing.Size(227, 50);
            this.tFakulteAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bTemizle2);
            this.tabPage2.Controls.Add(this.bDuzenle);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tFakulteAdi2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(239, 150);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fakulte Duzenle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bTemizle2
            // 
            this.bTemizle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle2.Location = new System.Drawing.Point(6, 116);
            this.bTemizle2.Name = "bTemizle2";
            this.bTemizle2.Size = new System.Drawing.Size(227, 27);
            this.bTemizle2.TabIndex = 7;
            this.bTemizle2.Text = "TEMİZLE";
            this.bTemizle2.UseVisualStyleBackColor = true;
            this.bTemizle2.Click += new System.EventHandler(this.bTemizle2_Click);
            // 
            // bDuzenle
            // 
            this.bDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDuzenle.Location = new System.Drawing.Point(6, 83);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(227, 27);
            this.bDuzenle.TabIndex = 6;
            this.bDuzenle.Text = "DÜZENLE";
            this.bDuzenle.UseVisualStyleBackColor = true;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "FAKÜLTE ADI:";
            // 
            // tFakulteAdi2
            // 
            this.tFakulteAdi2.Location = new System.Drawing.Point(6, 27);
            this.tFakulteAdi2.Multiline = true;
            this.tFakulteAdi2.Name = "tFakulteAdi2";
            this.tFakulteAdi2.Size = new System.Drawing.Size(227, 50);
            this.tFakulteAdi2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(9, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fakülte No İle Ara:";
            // 
            // tFakulteNoAra
            // 
            this.tFakulteNoAra.Location = new System.Drawing.Point(129, 366);
            this.tFakulteNoAra.Name = "tFakulteNoAra";
            this.tFakulteNoAra.Size = new System.Drawing.Size(126, 20);
            this.tFakulteNoAra.TabIndex = 8;
            this.tFakulteNoAra.TextChanged += new System.EventHandler(this.tFakulteNoAra_TextChanged);
            // 
            // tFakulteAdiAra
            // 
            this.tFakulteAdiAra.Location = new System.Drawing.Point(129, 395);
            this.tFakulteAdiAra.Multiline = true;
            this.tFakulteAdiAra.Name = "tFakulteAdiAra";
            this.tFakulteAdiAra.Size = new System.Drawing.Size(126, 81);
            this.tFakulteAdiAra.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 395);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fakülte Adı İle Ara:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 65);
            this.button1.TabIndex = 11;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSil
            // 
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.Location = new System.Drawing.Point(12, 482);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(243, 34);
            this.bSil.TabIndex = 12;
            this.bSil.Text = "Seçili Olanı Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // Fakulteler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 523);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tFakulteAdiAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tFakulteNoAra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Fakulteler";
            this.Text = "Fakülteler";
            this.Load += new System.EventHandler(this.Fakulteler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tFakulteAdi;
        private System.Windows.Forms.Button bTemizle2;
        private System.Windows.Forms.Button bDuzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tFakulteAdi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tFakulteNoAra;
        private System.Windows.Forms.TextBox tFakulteAdiAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bSil;
    }
}