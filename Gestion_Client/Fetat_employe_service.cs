using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Client
{
    public partial class Fetat_employe_service : Form
    {
        public Fetat_employe_service()
        {
            InitializeComponent();
        }

        private void Fetat_employe_service_Load(object sender, EventArgs e)
        {
            Service S = new Service(FMenu.C);
            S.lister();
            for(int i =0 ; i < S.GetConnection().dt.Rows.Count; i++)
                TxtCode.Items.Add(S.GetConnection().dt.Rows[i][0].ToString());
        }

        private void TxtCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtCode.Text != "") {
                Etat_Employe_service cr = new Etat_Employe_service();
                crystalReportViewer1.ReportSource = cr;
                cr.SetDatabaseLogon("sa", "9090ubuntu.", "BILAL-PC", "Gestion_Employe");
                crystalReportViewer1.SelectionFormula = "{Service.Code}='" + TxtCode.Text + "'";
                cr.Refresh();
            }
        }
    }
}
