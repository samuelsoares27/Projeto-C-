
using Trabalhoo.Repositories;
using Trabalhoo.Services;
using System.Windows.Forms;

namespace Trabalhoo
{
    public partial class FormLogin : Form
    {


        public FormLogin()
        {
            InitializeComponent();
        }



        private void btnLogarCom_Click(object sender, System.EventArgs e)
        {
            // com injection

            using (var service = new LoginService())
            {
                var autenticacao = service.GetLogin(txtEmail.Text, txtSenha.Text, false);

                if (!(autenticacao is null))
                {

                    this.Hide();
                    Principal frmP = new Principal();
                    frmP.ShowDialog();
                    Application.Exit();

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
        }



        private void btnLogarSem_Click(object sender, System.EventArgs e)
        {
            // sem injection

            using (var service = new LoginService())
            {
                var autenticacao = service.GetLogin(txtEmail.Text, txtSenha.Text, true);

                if (!(autenticacao is null))
                {

                    this.Hide();
                    Principal frmP = new Principal();
                    frmP.ShowDialog();
                    Application.Exit();
                    
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos.");
                }
            }
        }

        private void LblSair_Click(object sender, System.EventArgs e)
        {

            Application.Exit();

        }


    }
}
