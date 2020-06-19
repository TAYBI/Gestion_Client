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
    public partial class Fstatistique_type : Form
    {
        public Fstatistique_type()
        {
            InitializeComponent();
        }

        private void BtnFermer_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Fstatistique_type_Load(object sender, EventArgs e)
        {
            Conge C = new Conge(FMenu.C);
            C.statistique_type();
            DGV.DataSource = C.GetConnextion().dt;
        }

        private void BtnEtat_Click(object sender, EventArgs e)
        {
            new Fetat_statistique_par_type().Show();
        }
    }
}
