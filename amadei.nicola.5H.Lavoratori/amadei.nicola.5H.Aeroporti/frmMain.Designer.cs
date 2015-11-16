namespace amadei.nicola._5H.Aeroporti
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dgvSchermo = new System.Windows.Forms.DataGridView();
            this.lblVolo = new System.Windows.Forms.Label();
            this.lblAeroporto1 = new System.Windows.Forms.Label();
            this.lblAeroporto2 = new System.Windows.Forms.Label();
            this.txtVolo = new System.Windows.Forms.TextBox();
            this.txtAero1 = new System.Windows.Forms.TextBox();
            this.txtAero2 = new System.Windows.Forms.TextBox();
            this.btnCerca = new System.Windows.Forms.Button();
            this.cmbModalita = new System.Windows.Forms.ComboBox();
            this.lblModalita = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchermo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSchermo
            // 
            this.dgvSchermo.AllowUserToAddRows = false;
            this.dgvSchermo.AllowUserToDeleteRows = false;
            this.dgvSchermo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchermo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchermo.Location = new System.Drawing.Point(12, 105);
            this.dgvSchermo.Name = "dgvSchermo";
            this.dgvSchermo.ReadOnly = true;
            this.dgvSchermo.RowTemplate.Height = 24;
            this.dgvSchermo.Size = new System.Drawing.Size(658, 351);
            this.dgvSchermo.TabIndex = 0;
            // 
            // lblVolo
            // 
            this.lblVolo.AutoSize = true;
            this.lblVolo.Location = new System.Drawing.Point(12, 13);
            this.lblVolo.Name = "lblVolo";
            this.lblVolo.Size = new System.Drawing.Size(69, 17);
            this.lblVolo.TabIndex = 1;
            this.lblVolo.Text = "Cod. Volo";
            // 
            // lblAeroporto1
            // 
            this.lblAeroporto1.AutoSize = true;
            this.lblAeroporto1.Location = new System.Drawing.Point(12, 52);
            this.lblAeroporto1.Name = "lblAeroporto1";
            this.lblAeroporto1.Size = new System.Drawing.Size(149, 17);
            this.lblAeroporto1.TabIndex = 2;
            this.lblAeroporto1.Text = "Cod. Aeroporto PART.";
            // 
            // lblAeroporto2
            // 
            this.lblAeroporto2.AutoSize = true;
            this.lblAeroporto2.Location = new System.Drawing.Point(12, 80);
            this.lblAeroporto2.Name = "lblAeroporto2";
            this.lblAeroporto2.Size = new System.Drawing.Size(149, 17);
            this.lblAeroporto2.TabIndex = 3;
            this.lblAeroporto2.Text = "Cod. Aeroporto DEST.";
            // 
            // txtVolo
            // 
            this.txtVolo.Location = new System.Drawing.Point(167, 10);
            this.txtVolo.Name = "txtVolo";
            this.txtVolo.Size = new System.Drawing.Size(100, 22);
            this.txtVolo.TabIndex = 4;
            // 
            // txtAero1
            // 
            this.txtAero1.Location = new System.Drawing.Point(167, 49);
            this.txtAero1.Name = "txtAero1";
            this.txtAero1.Size = new System.Drawing.Size(100, 22);
            this.txtAero1.TabIndex = 5;
            // 
            // txtAero2
            // 
            this.txtAero2.Location = new System.Drawing.Point(167, 77);
            this.txtAero2.Name = "txtAero2";
            this.txtAero2.Size = new System.Drawing.Size(100, 22);
            this.txtAero2.TabIndex = 6;
            // 
            // btnCerca
            // 
            this.btnCerca.Location = new System.Drawing.Point(485, 40);
            this.btnCerca.Name = "btnCerca";
            this.btnCerca.Size = new System.Drawing.Size(185, 59);
            this.btnCerca.TabIndex = 7;
            this.btnCerca.Text = "Cerca";
            this.btnCerca.UseVisualStyleBackColor = true;
            this.btnCerca.Click += new System.EventHandler(this.btnCerca_Click);
            // 
            // cmbModalita
            // 
            this.cmbModalita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModalita.FormattingEnabled = true;
            this.cmbModalita.Items.AddRange(new object[] {
            "Cerca volo",
            "Voli in partenza",
            "Cerca viaggio"});
            this.cmbModalita.Location = new System.Drawing.Point(549, 10);
            this.cmbModalita.Name = "cmbModalita";
            this.cmbModalita.Size = new System.Drawing.Size(121, 24);
            this.cmbModalita.TabIndex = 8;
            this.cmbModalita.SelectedIndexChanged += new System.EventHandler(this.cmbModalita_SelectedIndexChanged);
            // 
            // lblModalita
            // 
            this.lblModalita.AutoSize = true;
            this.lblModalita.Location = new System.Drawing.Point(482, 13);
            this.lblModalita.Name = "lblModalita";
            this.lblModalita.Size = new System.Drawing.Size(61, 17);
            this.lblModalita.TabIndex = 9;
            this.lblModalita.Text = "Modalità";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 468);
            this.Controls.Add(this.lblModalita);
            this.Controls.Add(this.cmbModalita);
            this.Controls.Add(this.btnCerca);
            this.Controls.Add(this.txtAero2);
            this.Controls.Add(this.txtAero1);
            this.Controls.Add(this.txtVolo);
            this.Controls.Add(this.lblAeroporto2);
            this.Controls.Add(this.lblAeroporto1);
            this.Controls.Add(this.lblVolo);
            this.Controls.Add(this.dgvSchermo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Aeroporti ICAO - Nicola Amadei 2015";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchermo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchermo;
        private System.Windows.Forms.Label lblVolo;
        private System.Windows.Forms.Label lblAeroporto1;
        private System.Windows.Forms.Label lblAeroporto2;
        private System.Windows.Forms.TextBox txtVolo;
        private System.Windows.Forms.TextBox txtAero1;
        private System.Windows.Forms.TextBox txtAero2;
        private System.Windows.Forms.Button btnCerca;
        private System.Windows.Forms.ComboBox cmbModalita;
        private System.Windows.Forms.Label lblModalita;
    }
}

