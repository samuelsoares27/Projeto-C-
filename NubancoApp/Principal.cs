using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabalho;
using NubancoApp.Models;
using NubancoApp.Services;

namespace NubancoApp
{
    public partial class Principal : Form
    {
        public TipoDaConta modo = TipoDaConta.Receber;
        public Princi pri = null;

        public Principal()
        {
            InitializeComponent();
        }

        public object Tipo { get; internal set; }

        // Cadastro de contas a pagar

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (var service = new PrincipalServices())
            {
                if (rbPagar.Checked)
                {

                    modo = TipoDaConta.Pagar;

                }
                else
                {
                    modo = TipoDaConta.Receber;

                }


                if (pri is null)
                {
                    var c = new Princi();
                    c.Descricao = tbDescPagar.Text;
                    c.Efetuada = cbPagar.Checked;
                    c.Lancamento = DateTime.Now;
                    c.Tipo = modo;
                    c.Valor = (float)ValorPagar.Value;
                    c.Vencimento = dtpPagar.Value;
                    service.Insert(c);

                }
                else
                {
                    pri.Valor = (float)ValorPagar.Value;
                    pri.Descricao = tbDescPagar.Text;
                    pri.Efetuada = cbPagar.Checked;
                    pri.Vencimento = dtpPagar.Value;
                    service.Update(pri);
                }

            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            using (var service = new PrincipalServices())
            {
                dgvLista.DataSource = service.Retorna();
            }
        }
    }
}
