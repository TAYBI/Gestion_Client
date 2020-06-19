namespace Gestion_Client
{
    partial class Fstatistique_type
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
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_congé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durée = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 37);
            this.label4.TabIndex = 78;
            this.label4.Text = "Statistique par type";
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Tomato;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFermer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFermer.Location = new System.Drawing.Point(422, 58);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(91, 37);
            this.BtnFermer.TabIndex = 77;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BtnEtat
            // 
            this.BtnEtat.BackColor = System.Drawing.Color.White;
            this.BtnEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEtat.Location = new System.Drawing.Point(12, 58);
            this.BtnEtat.Name = "BtnEtat";
            this.BtnEtat.Size = new System.Drawing.Size(91, 37);
            this.BtnEtat.TabIndex = 76;
            this.BtnEtat.Text = "Etat";
            this.BtnEtat.UseVisualStyleBackColor = false;
            this.BtnEtat.Click += new System.EventHandler(this.BtnEtat_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Type,
            this.Nombre,
            this.Coode,
            this.libellé,
            this.Type_congé,
            this.Durée});
            this.DGV.Location = new System.Drawing.Point(12, 110);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 50;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(501, 230);
            this.DGV.TabIndex = 79;
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type_congé";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Coode
            // 
            this.Coode.DataPropertyName = "Minimum";
            this.Coode.HeaderText = "Minimum";
            this.Coode.Name = "Coode";
            this.Coode.ReadOnly = true;
            // 
            // libellé
            // 
            this.libellé.DataPropertyName = "Maximum";
            this.libellé.HeaderText = "Maximinum";
            this.libellé.Name = "libellé";
            this.libellé.ReadOnly = true;
            // 
            // Type_congé
            // 
            this.Type_congé.DataPropertyName = "Moyenne";
            this.Type_congé.HeaderText = "Moyenne";
            this.Type_congé.Name = "Type_congé";
            this.Type_congé.ReadOnly = true;
            // 
            // Durée
            // 
            this.Durée.DataPropertyName = "Total";
            this.Durée.HeaderText = "Total";
            this.Durée.Name = "Durée";
            this.Durée.ReadOnly = true;
            // 
            // Fstatistique_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 352);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnFermer);
            this.Controls.Add(this.BtnEtat);
            this.Controls.Add(this.DGV);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(541, 390);
            this.Name = "Fstatistique_type";
            this.Text = "Statistique type";
            this.Load += new System.EventHandler(this.Fstatistique_type_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Button BtnEtat;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coode;
        private System.Windows.Forms.DataGridViewTextBoxColumn libellé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_congé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durée;
    }
}