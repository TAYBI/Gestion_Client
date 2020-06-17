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
    public partial class Fconge_annee_mois : Form
    {
        public Fconge_annee_mois()
        {
            InitializeComponent();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fconge_annee_mois_Load(object sender, EventArgs e)
        {
            Conge C = new Conge(FMenu.C);
            C.statistique_durree_annee_mois();
            DGV.DataSource = C.GetConnextion().dt;
        }
    }
}
