using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acces_BDClassLibrary
{ 
    /// <summary>
    /// attributs de classes pour les paramètres du serveur et de la base de données
    /// </summary>
    public class paramètres
    {
        #region déclaration des paramètres de connexion du serveur
        public static String myValuelogin = "sa"; //login du serveur SQL serveur
        public static String myValueMdp = "info"; //mot de passe du serveur SQL server : Info Emmy 
        public static String myValueServer = Environment.MachineName; //nom du serveur SQL Server
        public static String myValueBD = "BBLLGSB"; // nom de la base de données
        #endregion
    }
}
