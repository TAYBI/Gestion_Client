using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Client
{
    class Conge
    {
        private Employe employe;
        private DateTime date_conge;
        private String type;
        private int dure;

        private Connexion con;

        public Conge(Connexion c)
        {
            this.con = c;
        }

        public Conge(Employe emp, DateTime date, Connexion c)
        {
            this.employe = emp;
            this.date_conge = date;
            this.con = c;
        }

        public Conge(Employe emp, Connexion c)
        {
            this.employe = emp;
            this.con = c;
        }

        public Conge(Employe emp, DateTime date, String type, int dure,  Connexion c)
        {
            this.employe = emp;
            this.date_conge = date;
            this.type = type;
            this.dure = dure;
            this.con = c;
        }

        public Connexion GetConnextion()
        {
            return con;
        }

        public Boolean existance_matricule_date()
        {
            if (con.executer_valeur("SELECT COUNT(*) FROM Conge WHERE Matricule = '" +
                employe.getMatricule() + "' AND Date_congé = '" + date_conge+ "'") == "0")
                return false;
            return true;
        }

        public int ajouter()
        {
            return con.executer("INSERT INTO Conge values ('" + employe.getMatricule() + "','" + date_conge +
                "','" + type + "'," + dure + ")");
        }

        public int modifier()
        {
            return con.executer("UPDATE Conge set Durée = " + dure + ",Type_congé = '"+
                type+"'  WHERE Matricule = '" +
                employe.getMatricule() + "' AND Date_congé =  '" + date_conge + "'");
        }

        public int supprimer()
        {
            return con.executer("DELETE From Conge WHERE Matricule = '" +
                employe.getMatricule() + "' AND Date_congé =  '" + date_conge + "'");
        }

        public void lister()
        {
            con.executer_liste_deconnecte("select * from Conge");
        }

        public void recherch_matricule_date()
        {
            con.executer_liste_deconnecte("select * from Conge WHERE Matricule = '" +
                employe.getMatricule() + "' AND Date_congé =  '" + date_conge + "'");
        }

        /**************************************************************************/
        public void conge_employe()
        {
            con.executer_liste_deconnecte("SELECT Date_congé, Type_congé, Durée FROM Conge WHERE Matricule = '"+
                employe.getMatricule()+"'");
        }

        public String duree_totlal_eploye()
        {
            return con.executer_valeur("SELECT SUM(Durée) FROM Conge WHERE Matricule = '" +
                employe.getMatricule() + "'");
        }

        public void conge_periode(String d1,String d2) 
        {
            con.executer_liste_deconnecte("SELECT * FROM Conge WHERE Date_congé BETWEEN '" 
                + d1 + "' AND '" + d2 + "'");
        }

        public void statistique_type()
        {
            con.executer_liste_deconnecte("SELECT * FROM statistique_par_type");
        }

        public void statistique_durree_annee_mois()
        {
            con.executer_liste_deconnecte("SELECT * FROM durree_total_annee_mois");
        }
    }
}
