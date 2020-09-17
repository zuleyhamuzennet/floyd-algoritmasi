namespace Floyd
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDugumSayisi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Enabled = false;
            this.btnHesapla.Location = new System.Drawing.Point(140, 73);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(104, 23);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Sonucu Göster";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnOlustur
            // 
            this.btnOlustur.Location = new System.Drawing.Point(30, 73);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(104, 23);
            this.btnOlustur.TabIndex = 8;
            this.btnOlustur.Text = "Matris Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Düğüm Sayısı:";
            // 
            // txtDugumSayisi
            // 
            this.txtDugumSayisi.Location = new System.Drawing.Point(123, 21);
            this.txtDugumSayisi.Name = "txtDugumSayisi";
            this.txtDugumSayisi.Size = new System.Drawing.Size(98, 20);
            this.txtDugumSayisi.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 123);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDugumSayisi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDugumSayisi;
    }
}

