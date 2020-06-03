using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Client
{
    class Service
    {
        private String code;
        private String libellé;
        private Connexion con;   //objet  de la classe connexion
        
        //constructeur qui initialise la connexion seulement utilisé pour un select sans condition(where)
        public Service(Connexion con){
            this.con=con;
        }
        
        //constructeur qui initialise la clé primaire et la connexion utilisé pourla suppression 
        public Service(String code, Connexion con){
            this.code  = code;
            this.con = con;
        }
        
        //constructeur qui initialise toutes les données et la connexion utilisé pourl'ajout  et la modification 
        public Service(String code, String libellé, Connexion con){
            this.code  = code; 
            this.libellé = libellé;
            this.con = con;
        }

        public Connexion GetConnection()
        {
            return con;
        }

        public String GetCode()
        {
            return code;
        }

        public Boolean existence_code()
        {
            if (con.executer_valeur("select count(*) from Service where code ='" + code + "'") == "0")
                return false;
            else
                return true;
        }

        //existence de la clé étrangère dans la table employé car on ne peut pas supprimer un service
        //qui a des employés
        public Boolean existence_employe()
        {
            if (con.executer_valeur("select count(*) from Employe where code_service = '" + code + "'") == "0")
                return false;
            else
                return true;
        }

        public int ajouter()
        {
            return con.executer("INSERT INTO Service VALUES('"+code+"','"+ libellé+"')");
        }

        public int supprimer()
        {
            return con.executer("DELETE FROM Service WHERE code = '" + code + "'");
        }

        public int modifier()
        {
            return con.executer("UPDATE Service set libellé = '"+libellé+"' WHERE code = '"+code+"'");
        }

        public void lister()
        {
            con.executer_liste_deconnecte("SELECT * FROM Service");
        }

        public void rechercher_code()
        {
            con.executer_liste_deconnecte("SELECT * FROM Service WHERE code='" + code + "'");
        }
    }
}
