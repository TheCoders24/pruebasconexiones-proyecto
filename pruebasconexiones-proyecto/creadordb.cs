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
            // Configurar columnas del DataGridView
            dataGridView1.Columns.Add("ColumnName", "Nombre de Columna");
            dataGridView1.Columns.Add("DataType", "Tipo de Dato");

            // Añadir opciones para tipos de datos
            DataGridViewComboBoxColumn dataTypeColumn = new DataGridViewComboBoxColumn();
            dataTypeColumn.Name = "DataType";
            dataTypeColumn.HeaderText = "Tipo de Dato";
            dataTypeColumn.Items.AddRange("VARCHAR(50)", "CHAR(10)", "INT", "DECIMAL(18, 2)", "DATETIME");
            dataGridView1.Columns.RemoveAt(1);
            dataGridView1.Columns.Add(dataTypeColumn);
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear la base de datos: {ex.Message}");
                }
        }
        

        private void txtnombredebasededatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxdatabase_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnsavetable_Click(object sender, EventArgs e)
        {
            string databaseName = textBox2.Text.Trim(); // Nombre de la base de datos creada
            string tableName = textBox1.Text.Trim(); // Nombre de la tabla a crear

            if (string.IsNullOrEmpty(databaseName))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la base de datos.");
                return;
            }

            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show("Por favor, ingrese el nombre de la tabla.");
                return;
            }

            List<ColumnDefinition> tableDefinition = new List<ColumnDefinition>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ColumnName"].Value != null && row.Cells["DataType"].Value != null)
                {
                    tableDefinition.Add(new ColumnDefinition
                    {
                        ColumnName = row.Cells["ColumnName"].Value.ToString(),
                        DataType = row.Cells["DataType"].Value.ToString()
                    });
                }
            }

            if (tableDefinition.Count > 0)
            {
                CreateTable(databaseName, tableName, tableDefinition);
            }
        }
        public class ColumnDefinition
        {
            public string ColumnName { get; set; }
            public string DataType { get; set; }
        }
        private void CreateTable(string databaseName, string tableName, List<ColumnDefinition> tableDefinition)
        {
            string connectionString = $"Data Source={servidor};Initial Catalog={databaseName};Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Crear consulta SQL para crear la tabla
                string createTableQuery = $"CREATE TABLE {tableName} (";
                foreach (var column in tableDefinition)
                {
                    createTableQuery += $"{column.ColumnName} {column.DataType},";
                }
                createTableQuery = createTableQuery.TrimEnd(',') + ");";

                using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Tabla creada exitosamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear la tabla: {ex.Message}");
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Añadir nueva fila al DataGridView
            dataGridView1.Rows.Add();
        }
    }
}
