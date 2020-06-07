using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Client
{
    class Employe
    {
        private String matricule;
        private String nom;
        private String prénom;
        private DateTime date_naissance;
        private String grade;
        private int echelle;
        private Service service;

        private Connexion con;

        public Employe(Connexion con)
        {
            this.con = con;
        }

        public Employe(String matricule, Connexion con)
        {
            this.matricule = matricule;
            this.con = con;
        }

        public Employe(String matricule, String nom, String prénom, DateTime date_naissance, String grade, int echelle, Service service, Connexion con)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prénom = prénom;
            this.date_naissance = date_naissance;
            this.grade = grade;
            this.service = service; ;
            this.con = con;
        }

        public Connexion GetConnextion()
        {
            return con;
        }

        public String Getmmatiricule()
        {
            return matricule;
        }

        public Boolean existance_matricule()
        {
            if (con.executer_valeur("SELECT COUNT(*) FROM Employe WHERE Matricule = '"+matricule+"'") == "0")
                return false;
            else
                return true;
        }

        public int ajout(){
            return con.executer("insert into Employe values('"+matricule+ "','" + nom +"','" + prénom+"','"+date_naissance   + "','"+grade   + "',"+ echelle+",'"+ service.GetCode()+ "')");
        }
        public int supprimer()
        {
            return    con.executer("delete from Employe where Matricule='"+matricule+ "'");
        }

        public  int modifier(){
            return con.executer("update Employe set Nom='"+nom  +"', Prénom='"+prénom +"', Date_naissance='"+date_naissance+"',grade='"+grade+"', échelle="+echelle+", code_service='"+service.GetCode()+"' where Matricule='" + matricule+ "'");
        }
        
        public void lister(){
            con.executer_liste_deconnecte("select * from Employe");
        }
        
        public void rechercher_matricule(){
            con.executer_liste_deconnecte("select  * from Employe where Matricule='"+matricule+"'");
        }
        
        public void rechercher_nom(String nom_recherché){
            con.executer_liste_deconnecte("select  * from Employe where nom like'"+nom_recherché+ "%'");
        }
    }
}
