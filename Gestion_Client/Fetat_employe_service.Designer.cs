namespace Gestion_Client
{
    partial class Fetat_employe_service
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TxtCode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Etat_Employe_service1 = new Gestion_Client.Etat_Employe_service();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 50);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(699, 377);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // TxtCode
            // 
            this.TxtCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.FormattingEnabled = true;
            this.TxtCode.Location = new System.Drawing.Point(298, 10);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(171, 32);
            this.TxtCode.TabIndex = 66;
            this.TxtCode.SelectedIndexChanged += new System.EventHandler(this.TxtCode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 65;
            this.label1.Text = "Code:";
            // 
            // Fetat_employe_service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(723, 439);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(739, 477);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(739, 477);
            this.Name = "Fetat_employe_service";
            this.Text = "Fetat_employe_service";
            this.Load += new System.EventHandler(this.Fetat_employe_service_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox TxtCode;
        private System.Windows.Forms.Label label1;
        private Etat_Employe_service Etat_Employe_service1;
    }
}