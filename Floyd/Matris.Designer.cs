namespace Floyd
{
    partial class Matris
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
            this.pnlMatris = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMatris
            // 
            this.pnlMatris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMatris.Location = new System.Drawing.Point(0, 0);
            this.pnlMatris.Name = "pnlMatris";
            this.pnlMatris.Size = new System.Drawing.Size(800, 450);
            this.pnlMatris.TabIndex = 0;
            // 
            // Matris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMatris);
            this.Name = "Matris";
            this.Text = "Matris";
            this.Load += new System.EventHandler(this.Matris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMatris;
    }
}