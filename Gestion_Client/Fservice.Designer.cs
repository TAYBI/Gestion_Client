namespace Gestion_Client
{
    partial class Fservice
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
            this.button2 = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.Coode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msg = new System.Windows.Forms.Label();
            this.BtnEtat = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.TxtLibelle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLibellefghf = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(161, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 39);
            this.label3.TabIndex = 8;
            this.label3.Text = "Service";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(313, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 37);
            this.button2.TabIndex = 10;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.White;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.Location = new System.Drawing.Point(313, 205);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(123, 37);
            this.BtnModifier.TabIndex = 11;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.White;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.Location = new System.Drawing.Point(313, 162);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(123, 37);
            this.BtnSupprimer.TabIndex = 12;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coode,
            this.libellé});
            this.DGV.Location = new System.Drawing.Point(28, 162);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 50;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(273, 123);
            this.DGV.TabIndex = 18;
            // 
            // Coode
            // 
            this.Coode.DataPropertyName = "Code";
            this.Coode.HeaderText = "Code";
            this.Coode.Name = "Coode";
            this.Coode.ReadOnly = true;
            // 
            // libellé
            // 
            this.libellé.DataPropertyName = "libellé";
            this.libellé.HeaderText = "libellé";
            this.libellé.Name = "libellé";
            this.libellé.ReadOnly = true;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.ForeColor = System.Drawing.Color.Green;
            this.msg.Location = new System.Drawing.Point(179, 307);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(0, 13);
            this.msg.TabIndex = 19;
            // 
            // BtnEtat
            // 
            this.BtnEtat.BackColor = System.Drawing.Color.White;
            this.BtnEtat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEtat.Location = new System.Drawing.Point(313, 76);
            this.BtnEtat.Name = "BtnEtat";
            this.BtnEtat.Size = new System.Drawing.Size(123, 37);
            this.BtnEtat.TabIndex = 9;
            this.BtnEtat.Text = "Etat";
            this.BtnEtat.UseVisualStyleBackColor = false;
            this.BtnEtat.Click += new System.EventHandler(this.BtnEtat_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.White;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(313, 119);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(123, 37);
            this.BtnAjouter.TabIndex = 13;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.Location = new System.Drawing.Point(95, 76);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(171, 29);
            this.TxtCode.TabIndex = 14;
            this.TxtCode.Leave += new System.EventHandler(this.TxtCode_Leave);
            // 
            // TxtLibelle
            // 
            this.TxtLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibelle.Location = new System.Drawing.Point(95, 122);
            this.TxtLibelle.Name = "TxtLibelle";
            this.TxtLibelle.Size = new System.Drawing.Size(171, 29);
            this.TxtLibelle.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
            // 
            // TxtLibellefghf
            // 
            this.TxtLibellefghf.AutoSize = true;
            this.TxtLibellefghf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLibellefghf.Location = new System.Drawing.Point(24, 125);
            this.TxtLibellefghf.Name = "TxtLibellefghf";
            this.TxtLibellefghf.Size = new System.Drawing.Size(65, 24);
            this.TxtLibellefghf.TabIndex = 17;
            this.TxtLibellefghf.Text = "Libellé";
            // 
            // Fservice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 332);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.TxtLibellefghf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtLibelle);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.BtnModifier);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnEtat);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(477, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(477, 370);
            this.Name = "Fservice";
            this.Text = "Service";
            this.Load += new System.EventHandler(this.Fservice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coode;
        private System.Windows.Forms.DataGridViewTextBoxColumn libellé;
        private System.Windows.Forms.Label msg;
        private System.Windows.Forms.Button BtnEtat;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.TextBox TxtLibelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TxtLibellefghf;
    }
}