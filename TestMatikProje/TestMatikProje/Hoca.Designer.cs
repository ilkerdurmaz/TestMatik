namespace TestMatikProje
{
    partial class Hoca
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbFakulte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tHocaAdi = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bDuzenle = new System.Windows.Forms.Button();
            this.bTemizle2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbFakulte2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tHocaAdi2 = new System.Windows.Forms.TextBox();
            this.tHocaNoAra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tFakulteNoAra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.dataGridView1.Size = new System.Drawing.Size(342, 230);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 248);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(342, 145);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bTemizle);
            this.tabPage1.Controls.Add(this.bEkle);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cbFakulte);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tHocaAdi);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 119);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HOCA EKLE";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bTemizle
            // 
            this.bTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle.Location = new System.Drawing.Point(177, 64);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(151, 47);
            this.bTemizle.TabIndex = 5;
            this.bTemizle.Text = "TEMİZLE";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // bEkle
            // 
            this.bEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bEkle.Location = new System.Drawing.Point(6, 64);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(165, 47);
            this.bEkle.TabIndex = 4;
            this.bEkle.Text = "EKLE";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.bEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "FAKÜLTE:";
            // 
            // cbFakulte
            // 
            this.cbFakulte.FormattingEnabled = true;
            this.cbFakulte.Location = new System.Drawing.Point(82, 37);
            this.cbFakulte.Name = "cbFakulte";
            this.cbFakulte.Size = new System.Drawing.Size(246, 21);
            this.cbFakulte.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "HOCA ADI:";
            // 
            // tHocaAdi
            // 
            this.tHocaAdi.Location = new System.Drawing.Point(82, 11);
            this.tHocaAdi.Name = "tHocaAdi";
            this.tHocaAdi.Size = new System.Drawing.Size(246, 20);
            this.tHocaAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bDuzenle);
            this.tabPage2.Controls.Add(this.bTemizle2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbFakulte2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tHocaAdi2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 119);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HOCA DÜZENLE";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bDuzenle
            // 
            this.bDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bDuzenle.Location = new System.Drawing.Point(7, 64);
            this.bDuzenle.Name = "bDuzenle";
            this.bDuzenle.Size = new System.Drawing.Size(165, 47);
            this.bDuzenle.TabIndex = 16;
            this.bDuzenle.Text = "DÜZENLE";
            this.bDuzenle.UseVisualStyleBackColor = true;
            this.bDuzenle.Click += new System.EventHandler(this.bDuzenle_Click_1);
            // 
            // bTemizle2
            // 
            this.bTemizle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bTemizle2.Location = new System.Drawing.Point(178, 64);
            this.bTemizle2.Name = "bTemizle2";
            this.bTemizle2.Size = new System.Drawing.Size(150, 47);
            this.bTemizle2.TabIndex = 13;
            this.bTemizle2.Text = "TEMİZLE";
            this.bTemizle2.UseVisualStyleBackColor = true;
            this.bTemizle2.Click += new System.EventHandler(this.bTemizle2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "FAKÜLTE:";
            // 
            // cbFakulte2
            // 
            this.cbFakulte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFakulte2.FormattingEnabled = true;
            this.cbFakulte2.Location = new System.Drawing.Point(82, 37);
            this.cbFakulte2.Name = "cbFakulte2";
            this.cbFakulte2.Size = new System.Drawing.Size(246, 21);
            this.cbFakulte2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "HOCA ADI:";
            // 
            // tHocaAdi2
            // 
            this.tHocaAdi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tHocaAdi2.Location = new System.Drawing.Point(82, 11);
            this.tHocaAdi2.Name = "tHocaAdi2";
            this.tHocaAdi2.Size = new System.Drawing.Size(246, 20);
            this.tHocaAdi2.TabIndex = 8;
            // 
            // tHocaNoAra
            // 
            this.tHocaNoAra.Location = new System.Drawing.Point(121, 406);
            this.tHocaNoAra.Name = "tHocaNoAra";
            this.tHocaNoAra.Size = new System.Drawing.Size(89, 20);
            this.tHocaNoAra.TabIndex = 7;
            this.tHocaNoAra.TextChanged += new System.EventHandler(this.tHocaNoAra_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hoca No İle Ara:";
            // 
            // tFakulteNoAra
            // 
            this.tFakulteNoAra.Location = new System.Drawing.Point(133, 432);
            this.tFakulteNoAra.Name = "tFakulteNoAra";
            this.tFakulteNoAra.Size = new System.Drawing.Size(77, 20);
            this.tFakulteNoAra.TabIndex = 9;
            this.tFakulteNoAra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fakülte No İle Ara:";
            // 
            // bSil
            // 
            this.bSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bSil.Location = new System.Drawing.Point(216, 406);
            this.bSil.Name = "bSil";
            this.bSil.Size = new System.Drawing.Size(134, 47);
            this.bSil.TabIndex = 17;
            this.bSil.Text = "Seçili Olanı Sil";
            this.bSil.UseVisualStyleBackColor = true;
            this.bSil.Click += new System.EventHandler(this.bSil_Click);
            // 
            // Hoca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 464);
            this.Controls.Add(this.bSil);
            this.Controls.Add(this.tFakulteNoAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tHocaNoAra);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Hoca";
            this.Text = "Hoca";
            this.Load += new System.EventHandler(this.Hoca_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tHocaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFakulte;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.TextBox tHocaNoAra;
        private System.Windows.Forms.Button bTemizle2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbFakulte2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tHocaAdi2;
        private System.Windows.Forms.Button bDuzenle;
        private System.Windows.Forms.TextBox tFakulteNoAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bSil;
    }
}