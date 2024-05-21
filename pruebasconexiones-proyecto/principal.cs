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
            // Asegúrate de que tu clase conexiondb esté configurada correctamente
            SqlConnection connection = conexiondb.GetConnection();

            try
            {
                connection.Open();

                // Obtener la lista de bases de datos
                DataTable databases = connection.GetSchema("Databases");

                // Limpiar el TreeView antes de llenarlo
                DATABASE.Nodes.Clear();

                // Mostrar las bases de datos en un TreeView
                foreach (DataRow database in databases.Rows)
                {
                    string databaseName = database.Field<string>("database_name");
                    TreeNode dbNode = new TreeNode(databaseName);

                    // Obtener la lista de tablas para cada base de datos
                    DataTable tables = connection.GetSchema("Tables", new string[] { null, null, null, "BASE TABLE" });

                    foreach (DataRow table in tables.Rows)
                    {
                        string tableName = table.Field<string>("TABLE_NAME");
                        TreeNode tableNode = new TreeNode(tableName);

                        // Obtener la lista de columnas para cada tabla
                        DataTable columns = connection.GetSchema("Columns", new string[] { null, null, tableName });

                        foreach (DataRow column in columns.Rows)
                        {
                            string columnName = column.Field<string>("COLUMN_NAME");
                            tableNode.Nodes.Add(new TreeNode(columnName));
                        }

                        dbNode.Nodes.Add(tableNode);
                    }

                    DATABASE.Nodes.Add(dbNode);
                }
            }
            catch (SqlException ex)
            {
                // Manejar la excepción y mostrar información adicional
                MessageBox.Show($"Error al conectarse a la base de datos: {ex.Message}\nConnection String: {connection.ConnectionString}");
            }
            finally
            {
                connection.Close();
            }
        }


        #endregion

    }
}
