
using NubancoApp.Repositories;
using NubancoApp.Services;
using System.Windows.Forms;

namespace NubancoApp
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            // com injection
            using (var service = new LoginService())
            {
                var authenticated = service.GetLogin(textBox1.Text, textBox2.Text, false);
                if (!(authenticated is null))
                {
                    Global.Instance.SetUser(authenticated);

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

        private void Button2_Click(object sender, System.EventArgs e)
        {
            // sem injection
            using (var service = new LoginService())
            {
                var authenticated = service.GetLogin(textBox1.Text, textBox2.Text, true);
                if (!(authenticated is null))
                {
                    Global.Instance.SetUser(authenticated);

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

    }
}
