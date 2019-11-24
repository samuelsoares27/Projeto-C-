﻿using System;
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
        public Princi conta = null;

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


                if (conta is null)
                {
                    var c = new Princi();
                    c.Descricao = tbDescPagar.Text;
                    c.Efetuada = cbPagar.Checked;
                    c.Lancamento = DateTime.Now;
                    c.Tipo = modo;
                    c.Valor = (float)ValorPagar.Value;
                    c.Vencimento = dtpPagar.Value;
                    service.Insert(c);
                    c = null;

                }
                else
                {
                    conta.Valor = (float)ValorPagar.Value;
                    conta.Descricao = tbDescPagar.Text;
                    conta.Efetuada = cbPagar.Checked;
                    conta.Vencimento = dtpPagar.Value;
                    service.Update(conta);
                    conta = null;
                }

            }

            using (var service = new PrincipalServices())
            {
                dgvLista.DataSource = service.Retorna();
            }

            ValorPagar.Value = 0;
            tbDescPagar.Text = "";
            cbPagar.Checked = true;
            dtpPagar.Value = DateTime.Now;
            tabControl1.SelectedTab = tabLista;
        }

        private void Principal_Load(object sender, EventArgs e)
        {  
            using (var service = new PrincipalServices())
            {
                RecDespSource.DataSource = service.Retorna();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            conta = (Princi)RecDespSource.Current;
            tbDescPagar.Text = conta.Descricao;
            dtpPagar.Value = conta.Vencimento;
            ValorPagar.Value = (decimal)conta.Valor;
            cbPagar.Checked = conta.Efetuada;

            if (conta.Efetuada)
            {
                cbPagar.Checked = true;
            }
            else
            {
                cbPagar.Checked = false;
            }

            if (conta.Tipo == 0)
            {
                rbbReceber.Checked = true;
            }
            else
            {
                rbPagar.Checked = true;
            }

            tabControl1.SelectedTab = tabCadastro;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            using (var service = new PrincipalServices())
            {
                IEnumerable<Princi> contas = null;
                var frm = new filtro();
                frm.ShowDialog();

                if (frm.data is null) return;
                contas = service.Retorna();
                contas = contas.Where(f => f.Vencimento.ToShortDateString() == frm.data.GetValueOrDefault().ToShortDateString());
                RecDespSource.DataSource = contas;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var service = new PrincipalServices())
            {
                RecDespSource.DataSource = service.Retorna();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var service = new PrincipalServices())
            {
                dgvLista.DataSource = service.Retorna();
            }

            ValorPagar.Value = 0;
            tbDescPagar.Text = "";
            cbPagar.Checked = true;
            dtpPagar.Value = DateTime.Now;
            tabControl1.SelectedTab = tabLista;
            conta = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var conta = RecDespSource.Current as Princi;
            var result = MessageBox.Show("Tem certeza que deseja excluir a conta a receber selecionada?", "Ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var service = new PrincipalServices())
                {

                    service.Delete(conta);
                    RecDespSource.DataSource = service.Retorna();
        
                }
            }
        }
    }
}