using MaterialSkin;
using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using IronOcr;

namespace ProReader
{
    public partial class FormPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public string diretorio, imagem;
        public FormPrincipal()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green900, Primary.BlueGrey800,
                Primary.BlueGrey500, Accent.Orange700,
                TextShade.WHITE
            );
        }

        internal void exibirTelaPrincipal(string login)
        {            
            lblUser.Text = login;     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void carregaArquivo_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileCarregaArquivo.ShowDialog();
            if (res == DialogResult.OK)
            {
                diretorio = openFileCarregaArquivo.FileName;
                pictureBox.Load(diretorio);
                if (pictureBox.ImageLocation != null)
                {
                    processarLocal.Visible = true;
                    processarWeb.Visible = false;
                }
            }
            pictureBox.Refresh();
        }

        private void carregaArquivoWeb_Click(object sender, EventArgs e)
        {
            imagem = Interaction.InputBox("Informe a url da imagem", "Carregar arquivo da web", "", 100, 200);
            try
            {                
                pictureBox.LoadAsync(imagem);
                if (pictureBox.ImageLocation != null)
                {
                    processarWeb.Visible = true;
                    processarLocal.Visible = false;                    
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Não foi possível carregar a imagem.");
            }
            pictureBox.Refresh();
        }

        private void processarLocal_Click(object sender, EventArgs e)
        {
            var Ocr = new AutoOcr();
            FormEditar editar = new FormEditar();
            var Result = Ocr.Read(@diretorio);

            editar.Show();
            editar.richTextBoxLocal.Visible = true;
            editar.salvarTextoLocal.Visible = true;
            editar.richTextBoxLocal.Text = Result.Text;
            editar.textBoxCaminho.Text = @diretorio;
            editar.textBoxUsuario.Text = lblUser.Text;
        }

        private void listarSalvos_Click(object sender, EventArgs e)
        {
            FormHistorico historico = new FormHistorico();

            historico.textBoxUsuario.Text = lblUser.Text;
        }

        private void processarWeb_Click(object sender, EventArgs e)
        {
            var Ocr = new AutoOcr();
            FormEditar editar = new FormEditar();
            var Result = Ocr.Read(pictureBox.Image);
                       
            editar.Show();
            editar.richTextBoxWeb.Visible = true;
            editar.salvarTextoWeb.Visible = true;
            editar.richTextBoxWeb.Text = Result.Text;
            editar.textBoxCaminho.Text = imagem;
            editar.textBoxUsuario.Text = lblUser.Text;
        }
    }
}
