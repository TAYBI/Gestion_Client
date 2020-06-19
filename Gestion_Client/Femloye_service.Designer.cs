namespace Gestion_Client
{
    partial class Femloye_service
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnEtat = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.echelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 37);
            this.label3.TabIndex = 17;
            this.label3.Text = "Liste des employes par service";
            // 
            // TxtCode
            // 
            this.TxtCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.FormattingEnabled = true;
            this.TxtCode.Location = new System.Drawing.Point(100, 22);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(171, 32);
            this.TxtCode.TabIndex = 64;
            this.TxtCode.SelectedIndexChanged += new System.EventHandler(this.TxtCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Code";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(494, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 62;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnEtat
            // 
            this.BtnEtat.BackColor = System.Drawing.Color.White;
            this.BtnEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEtat.Location = new System.Drawing.Point(494, 63);
            this.BtnEtat.Name = "BtnEtat";
            this.BtnEtat.Size = new System.Drawing.Size(91, 37);
            this.BtnEtat.TabIndex = 61;
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
            this.matricule,
            this.nom,
            this.prenom,
            this.date_naissance,
            this.grade,
            this.echelle});
            this.DGV.Location = new System.Drawing.Point(12, 169);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 50;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(600, 271);
            this.DGV.TabIndex = 65;
            // 
            // matricule
            // 
            this.matricule.DataPropertyName = "Matricule";
            this.matricule.HeaderText = "Matricule";
            this.matricule.Name = "matricule";
            this.matricule.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.DataPropertyName = "Nom";
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.DataPropertyName = "Prénom";
            this.prenom.HeaderText = "Prenom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // date_naissance
            // 
            this.date_naissance.DataPropertyName = "Date_naissance";
            this.date_naissance.HeaderText = "Date naissance";
            this.date_naissance.Name = "date_naissance";
            this.date_naissance.ReadOnly = true;
            // 
            // grade
            // 
            this.grade.DataPropertyName = "grade";
            this.grade.HeaderText = "Grade";
            this.grade.Name = "grade";
            this.grade.ReadOnly = true;
            // 
            // echelle
            // 
            this.echelle.DataPropertyName = "échelle";
            this.echelle.HeaderText = "Echelle";
            this.echelle.Name = "echelle";
            this.echelle.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 67;
            this.label2.Text = "Nombre: ";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(100, 66);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.ReadOnly = true;
            this.TxtNombre.Size = new System.Drawing.Size(171, 29);
            this.TxtNombre.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtNombre);
            this.groupBox1.Controls.Add(this.TxtCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.BtnEtat);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 112);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // Femloye_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 489);
            this.Name = "Femloye_service";
            this.Text = "Emloye par service";
            this.Load += new System.EventHandler(this.Femloye_service_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox TxtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnEtat;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn echelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}