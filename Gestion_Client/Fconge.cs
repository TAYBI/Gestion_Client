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
    public partial class Fconge : Form
    {
        Conge conge;
        Employe E;

        //*******************************|| FUNCTIONS ||*******************************
        public void actualiser()
        {
            conge = new Conge(FMenu.C);
            conge.lister();
            DGV.DataSource = conge.GetConnextion().dt;
            TxtMatricule.Text = "";
            TxtDuree.Text = "";
            TxtType.Text = "";
            msg.Text = "";
            TxtConge.Text = DateTime.Today.ToShortDateString();

        }

        public void msg_error(String str)
        {
            msg.ForeColor = System.Drawing.Color.Red;
            msg.Text = str;
        }

        public void fill_matricule()
        {
            TxtMatricule.Items.Clear();

            E = new Employe(FMenu.C);
            E.lister();
            DataTable dt =  E.GetConnextion().dt;
            
            foreach (DataRow row in dt.Rows)
            {
                TxtMatricule.Items.Add(row.Field<string>(0));
            }
        }

        public void msg_success(String str)
        {
            msg.ForeColor = System.Drawing.Color.Green;
            msg.Text = str;
        }
        //******************************************************************************


        public Fconge()
        {
            InitializeComponent();
        }

        private void Fconge_Load(object sender, EventArgs e)
        {
            actualiser();
            fill_matricule();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (TxtMatricule.Text == "" || TxtConge.Text == "" || TxtDuree.Text == "" || TxtType.Text == "")
            {
                msg_error("données non valide");
                return;
            }
            E = new Employe(TxtMatricule.Text, FMenu.C);
            conge = new Conge(E, DateTime.Parse(TxtConge.Text),  TxtType.Text, int.Parse(TxtDuree.Text),
                    FMenu.C);
            conge.ajouter();
            actualiser();
            msg_success("ajout effectué");

        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (TxtMatricule.Text == "" || TxtConge.Text == "")
            {
                msg_error("matricule non valide");
                return;
            }
            if (MessageBox.Show("Etes vous sùr de vouloir supprimer l'employe "
               + TxtMatricule.Text + "a la date " + TxtConge, "Confirmer",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                msg_success("suppression annulée");
                return;
            }
            E = new Employe(TxtMatricule.Text, FMenu.C);
            conge = new Conge(E, DateTime.Parse(TxtConge.Text), FMenu.C);
            conge.supprimer();
            actualiser();
            msg_success("suppression effectué");
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (TxtMatricule.Text == "" || TxtConge.Text == "" || TxtDuree.Text == "" || TxtType.Text == "")
            {
                msg_error("données non valide");
                return;
            }
            E = new Employe(TxtMatricule.Text, FMenu.C);
            conge = new Conge(E, DateTime.Parse(TxtConge.Text), TxtType.Text, int.Parse(TxtDuree.Text),
                    FMenu.C);
            conge.modifier();
            actualiser();
            msg_success("modification effectué");
        }
    }
}
