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
    public partial class Form1 : Form
    {
        #region variablesglobales
        public string servidor;
        public string user;
        public string password;
        #endregion

        #region metodos forms
        public Form1()
        {
            InitializeComponent();
            conexiondb conexiondb = new conexiondb();
           
            conexiondb.ServidorNo = servidor;
            conexiondb.users = user;
            conexiondb.password = password;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            conexiondb conexiondb = new conexiondb();
            SqlConnection conexion = conexiondb.GetConnection();
            MessageBox.Show(conexion.ConnectionString);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            servidor = txtServidor.Text;
            user = txtUsers.Text;
            password = txtPassword.Text;

            if (string.IsNullOrEmpty(servidor))
            {
                MessageBox.Show("Por favor, ingrese el servidor.");
                return;
            }
            if (string.IsNullOrEmpty(user))
            {
                MessageBox.Show("Por favor, ingrese el usuario.");
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return;
            }

            // Establecer los detalles del servidor
            conexiondb.conexionStatic(servidor, user, password);

            using (SqlConnection connection = conexiondb.GetConnection())
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("¡Conexión exitosa!");

                    principal principal = new principal();
                    principal.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }
        #endregion
    

    }
}
