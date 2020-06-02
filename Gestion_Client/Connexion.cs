using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Gestion_Client
{
    public class Connexion
    {
        private SqlConnection con;

        public Boolean Connecter()
        {
            String chaine;
            try
            {
                chaine = "Data Source=Bilal-PC;Initial Catalog=Gestion_Employe;Integrated Security=True";
                con = new SqlConnection(chaine);
                con.Open();
                return true;
            }
            catch(Exception e){
                return false;
            }
        }
    }
}
