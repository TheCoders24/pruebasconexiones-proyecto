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
    public partial class creadordb : Form
    {
        #region variablesglobales
        public string servidor;
        public string user;
        public string password;
        #endregion
       
        public creadordb()
        {
            InitializeComponent();
            // Corregir la asignación de las variables servidor, user y password
            servidor = conexiondb.ServidorNo;
            user = conexiondb.users;
            password = conexiondb.password;
        }
        
        private void creadordb_Load(object sender, EventArgs e)
        {
            // Crea las columnas en el DataGridView
            dataGridView1.Columns.Add("NombreTabla", "Nombre de la Tabla");
            dataGridView1.Columns.Add("Campos", "Campos");

            // Opcionalmente, puedes definir el estilo de las columnas, por ejemplo:
            dataGridView1.Columns["NombreTabla"].Width = 150;
            dataGridView1.Columns["Campos"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btncrearbasededatos_Click(object sender, EventArgs e)
        {

            try
            {
                string nombreBaseDeDatos = txtnombredebasededatos.Text.Trim();

                if (string.IsNullOrEmpty(nombreBaseDeDatos))
                {
                    MessageBox.Show("Por favor, ingrese un nombre para la base de datos.");
                    return;
                }

                // Crear la conexión a SQL Server
                using (SqlConnection connection = conexiondb.GetConnection(servidor, user, password))
                {
                    connection.Open();

                    // Crear la consulta SQL para crear la base de datos
                    string queryCrearBD = $"CREATE DATABASE {nombreBaseDeDatos}";
                    using (SqlCommand commandCrearBD = new SqlCommand(queryCrearBD, connection))
                    {
                        commandCrearBD.ExecuteNonQuery();
                        connection.Close();
                    }

                    MessageBox.Show($"La base de datos '{nombreBaseDeDatos}' ha sido creada con éxito.");

                    // Crear tablas y campos
                    CrearTablasYCampos(connection, nombreBaseDeDatos);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la base de datos: {ex.Message}");
            }
            

        }
        private void CrearTablasYCampos(SqlConnection connection, string nombreBaseDeDatos)
        {
            try
            {
                // Abre la conexión a la base de datos
                connection.Open();

                // Recorre las filas del DataGridView para crear las tablas y campos
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    string nombreTabla = row.Cells["NombreTabla"].Value?.ToString();

                    if (!string.IsNullOrEmpty(nombreTabla))
                    {
                        string campos = row.Cells["Campos"].Value?.ToString();

                        if (!string.IsNullOrEmpty(campos))
                        {
                            // Crea la consulta SQL para crear la tabla
                            string queryCrearTabla = $"CREATE TABLE [{nombreTabla}] ({campos})";

                            // Ejecuta la consulta para crear la tabla
                            using (SqlCommand commandCrearTabla = new SqlCommand(queryCrearTabla, connection))
                            {
                                commandCrearTabla.ExecuteNonQuery();
                                connection.Close(); 
                            }
                        }
                    }
                }

                MessageBox.Show("Tablas creadas con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear las tablas: {ex.Message}");
            }
            finally
            {
                // Cierra la conexión a la base de datos
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void txtnombredebasededatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxdatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
