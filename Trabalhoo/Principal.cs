﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalhoo;
using Trabalhoo.Models;
using Trabalhoo.Services;

namespace Trabalhoo
{
    public partial class Principal : Form
    {
        public TipoDaConta modo = TipoDaConta.Receber;
        public Princi conta = null;
        DateTime? data = null;

        public Principal()
        {
            InitializeComponent();
            tabControl1.TabPages.Remove(tabCadastro);

            this.tabControl1.Appearance = TabAppearance.FlatButtons;
            this.tabControl1.ItemSize = new Size(0, 1);
            this.tabControl1.SizeMode = TabSizeMode.Fixed;
        }

        private void Totalizadores()
        {
            
            using (var service = new PrincipalServices())
            {
              
                IEnumerable<Princi> contas = null;
                contas = service.Retorna();
                RecDespSource.DataSource = contas; 

                if (!(data is null))
                {
                    contas = contas.Where(f => f.Vencimento.ToShortDateString() == data.GetValueOrDefault().ToShortDateString()).ToList();
                }
                
                var totalReceber = service.TotalContasReceber(contas.ToList());
                var totalPagar = service.TotalContasPagar(contas.ToList());

                lblpagar.Text = "Pagar: R$ " + totalPagar;
                lblreceber.Text = "Receber: R$ " + totalReceber;

            }

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

                RecDespSource.DataSource = service.Retorna();

            }

            ValorPagar.Value = 0;
            tbDescPagar.Text = "";
            cbPagar.Checked = true;
            dtpPagar.Value = DateTime.Now;
            tabControl1.SelectedTab = tabLista;
            tabControl1.TabPages.Remove(tabCadastro);
            Totalizadores();

        }

        private void Principal_Load(object sender, EventArgs e)
        {
            cbbPagarReceber.Items.Add("Todos");
            cbbPagarReceber.Items.Add("Pagar");
            cbbPagarReceber.Items.Add("Receber");
            cbbPagarReceber.SelectedIndex = 0;
            Totalizadores();
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

            tabControl1.TabPages.Add(tabCadastro);
            tabControl1.SelectedTab = tabCadastro;
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            using (var service = new PrincipalServices())
            {
                IEnumerable<Princi> contas = null;
                var frm = new filtro();
                frm.ShowDialog();

                if (frm.data is null) return;
                data = frm.data;
                contas = service.Retorna();
                RecDespSource.DataSource = contas.Where(f => f.Vencimento.ToShortDateString() == data.GetValueOrDefault().ToShortDateString()).ToList();
                dgvLista.Refresh();

                if (!(frm.data is null))
                {
                    contas = contas.Where(f => f.Vencimento.ToShortDateString() == data.GetValueOrDefault().ToShortDateString()).ToList();
                }

                var totalReceber = service.TotalContasReceber(contas.ToList());
                var totalPagar = service.TotalContasPagar(contas.ToList());

                lblpagar.Text = "Pagar: R$ " + totalPagar;
                lblreceber.Text = "Receber: R$ " + totalReceber;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var service = new PrincipalServices())
            {
                RecDespSource.DataSource = service.Retorna();
            }

            data = null;
            Totalizadores();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            ValorPagar.Value = 0;
            tbDescPagar.Text = "";
            cbPagar.Checked = true;
            dtpPagar.Value = DateTime.Now;
            tabControl1.SelectedTab = tabLista;

            tabControl1.TabPages.Remove(tabCadastro);
            Totalizadores();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            IEnumerable<Princi> contas = null;
            var conta = RecDespSource.Current as Princi;
            if (conta.Efetuada)
            {
                MessageBox.Show("Não é possível excluir contas efetuadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var result = MessageBox.Show("Tem certeza que deseja excluir a conta a receber selecionada?", "Ação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (var service = new PrincipalServices())
                {

                    service.Delete(conta);
                    contas = service.Retorna();
                    RecDespSource.DataSource = contas;

                    var totalReceber = service.TotalContasReceber(contas.ToList());
                    var totalPagar = service.TotalContasPagar(contas.ToList());

                    lblpagar.Text = "Pagar: R$ " + totalPagar;
                    lblreceber.Text = "Receber: R$ " + totalReceber;

                }

            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Remove(tabCadastro);
            tabControl1.TabPages.Add(tabCadastro);
            tabControl1.SelectedTab = tabCadastro;
        }

        private void cbbPagarReceber_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<Princi> contas = null;

            if (cbbPagarReceber.Text == "Todos")
            {
                using (var service = new PrincipalServices())
                {
                    contas = service.Retorna();
                    RecDespSource.DataSource = contas;
                    var totalReceber = service.TotalContasReceber(contas.ToList());
                    var totalPagar = service.TotalContasPagar(contas.ToList());

                    lblpagar.Text = "Pagar: R$ " + totalPagar;
                    lblreceber.Text = "Receber: R$ " + totalReceber;
                }
            }
            else if(cbbPagarReceber.Text == "Pagar")
            {
                using (var service = new PrincipalServices())
                {
                    contas = service.RetornaPag();
                    RecDespSource.DataSource = contas;
                    var totalReceber = service.TotalContasReceber(contas.ToList());
                    var totalPagar = service.TotalContasPagar(contas.ToList());

                    lblpagar.Text = "Pagar: R$ " + totalPagar;
                    lblreceber.Text = "Receber: R$ " + totalReceber;
                    
                }
            }
            else if (cbbPagarReceber.Text == "Receber")
            {
                using (var service = new PrincipalServices())
                {
                    contas = service.RetornaRec();
                    RecDespSource.DataSource = contas;
                    var totalReceber = service.TotalContasReceber(contas.ToList());
                    var totalPagar = service.TotalContasPagar(contas.ToList());

                    lblpagar.Text = "Pagar: R$ " + totalPagar;
                    lblreceber.Text = "Receber: R$ " + totalReceber;
                }
            }
        }
    }
}
