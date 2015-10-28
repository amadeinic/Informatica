namespace StringaDiConnessione
{
    partial class frmMain
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
            this.btnFaiQualcosa = new System.Windows.Forms.Button();
            this.dgvSchermo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchermo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFaiQualcosa
            // 
            this.btnFaiQualcosa.Location = new System.Drawing.Point(12, 12);
            this.btnFaiQualcosa.Name = "btnFaiQualcosa";
            this.btnFaiQualcosa.Size = new System.Drawing.Size(178, 35);
            this.btnFaiQualcosa.TabIndex = 0;
            this.btnFaiQualcosa.Text = "Connetti e visualizza...";
            this.btnFaiQualcosa.UseVisualStyleBackColor = true;
            this.btnFaiQualcosa.Click += new System.EventHandler(this.btnFaiQualcosa_Click);
            // 
            // dgvSchermo
            // 
            this.dgvSchermo.AllowUserToAddRows = false;
            this.dgvSchermo.AllowUserToDeleteRows = false;
            this.dgvSchermo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchermo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchermo.Location = new System.Drawing.Point(12, 53);
            this.dgvSchermo.Name = "dgvSchermo";
            this.dgvSchermo.ReadOnly = true;
            this.dgvSchermo.Size = new System.Drawing.Size(675, 342);
            this.dgvSchermo.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 407);
            this.Controls.Add(this.dgvSchermo);
            this.Controls.Add(this.btnFaiQualcosa);
            this.Name = "frmMain";
            this.Text = "Esperimento DB - Nicola Amadei 2015";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchermo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFaiQualcosa;
        private System.Windows.Forms.DataGridView dgvSchermo;
    }
}

