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
        public string servidor;
        public string user;
        public string password;

        public principal()
        {
            InitializeComponent();
            servidor = conexiondb.ServidorNo;
            user = conexiondb.users;
            password = conexiondb.password;
        }

        private void principal_Load(object sender, EventArgs e)
        {
            MostrarDBS();
        }

        #region funcionmostrarDB
        public void MostrarDBS()
        {
            try
            {
                // Asegúrate de que tu clase conexiondb esté configurada correctamente
                //SqlConnection connection = conexiondb.GetConnection(conexiondb.ServidorNo, conexiondb.users, conexiondb.password);

                SqlConnection connection = conexiondb.GetConnection(servidor, user, password);
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

                connection.Close(); // Cerrar la conexión después de usarla
            }
            catch (SqlException ex)
            {
                // Manejar la excepción y mostrar información adicional
                MessageBox.Show($"Error al conectarse a la base de datos: {ex.Message}\nConnection String: {conexiondb.GetConnection(conexiondb.ServidorNo, conexiondb.users, conexiondb.password).ConnectionString}");
            }
        }
        #endregion

        private void creardbToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            creadordb creadordb = new creadordb();
            creadordb.Show();
        }
    }
}
