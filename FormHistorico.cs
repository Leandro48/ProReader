using ProReader.controller;
using System;
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
            this.dataGridView1.DataSource = retornaLista(textBoxUsuario.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataSet retornaLista(string usuario)
        {
            SqlConnection cnn;
            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProReader;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            cnn = new SqlConnection(conn);
            cnn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [ARQUIVOSLIDOS] WHERE IDLOGIN = @LOGIN UNION " +
                "SELECT * FROM[ARQUIVOSLIDOSWEB] WHERE IDLOGIN = @LOGIN", cnn);
            command.Parameters.AddWithValue("@IdLogin", usuario);
        }
    }
}
