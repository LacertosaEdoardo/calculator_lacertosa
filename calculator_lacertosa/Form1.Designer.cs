namespace calculator_lacertosa
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_result = new System.Windows.Forms.Label();
            this.lblCronologi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_result
            // 
            this.lbl_result.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_result.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(0, 32);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(316, 69);
            this.lbl_result.TabIndex = 4;
            this.lbl_result.Text = "0";
            this.lbl_result.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCronologi
            // 
            this.lblCronologi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCronologi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronologi.Location = new System.Drawing.Point(0, 0);
            this.lblCronologi.Name = "lblCronologi";
            this.lblCronologi.Size = new System.Drawing.Size(316, 32);
            this.lblCronologi.TabIndex = 3;
            this.lblCronologi.Text = "gg";
            this.lblCronologi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 475);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lblCronologi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Label lblCronologi;
    }
}

