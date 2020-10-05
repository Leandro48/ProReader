using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProReader.model;
using ProReader.dao;

namespace ProReader.controller
{
    class LoginController
    {        
        public void logar(string login, string senha)
        {
            if (!login.Equals("") && !senha.Equals(""))
            {
            Login lg = new Login();
            LoginDAO lgd = new LoginDAO();
            lg.login = login;
            lg.senha = senha;

            lgd.logarDAO(lg.login, lg.senha);

            }
            else
            {
                MessageBox.Show("Preencha todos os campos para continuar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void telaInicial(string login)
        {
            FormPrincipal formPrincipal = new FormPrincipal();           
            formPrincipal.Show();
            formPrincipal.exibirTelaPrincipal(login);
        }
    }
}
