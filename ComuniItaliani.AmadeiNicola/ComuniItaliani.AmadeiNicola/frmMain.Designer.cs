namespace ComuniItaliani.AmadeiNicola
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
            this.cmbSceltaQuery = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInterroga = new System.Windows.Forms.Button();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCaricaComuni = new System.Windows.Forms.Button();
            this.btnCaricaRegioni = new System.Windows.Forms.Button();
            this.lstSchermo = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSceltaQuery
            // 
            this.cmbSceltaQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSceltaQuery.FormattingEnabled = true;
            this.cmbSceltaQuery.Items.AddRange(new object[] {
            "Per nome completo [com]",
            "Per nome parziale [com]",
            "Per regione [reg]",
            "Somma abitanti regione [reg]",
            "Comune più popoloso regione [reg]"});
            this.cmbSceltaQuery.Location = new System.Drawing.Point(71, 17);
            this.cmbSceltaQuery.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbSceltaQuery.Name = "cmbSceltaQuery";
            this.cmbSceltaQuery.Size = new System.Drawing.Size(189, 21);
            this.cmbSceltaQuery.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInterroga);
            this.groupBox1.Controls.Add(this.txtParametro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSceltaQuery);
            this.groupBox1.Location = new System.Drawing.Point(9, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(264, 106);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ricerca";
            // 
            // btnInterroga
            // 
            this.btnInterroga.Location = new System.Drawing.Point(7, 70);
            this.btnInterroga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInterroga.Name = "btnInterroga";
            this.btnInterroga.Size = new System.Drawing.Size(253, 31);
            this.btnInterroga.TabIndex = 4;
            this.btnInterroga.Text = "Esegui query";
            this.btnInterroga.UseVisualStyleBackColor = true;
            this.btnInterroga.Click += new System.EventHandler(this.btnInterroga_Click);
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(71, 42);
            this.txtParametro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(189, 20);
            this.txtParametro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parametro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo ricerca";
            // 
            // btnCaricaComuni
            // 
            this.btnCaricaComuni.Location = new System.Drawing.Point(9, 11);
            this.btnCaricaComuni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaricaComuni.Name = "btnCaricaComuni";
            this.btnCaricaComuni.Size = new System.Drawing.Size(92, 25);
            this.btnCaricaComuni.TabIndex = 2;
            this.btnCaricaComuni.Text = "Carica comuni";
            this.btnCaricaComuni.UseVisualStyleBackColor = true;
            this.btnCaricaComuni.Click += new System.EventHandler(this.btnCaricaComuni_Click);
            // 
            // btnCaricaRegioni
            // 
            this.btnCaricaRegioni.Location = new System.Drawing.Point(105, 11);
            this.btnCaricaRegioni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaricaRegioni.Name = "btnCaricaRegioni";
            this.btnCaricaRegioni.Size = new System.Drawing.Size(92, 25);
            this.btnCaricaRegioni.TabIndex = 3;
            this.btnCaricaRegioni.Text = "Carica regioni";
            this.btnCaricaRegioni.UseVisualStyleBackColor = true;
            this.btnCaricaRegioni.Click += new System.EventHandler(this.btnCaricaRegioni_Click);
            // 
            // lstSchermo
            // 
            this.lstSchermo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSchermo.FormattingEnabled = true;
            this.lstSchermo.ItemHeight = 15;
            this.lstSchermo.Location = new System.Drawing.Point(277, 11);
            this.lstSchermo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSchermo.Name = "lstSchermo";
            this.lstSchermo.Size = new System.Drawing.Size(459, 199);
            this.lstSchermo.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 217);
            this.Controls.Add(this.lstSchermo);
            this.Controls.Add(this.btnCaricaRegioni);
            this.Controls.Add(this.btnCaricaComuni);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Comuni Italiani - Nicola Amadei 2015";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSceltaQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInterroga;
        private System.Windows.Forms.TextBox txtParametro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCaricaComuni;
        private System.Windows.Forms.Button btnCaricaRegioni;
        private System.Windows.Forms.ListBox lstSchermo;
    }
}

