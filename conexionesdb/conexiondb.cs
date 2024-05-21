using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conexionesdb
{
    public class conexiondb
    {

        #region Variablesglobales
        public static string ServidorNo { get; set; }
        public static string users { get; set; }
        public static string password { get; set; }
        #endregion

        #region constructor
        public conexiondb()
        {
            ServidorNo = string.Empty;
            users = string.Empty;
            password = string.Empty;
        }
        #endregion

        #region conexionesDB

        public static string conexionStatic(string servidores1, string users1, string passsword)
        {
            ServidorNo = servidores1;
            users = users1;
            password = passsword;
            return $"Data Source={ServidorNo};User ID={users};Password={password};TrustServerCertificate=true;";
        }
        public static SqlConnection GetConnection()
        {
            SqlConnection conexion = new SqlConnection(conexionStatic(ServidorNo, users, password));
            return conexion;
        }
        #endregion

        #region comprobacion SihayConexion
        public Boolean SiHayConexion() 
        {
            try
            {
                String sConexionDB = conexiondb.conexionStatic(ServidorNo, users, password);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        #endregion




    }
}
