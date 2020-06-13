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
    public partial class Femloye_service : Form
    {
        public Femloye_service()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Femloye_service_Load(object sender, EventArgs e)
        {
            Service s = new Service(FMenu.C);
            s.lister();
            for (int i = 0; i < s.GetConnection().dt.Rows.Count; i++)
                TxtCode.Items.Add(s.GetConnection().dt.Rows[i][0].ToString());
        }

        private void TxtCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtCode.Text != "")
            {
                Service s = new Service(TxtCode.Text, FMenu.C);
                Employe E = new Employe(s, FMenu.C);
                E.employe_service();
                DGV.DataSource = E.GetConnextion().dt;
                TxtNombre.Text = E.nbre_employé_service(); ;
            }
        }
    }
}
