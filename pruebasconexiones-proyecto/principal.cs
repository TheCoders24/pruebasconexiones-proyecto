using conexionesdb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conexionesdb;
using System.Windows.Forms;

namespace pruebasconexiones_proyecto
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            MostrarDBS();
        }

        #region funcionmostrarDB
        public void MostrarDBS()
        {
            SqlConnection connection = conexiondb.GetConnection();
            try
            {
                connection.Open();

                // Obtener la lista de bases de datos
                DataTable databases = connection.GetSchema("Databases");

                // Mostrar las bases de datos en un ListBox
                foreach (DataRow database in databases.Rows)
                {
                    string databaseName = database.Field<string>("database_name");
                    DATABASE.Items.Add(databaseName);
                }
            }
            catch (SqlException ex)
            {
                // Manejar la excepción
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        #endregion
    }
}
