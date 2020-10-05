using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProReader.controller;

namespace ProReader.dao
{
    class LoginDAO
    {
        SqlConnection cnn;
        string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProReader;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public string logarDAO(string login, string senha)
        {
            cnn = new SqlConnection(conn);
            LoginController loginController = new LoginController();
            try
            {
                cnn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [LOGIN] WHERE LOGIN = @login AND PASSWORD = @senha", cnn);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@senha", senha);
                command.Connection = cnn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    loginController.telaInicial(login);
                }
                else 
                {
                    MessageBox.Show("Login ou senha inválidos ! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
                Console.WriteLine(ex);
                MessageBox.Show("Não foi possível conectar o banco ! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return "";
        }
    }
}
