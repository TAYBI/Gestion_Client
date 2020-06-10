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
            if (con.executer_valeur("SELECT COUNT(*)  FROM Conge WHERE Matricule = '" +
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
            return con.executer("UPDATE Conge set Durée = " + dure + " WHERE Matricule = '" +
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

        public void recherch_date()
        {
            con.executer_liste_deconnecte("select * from Conge WHERE Matricule = '" +
                employe.getMatricule() + "' AND Date_congé =  '" + date_conge + "'");
        }
    }
}
