using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Mapa_Curricular
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=ISAAC;Initial Catalog=Estudiantes_UABC;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = textCorreo.Text;
            string matricula = textMatricula.Text;
            string contraseña = textContraseña.Text;


            if (ValidarCredenciales(correo, matricula, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso");
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.");
            }
        }
        private bool ValidarCredenciales(string correo, string matricula, string contraseña)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Correo = @Correo AND Matricula = @Matricula AND Contraseña = @Contraseña";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Correo", correo);
                        command.Parameters.AddWithValue("@Matricula", matricula);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de inicio de sesión: " + ex.Message);
                return false;
            }
}

        private void button2_Click(object sender, EventArgs e)
        {
            try
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            MessageBox.Show("Conexión exitosa a la base de datos.");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al conectar a la base de datos: " + ex.ToString());
    }
        }
    }
}
    


