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
                // Recopilar la información de las tablas desde el DataGridView
                DataTable dtTablas = (DataTable)dataGridView1.DataSource;

                foreach (DataRow rowTabla in dtTablas.Rows)
                {
                    string nombreTabla = rowTabla.Field<string>("NombreTabla");

                    // Crear la consulta SQL para crear la tabla
                    string queryCrearTabla = $"CREATE TABLE [{nombreBaseDeDatos}].[dbo].[{nombreTabla}] (";

                    // Obtener los campos de la tabla
                    DataTable dtCampos = (DataTable)rowTabla["Campos"];

                    foreach (DataRow rowCampo in dtCampos.Rows)
                    {
                        string nombreCampo = rowCampo.Field<string>("NombreCampo");
                        string tipoCampo = rowCampo.Field<string>("TipoCampo");

                        queryCrearTabla += $"{nombreCampo} {tipoCampo},"; // Agregar cada campo a la consulta
                    }

                    queryCrearTabla = queryCrearTabla.TrimEnd(',') + ")"; // Eliminar la última coma y cerrar paréntesis

                    // Ejecutar la consulta para crear la tabla
                    using (SqlCommand commandCrearTabla = new SqlCommand(queryCrearTabla, connection))
                    {
                        commandCrearTabla.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Tablas y campos creados con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear las tablas y campos: {ex.Message}");
            }
        }

        private void txtnombredebasededatos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
