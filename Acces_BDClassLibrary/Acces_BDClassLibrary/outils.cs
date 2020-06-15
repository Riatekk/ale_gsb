using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//librairie contenant des classes permettant l'accès à une base de données SqlServer
using System.Data;//librairie contenant des classes permettant l'utilisation de conteneurs de données : ex : Datatable
using System.Windows.Forms; //  à référencer pour MessageBox.Show 
namespace Acces_BDClassLibrary
{
    /// <summary>
    /// classe d'outils de connexion à une BD SQLserver dans une applicaton Windows
    /// </summary>
    public class outils
    {
        #region Déclaration des objets permettant de mettre en œuvre une connexion
        private static SqlConnection gObjetConnection;
        private static SqlCommand commande;
        #endregion

        /// <summary>
        /// tentative de connexion
        /// </summary>
        public static void MaConnexion()
        {
            gObjetConnection = new SqlConnection();
            //La propriété ConnectionString de notre objet gObjetConnection doit contenir les parametres de connection au serveur
            gObjetConnection.ConnectionString = "User ID= " + paramètres.myValuelogin + "; PWD= " + paramètres.myValueMdp + " ; Server= " + paramètres.myValueServer + "; Database=  " + paramètres.myValueBD + "; ";


            try //tentative (Try) d'ouverture d'une connexion avec le serveur de base de donnees 
            {
                //Ouvrir la connexion en utilisant la méthode open() sur notre projet gObjetConnection
                gObjetConnection.Open();
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {

                MessageBox.Show("Impossible de se connecter au serveur de base de données." + probleme.Message);
            }
        }
        /// <summary>
        /// pour se déconnecter
        /// </summary>
        public static void MaDeconnexion()
        {
          gObjetConnection.Close();
        }
        /// <summary>
        /// pour exécuter une requête qui ne renvoie qu'un seul résultat
        /// </summary>
        /// <param name="requete">une chaîne</param>
        /// <returns> la requête ou appel de la procédure Stockée : une chaîne</returns>
        public static String ExecuteScalar(String requete)
        {
            String resultat = null;
            try
            {
                commande = new SqlCommand(requete, gObjetConnection);
                resultat = commande.ExecuteScalar().ToString();
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Probleme avec la requete : " + probleme.Message);
            }
           
            return resultat;            
        }
        /// <summary>
        /// renvoie un DataReader avec le résultat de la requête
        /// </summary>
        /// <param name="requete">une chaîne</param>
        /// <returns>SqlDataReader</returns>
        public static SqlDataReader ExecuteReader(String requete)
        {
            SqlDataReader monDataReader = null;
             try
            {
                commande = new SqlCommand(requete, gObjetConnection);
                monDataReader = commande.ExecuteReader();
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Probleme avec la requete : " + probleme.Message);
            }
            return monDataReader;
        }

        /// <summary>
        /// renvoie une DataTable chargée par un DataReader
        /// </summary>
        /// <param name="requete"></param>
        /// <returns>DataTable</returns>
        public static DataTable ExecReader_DataTable(String requete)
        {
            DataTable Matable = new DataTable();
            SqlDataReader monDataReader = null;
            try
            {
                commande = new SqlCommand(requete, gObjetConnection);
                monDataReader = commande.ExecuteReader();
                Matable.Load(monDataReader);
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Probleme avec la requete : " + probleme.Message);
            }
            return Matable;
        }

        /// <summary>
        /// pour exécuter une requête qui n'a pas de champ (DELETE, INSERT)
        /// </summary>
        /// <param name="requete">une chaîne</param>
        public static void Exec_NonQuery(String requete)
        {
            try
            {
                commande = new SqlCommand(requete, gObjetConnection);
                commande.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException probleme)
            {
                MessageBox.Show("Probleme avec la requete : " + probleme.Message);
            }
        }

    }
}
   
