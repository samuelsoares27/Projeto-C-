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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var service = new PrincipalServices())
            {

                if (pri is null)
                {
                    var c = new Princi();
                    c.Descricao = textBox1.Text;
                    c.Efetuada = checkBox1.Checked;
                    c.Lancamento = DateTime.Now;
                    c.Tipo = modo;
                    c.Valor = (float)numericUpDown1.Value;
                    c.Vencimento = dateTimePicker2.Value;
                    service.Insert(c);

                }
                else
                {
                    pri.Valor = (float)numericUpDown1.Value;
                    pri.Descricao = textBox1.Text;
                    pri.Efetuada = checkBox1.Checked;
                    pri.Vencimento = dateTimePicker2.Value;
                    service.Update(pri);
                }

            }

            this.Close();
        }
    }
}
