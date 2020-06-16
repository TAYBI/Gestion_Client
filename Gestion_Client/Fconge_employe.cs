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
    public partial class Fconge_employe : Form
    {
        public Fconge_employe()
        {
            InitializeComponent();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fconge_employe_Load(object sender, EventArgs e)
        {
            Employe E = new Employe(FMenu.C);
            E.lister();
            for (int i = 0; i < E.GetConnextion().dt.Rows.Count; i++)
                TxtMatricule.Items.Add(E.GetConnextion().dt.Rows[i][0].ToString());
        }

        private void TxtMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtMatricule.Text != "")
            {
                Employe E = new Employe(TxtMatricule.Text, FMenu.C);
                Conge C = new Conge(E, FMenu.C);
                C.conge_employe();
                DGV.DataSource = C.GetConnextion().dt;
                TxtDuree.Text = C.duree_totlal_eploye();
            }
        }
    }
}
