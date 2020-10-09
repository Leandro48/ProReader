using ProReader.controller;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ProReader
{
    public partial class FormHistorico : MaterialSkin.Controls.MaterialForm
    {
        public FormHistorico()
        {
            InitializeComponent();
        }

        private void FormHistorico_Load(object sender, EventArgs e)
        {            
            //this.dataGridView1.DataSource = retornaLista(textBoxUsuario.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void retornaLista(string usuario)
        {
            try {
                SqlConnection cn;
                string con = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProReader;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                cn = new SqlConnection(con);
                cn.Open();

                SqlCommand commandId = new SqlCommand("SELECT * FROM [LOGIN] WHERE LOGIN = @IdLogin", cn);
                commandId.Parameters.AddWithValue("@IdLogin", usuario);
                commandId.Connection = cn;
                SqlDataReader readerId = commandId.ExecuteReader();

                if (readerId.Read() == false)
                {
                    throw new Exception("Não existem resultados");
                }

                string idLogin = readerId["Id"].ToString();

                cn.Close();

                SqlConnection cnn;
                string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProReader;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                cnn = new SqlConnection(conn);
                cnn.Open();

                SqlCommand command = new SqlCommand("SELECT [CaminhoImagem], [TextoLido] FROM [ARQUIVOSLIDOS] WHERE IDLOGIN = @LOGIN UNION " +
                    "SELECT [UrlImagem], [TextoLido] FROM[ARQUIVOSLIDOSWEB] WHERE IDLOGIN = @LOGIN", cnn);
                command.Parameters.AddWithValue("@LOGIN", idLogin);

                command.Connection = cnn;
                SqlDataAdapter da = new SqlDataAdapter(command);

                DataSet ds = new DataSet();
                da.Fill(ds);

                bindingSource1.DataSource = ds;
                bindingSource1.DataMember = ds.Tables[0].TableName;
                dataGridView1.DataSource = bindingSource1;

                cnn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao obter os dados.");
            }
        }

        private void ListarHistorico_Click(object sender, EventArgs e)
        {
            retornaLista(textBoxUsuario.Text);
        }
    }
}
