namespace TestMatikProje
{
    partial class AnaForm
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
            this.bsoru = new System.Windows.Forms.Button();
            this.bders = new System.Windows.Forms.Button();
            this.bSinavHazirla = new System.Windows.Forms.Button();
            this.bhoca = new System.Windows.Forms.Button();
            this.bFakulte = new System.Windows.Forms.Button();
            this.bSinavYazdir = new System.Windows.Forms.Button();
            this.bHakkinda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsoru
            // 
            this.bsoru.Location = new System.Drawing.Point(188, 122);
            this.bsoru.Name = "bsoru";
            this.bsoru.Size = new System.Drawing.Size(170, 104);
            this.bsoru.TabIndex = 0;
            this.bsoru.Text = "SORULAR";
            this.bsoru.UseVisualStyleBackColor = true;
            this.bsoru.Click += new System.EventHandler(this.button1_Click);
            // 
            // bders
            // 
            this.bders.Location = new System.Drawing.Point(12, 125);
            this.bders.Name = "bders";
            this.bders.Size = new System.Drawing.Size(170, 104);
            this.bders.TabIndex = 1;
            this.bders.Text = "DERSLER";
            this.bders.UseVisualStyleBackColor = true;
            this.bders.Click += new System.EventHandler(this.bders_Click);
            // 
            // bSinavHazirla
            // 
            this.bSinavHazirla.Location = new System.Drawing.Point(12, 235);
            this.bSinavHazirla.Name = "bSinavHazirla";
            this.bSinavHazirla.Size = new System.Drawing.Size(170, 104);
            this.bSinavHazirla.TabIndex = 2;
            this.bSinavHazirla.Text = "SINAV HAZIRLA";
            this.bSinavHazirla.UseVisualStyleBackColor = true;
            this.bSinavHazirla.Click += new System.EventHandler(this.bSinavOlustur_Click);
            // 
            // bhoca
            // 
            this.bhoca.Location = new System.Drawing.Point(188, 12);
            this.bhoca.Name = "bhoca";
            this.bhoca.Size = new System.Drawing.Size(170, 104);
            this.bhoca.TabIndex = 3;
            this.bhoca.Text = "HOCALAR";
            this.bhoca.UseVisualStyleBackColor = true;
            this.bhoca.Click += new System.EventHandler(this.bhoca_Click);
            // 
            // bFakulte
            // 
            this.bFakulte.Location = new System.Drawing.Point(12, 12);
            this.bFakulte.Name = "bFakulte";
            this.bFakulte.Size = new System.Drawing.Size(170, 104);
            this.bFakulte.TabIndex = 4;
            this.bFakulte.Text = "FAKÜLTELER";
            this.bFakulte.UseVisualStyleBackColor = true;
            this.bFakulte.Click += new System.EventHandler(this.bFakulte_Click);
            // 
            // bSinavYazdir
            // 
            this.bSinavYazdir.Location = new System.Drawing.Point(188, 235);
            this.bSinavYazdir.Name = "bSinavYazdir";
            this.bSinavYazdir.Size = new System.Drawing.Size(170, 104);
            this.bSinavYazdir.TabIndex = 5;
            this.bSinavYazdir.Text = "SINAV YAZDIR";
            this.bSinavYazdir.UseVisualStyleBackColor = true;
            this.bSinavYazdir.Click += new System.EventHandler(this.bSinavYazdir_Click);
            // 
            // bHakkinda
            // 
            this.bHakkinda.Location = new System.Drawing.Point(12, 345);
            this.bHakkinda.Name = "bHakkinda";
            this.bHakkinda.Size = new System.Drawing.Size(346, 32);
            this.bHakkinda.TabIndex = 6;
            this.bHakkinda.Text = "HAKKINDA";
            this.bHakkinda.UseVisualStyleBackColor = true;
            this.bHakkinda.Click += new System.EventHandler(this.bHakkinda_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 386);
            this.Controls.Add(this.bHakkinda);
            this.Controls.Add(this.bSinavYazdir);
            this.Controls.Add(this.bFakulte);
            this.Controls.Add(this.bhoca);
            this.Controls.Add(this.bSinavHazirla);
            this.Controls.Add(this.bders);
            this.Controls.Add(this.bsoru);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Text = "ANA MENÜ";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bsoru;
        private System.Windows.Forms.Button bders;
        private System.Windows.Forms.Button bSinavHazirla;
        private System.Windows.Forms.Button bhoca;
        private System.Windows.Forms.Button bFakulte;
        private System.Windows.Forms.Button bSinavYazdir;
        private System.Windows.Forms.Button bHakkinda;
    }
}

