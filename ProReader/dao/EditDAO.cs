using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProReader.dao
{
    class EditDAO
    {
        SqlConnection cnn;
        string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProReader;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public void cadastrarLidoLocal(string textoEditado, string caminhoImagem, string usuario)
        {
            cnn = new SqlConnection(conn);

            try
            {
                cnn.Open();

                SqlCommand commandId = new SqlCommand("SELECT * FROM [LOGIN] WHERE LOGIN = @IdLogin", cnn);
                commandId.Parameters.AddWithValue("@IdLogin", usuario);
                commandId.Connection = cnn;
                SqlDataReader readerId = commandId.ExecuteReader();

                if (readerId.Read() == false)
                {
                    throw new Exception("Não existem resultados");
                }

                string idLogin = readerId["Id"].ToString();

                cnn.Close();
                cnn.Open();

                SqlCommand commandInsert = new SqlCommand("INSERT INTO ArquivosLidos (CaminhoImagem, TextoLido, IdLogin) VALUES (@caminhoImagem, @textolido, @idLogin)", cnn);
                commandInsert.Parameters.AddWithValue("@CaminhoImagem", caminhoImagem);
                commandInsert.Parameters.AddWithValue("@TextoLido",  textoEditado);
                commandInsert.Parameters.AddWithValue("@IdLogin", idLogin);
                commandInsert.Connection = cnn;
                SqlDataReader reader = commandInsert.ExecuteReader();

                MessageBox.Show("Texto cadastrado com sucesso ! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cnn.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
                Console.WriteLine(ex);
                MessageBox.Show("Não foi possível conectar o banco ! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void cadastrarLidoWeb(string textoEditado, string urlImagem, string usuario)
        {
            cnn = new SqlConnection(conn);

            try
            {
                cnn.Open();

                SqlCommand commandId = new SqlCommand("SELECT * FROM [LOGIN] WHERE LOGIN = @IdLogin", cnn);
                commandId.Parameters.AddWithValue("@IdLogin", usuario);
                commandId.Connection = cnn;
                SqlDataReader readerId = commandId.ExecuteReader();

                if (readerId.Read() == false)
                {
                    throw new Exception("Não existem resultados");
                }

                string idLogin = readerId["Id"].ToString();

                cnn.Close();
                cnn.Open();
                //criar nova tabela para web
                SqlCommand commandInsert = new SqlCommand("INSERT INTO ArquivosLidosWeb (UrlImagem, TextoLido, IdLogin) VALUES (@urlImagem, @textolido, @idLogin)", cnn);
                commandInsert.Parameters.AddWithValue("@UrlImagem", urlImagem);
                commandInsert.Parameters.AddWithValue("@TextoLido", textoEditado);
                commandInsert.Parameters.AddWithValue("@IdLogin", idLogin);
                commandInsert.Connection = cnn;
                SqlDataReader reader = commandInsert.ExecuteReader();

                MessageBox.Show("Texto cadastrado com sucesso ! ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                cnn.Close();
            }
            catch (Exception ex)
            {
                ex.ToString();
                Console.WriteLine(ex);
                MessageBox.Show("Não foi possível conectar o banco ! ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
