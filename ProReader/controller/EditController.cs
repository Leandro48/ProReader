using ProReader.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProReader.controller
{
    class EditarController
    {
        public void cadastrarLidoLocal(string textoEditado, string caminhoImagem, string usuario)
        {
            if (!textoEditado.Equals(""))
            {
                EditDAO editDAO = new EditDAO();
                editDAO.cadastrarLidoLocal(textoEditado, caminhoImagem, usuario);
            }
            else
            {
                MessageBox.Show("Não é possível salvar um texto em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void cadastrarLidoWeb(string textoEditado, string urlImagem,  string usuario)
        {
            if (!textoEditado.Equals(""))
            {
                EditDAO editDAO = new EditDAO();
                editDAO.cadastrarLidoWeb(textoEditado, urlImagem, usuario);
            }
            else
            {
                MessageBox.Show("Não é possível salvar um texto em branco!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
