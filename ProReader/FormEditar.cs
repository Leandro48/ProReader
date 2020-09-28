using ProReader.controller;
using System;
using System.Windows.Forms;

namespace ProReader
{
    public partial class FormEditar : MaterialSkin.Controls.MaterialForm
    {
        public FormEditar()
        {
            InitializeComponent();
        }

        private void FormEditar_Load(object sender, EventArgs e)
        {
            
        }

        private void salvarTextoWeb_Click(object sender, EventArgs e)
        {
            EditarController editarController = new EditarController();
            
            string textoEditado, usuario;
            usuario = textBoxUsuario.Text;

            textoEditado = richTextBoxWeb.Text;
            editarController.cadastrarLidoWeb(textoEditado, textBoxCaminho.Text, usuario);
            this.Hide();
        }

        private void salvarTextoLocal_Click(object sender, EventArgs e)
        {
            EditarController editarController = new EditarController();
            
            string textoEditado, usuario;
            usuario = textBoxUsuario.Text;

            textoEditado = richTextBoxLocal.Text;
            editarController.cadastrarLidoLocal(textoEditado, textBoxCaminho.Text, usuario);
            this.Hide();
        }
    }
}
