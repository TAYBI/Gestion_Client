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
    public partial class Fservice : Form
    {
        Service S;

        public void actualise()
        {
            S = new Service(FMenu.C);
            S.lister();
            DGV.DataSource = S.GetConnection().dt;
            TxtCode.Text = "";
            TxtLibelle.Text = "";
            msg.Text = "";
            TxtCode.Select();
            
        }

        public Fservice()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fservice_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void TxtCode_Leave(object sender, EventArgs e)
        {
            if (TxtCode.Text != "")
            {
                S = new Service(TxtCode.Text, FMenu.C);
                if (S.existence_code() == false)
                {
                    BtnAjouter.Enabled = true;
                    BtnModifier.Enabled = false;
                    BtnSupprimer.Enabled = false;
                }
                else
                {
                    S.rechercher_code();
                    TxtLibelle.Text = S.GetConnection().dt.Rows[0][1].ToString();
                    BtnAjouter.Enabled = false;
                    BtnModifier.Enabled = true;
                    BtnSupprimer.Enabled = true;
                }
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == "" || TxtLibelle.Text == "")
            {
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "données non valide";
                return;
            }

            msg.ForeColor = System.Drawing.Color.Green;
            S = new Service(TxtCode.Text, TxtLibelle.Text, FMenu.C);
            S.ajouter();
            actualise();
            msg.Text = "ajout  effectué";
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == "" || TxtLibelle.Text == "")
            {
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "données non valide";
                return;
            }

            msg.ForeColor = System.Drawing.Color.Green;
            S = new Service(TxtCode.Text, TxtLibelle.Text, FMenu.C);
            S.modifier();
            actualise();
            msg.Text = "modification  effectué";
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (TxtCode.Text == "")
            {
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "code non valide";
                return;
            }
            if (MessageBox.Show("Etes vous sùr de vouloir supprimer le service " + TxtCode.Text, "Confirmer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                msg.ForeColor = System.Drawing.Color.Teal;
                msg.Text = "suppression annulée";
                return;
            }
            S = new Service(TxtCode.Text, FMenu.C);
            if (S.existence_employe() == true)
            {
                msg.ForeColor = System.Drawing.Color.Red;
                msg.Text = "ce service ne peut être supprimé car il contient des employés";
                return;
            }
            S.supprimer();
            actualise();
            msg.ForeColor = System.Drawing.Color.Green;
            msg.Text = "suppression  effectué";
        }
    }
}
