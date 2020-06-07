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
    public partial class Femplyee : Form
    {
        Employe E;
        // ********************************************************************
        // Functions
        public void actualiser()
        {
            E = new Employe(FMenu.C);
            E.lister();
            DGV.DataSource = E.GetConnextion().dt;
            TxtMatricule.Text = "";
            TxtNom.Text = "";
            TxtPénom.Text = "";
            TxtDateNaissance.Text = "__/__/";
            TxtGrade.Text = "";
            TxtEchelle.Text = "";
            TxtCodeService.Text= "";
            TxtMatricule.Select();

            TxtCodeService.ReadOnly = false;
            msg.Text = "";

            // ----------------------------------------------------------------------------
            // HACK
            TxtDateNaissance.Enter += new System.EventHandler(this.TxtDateNaissance_Enter);
            TxtDateNaissance.Leave += new System.EventHandler(this.TxtDateNaissance_Leave);
            // ----------------------------------------------------------------------------
        }

        public Boolean Inputs_Vide()
        {
            if (TxtMatricule.Text == "" ||
            TxtNom.Text == "" ||
            TxtPénom.Text == "" ||
            TxtDateNaissance.Text == "" ||
            TxtGrade.Text == "" ||
            TxtEchelle.Text == "")
                return true;
            return false;
        }

        public void msg_error(String str)
        {
            msg.ForeColor = System.Drawing.Color.Red;
            msg.Text = str;
        }

        public void msg_success(String str)
        {
            msg.ForeColor = System.Drawing.Color.Green;
            msg.Text = str;
        }
        // ********************************************************************

        public Femplyee()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Femplyee_Load(object sender, EventArgs e)
        {
            actualiser();
        }
        

        public void RemoveText(object sender, EventArgs e)
        {
            if (TxtDateNaissance.Text == "Enter text here...") 
            {
             TxtDateNaissance.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtDateNaissance.Text))
                TxtDateNaissance.Text = "Enter text here...";
        }

        // --------------------------------------------------------------
        // HACK
        private void TxtDateNaissance_Enter(object sender, EventArgs e)
        {
            if (TxtDateNaissance.Text == "__/__/")
            {
                TxtDateNaissance.Text = "";
                TxtDateNaissance.ForeColor = SystemColors.WindowText;
            }
        }
        // --------------------------------------------------------------

        private void TxtDateNaissance_Leave(object sender, EventArgs e)
        {        
            // -----------------------------------------------------------
            // HACK
            if (TxtDateNaissance.Text.Length == 0)
            {
                TxtDateNaissance.Text = "__/__/";
                TxtDateNaissance.ForeColor = SystemColors.GrayText;
            }
            // -----------------------------------------------------------

            try
            {
                DateTime.Parse(TxtDateNaissance.Text);
                msg.Text = "";
            }
            catch
            {
                msg_error("date non valide");
                TxtDateNaissance.Select();
            }
        }

        private void TxtMatricule_Leave(object sender, EventArgs e)
        {
            if (TxtMatricule.Text != "")
            {
                E = new Employe(TxtMatricule.Text, FMenu.C);
                if (E.existance_matricule() == false)
                {
                    BtnAjouter.Enabled = true;
                    BtnSupprimer.Enabled = false;
                    BtnModifier.Enabled = false;
                }
                else
                {
                    E.rechercher_matricule();
                    TxtNom.Text = E.GetConnextion().dt.Rows[0][1].ToString();
                    TxtPénom.Text = E.GetConnextion().dt.Rows[0][2].ToString();
                    TxtDateNaissance.Text = E.GetConnextion().dt.Rows[0][3].ToString();
                    TxtGrade.Text = E.GetConnextion().dt.Rows[0][4].ToString();
                    TxtEchelle.Text = E.GetConnextion().dt.Rows[0][5].ToString();
                    TxtCodeService.Text = E.GetConnextion().dt.Rows[0][6].ToString();
                    TxtCodeService.ReadOnly = true;
                    BtnAjouter.Enabled = false;
                    BtnSupprimer.Enabled = true;
                    BtnModifier.Enabled = true;
                }
            }
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (Inputs_Vide())
            {
                msg_error("données non valide");
                return;
            }
            Service S = new Service(TxtCodeService.Text,  FMenu.C);
            E = new Employe(TxtMatricule.Text, TxtNom.Text, TxtPénom.Text, 
                            DateTime.Parse(TxtDateNaissance.Text), TxtGrade.Text, 
                            int.Parse(TxtEchelle.Text), S, FMenu.C);
            E.ajout();
            actualiser();
            msg_success("ajout  effectuée");
        }

        private void BtnModifier_Click(object sender, EventArgs e)
        {
            if (Inputs_Vide())
            {
                msg_error("données non valide");
                return;
            }
            Service S = new Service(TxtCodeService.Text,  FMenu.C);
            E = new Employe(TxtMatricule.Text, TxtNom.Text, TxtPénom.Text, 
                            DateTime.Parse(TxtDateNaissance.Text), TxtGrade.Text, 
                            int.Parse(TxtEchelle.Text), S, FMenu.C);
            E.modifier();
            actualiser();
            msg_success("modification effectuée");
        }

        private void BtnSupprimer_Click(object sender, EventArgs e)
        {
            if (TxtMatricule.Text == "")
            {
                msg_error("matricule non valide");
                return;
            }
            if (MessageBox.Show("Etes vous sùr de vouloir supprimer l'employe " 
                + TxtMatricule.Text, "Confirmer",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                msg_success("suppression annulée");
                return;
            }
            E = new Employe(TxtMatricule.Text, FMenu.C);
            E.supprimer();
            actualiser();
            msg_success("suppression effectuée");
        }

        private void TxtRecherchNom_TextChanged(object sender, EventArgs e)
        {
            E = new Employe(FMenu.C);
            E.rechercher_nom(TxtRecherchNom.Text);
            DGV.DataSource = E.GetConnextion().dt;
        }

        private void TxtRecherchNom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                E = new Employe(FMenu.C);
                E.rechercher_nom(TxtRecherchNom.Text);
                DGV.DataSource = E.GetConnextion().dt;
            }
        }

        private void TxtEchelle_Leave(object sender, EventArgs e)
        {
            try
            {
                int.Parse(TxtEchelle.Text);
                msg.Text = "";
            }
            catch
            {
                msg_error("échelle non valide");
                TxtEchelle.Select();
            }
        }
    }
}
