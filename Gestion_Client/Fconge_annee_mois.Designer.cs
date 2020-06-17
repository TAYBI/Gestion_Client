namespace Gestion_Client
{
    partial class Fconge_annee_mois
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
            this.label4 = new System.Windows.Forms.Label();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.BtnEtat = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 74);
            this.label4.TabIndex = 82;
            this.label4.Text = "Durée des congés \r\npar année et par mois\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Tomato;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFermer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFermer.Location = new System.Drawing.Point(324, 109);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(91, 37);
            this.BtnFermer.TabIndex = 81;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BtnEtat
            // 
            this.BtnEtat.BackColor = System.Drawing.Color.White;
            this.BtnEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEtat.Location = new System.Drawing.Point(12, 109);
            this.BtnEtat.Name = "BtnEtat";
            this.BtnEtat.Size = new System.Drawing.Size(91, 37);
            this.BtnEtat.TabIndex = 80;
            this.BtnEtat.Text = "Etat";
            this.BtnEtat.UseVisualStyleBackColor = false;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Type,
            this.Coode});
            this.DGV.Location = new System.Drawing.Point(12, 152);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 50;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(403, 231);
            this.DGV.TabIndex = 83;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Annee";
            this.Nombre.HeaderText = "Année";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Mois";
            this.Type.HeaderText = "Mois";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Coode
            // 
            this.Coode.DataPropertyName = "Total";
            this.Coode.HeaderText = "Durée totale";
            this.Coode.Name = "Coode";
            this.Coode.ReadOnly = true;
            // 
            // Fconge_annee_mois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(427, 395);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnEtat);
            this.Controls.Add(this.DGV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(443, 433);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 433);
            this.Name = "Fconge_annee_mois";
            this.Text = "Congé par année et par mois";
            this.Load += new System.EventHandler(this.Fconge_annee_mois_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Button BtnEtat;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coode;
    }
}