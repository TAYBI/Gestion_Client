namespace Gestion_Client
{
    partial class Fconge_employe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDuree = new System.Windows.Forms.TextBox();
            this.TxtMatricule = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.BtnEtat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type_congé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durée = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtDuree);
            this.groupBox1.Controls.Add(this.TxtMatricule);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnFermer);
            this.groupBox1.Controls.Add(this.BtnEtat);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 112);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Duree totale:";
            // 
            // TxtDuree
            // 
            this.TxtDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDuree.Location = new System.Drawing.Point(124, 66);
            this.TxtDuree.Name = "TxtDuree";
            this.TxtDuree.ReadOnly = true;
            this.TxtDuree.Size = new System.Drawing.Size(171, 29);
            this.TxtDuree.TabIndex = 66;
            // 
            // TxtMatricule
            // 
            this.TxtMatricule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtMatricule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMatricule.FormattingEnabled = true;
            this.TxtMatricule.Location = new System.Drawing.Point(124, 22);
            this.TxtMatricule.Name = "TxtMatricule";
            this.TxtMatricule.Size = new System.Drawing.Size(171, 32);
            this.TxtMatricule.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Matricule:";
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.Tomato;
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnFermer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnFermer.Location = new System.Drawing.Point(392, 17);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(91, 37);
            this.BtnFermer.TabIndex = 62;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BtnEtat
            // 
            this.BtnEtat.BackColor = System.Drawing.Color.White;
            this.BtnEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEtat.Location = new System.Drawing.Point(392, 60);
            this.BtnEtat.Name = "BtnEtat";
            this.BtnEtat.Size = new System.Drawing.Size(91, 37);
            this.BtnEtat.TabIndex = 61;
            this.BtnEtat.Text = "Etat";
            this.BtnEtat.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 37);
            this.label4.TabIndex = 69;
            this.label4.Text = "Liste des congés par employés";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.libellé,
            this.Type_congé,
            this.Durée});
            this.DGV.Location = new System.Drawing.Point(12, 168);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 50;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(496, 220);
            this.DGV.TabIndex = 68;
            // 
            // libellé
            // 
            this.libellé.DataPropertyName = "Date_congé";
            this.libellé.HeaderText = "Date_congé";
            this.libellé.Name = "libellé";
            this.libellé.ReadOnly = true;
            // 
            // Type_congé
            // 
            this.Type_congé.DataPropertyName = "Type_congé";
            this.Type_congé.HeaderText = "Type_congé";
            this.Type_congé.Name = "Type_congé";
            this.Type_congé.ReadOnly = true;
            // 
            // Durée
            // 
            this.Durée.DataPropertyName = "Durée";
            this.Durée.HeaderText = "Durée";
            this.Durée.Name = "Durée";
            this.Durée.ReadOnly = true;
            // 
            // Fconge_employe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 400);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "Fconge_employe";
            this.Text = "Congé par employé";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDuree;
        private System.Windows.Forms.ComboBox TxtMatricule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.Button BtnEtat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn libellé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type_congé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Durée;

    }
}