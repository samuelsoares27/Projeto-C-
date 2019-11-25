﻿namespace NubancoApp
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quitada = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RecDespSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.rbbReceber = new System.Windows.Forms.RadioButton();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cbPagar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPagar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorPagar = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDespSource)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(762, 479);
            this.tabControl1.TabIndex = 1;
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.SystemColors.Window;
            this.tabLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLista.Controls.Add(this.btnCadastrar);
            this.tabLista.Controls.Add(this.button4);
            this.tabLista.Controls.Add(this.button2);
            this.tabLista.Controls.Add(this.button1);
            this.tabLista.Controls.Add(this.btnAlterar);
            this.tabLista.Controls.Add(this.dgvLista);
            this.tabLista.Location = new System.Drawing.Point(4, 22);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabLista.Size = new System.Drawing.Size(754, 453);
            this.tabLista.TabIndex = 1;
            this.tabLista.Text = "Lista";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Location = new System.Drawing.Point(7, 7);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(88, 35);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(191, 7);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 35);
            this.button4.TabIndex = 4;
            this.button4.Text = "Apagar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(375, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar Filtros";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(283, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAlterar.Location = new System.Drawing.Point(99, 7);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 35);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoGenerateColumns = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.valor,
            this.Pagamento,
            this.descricao,
            this.vencimento,
            this.lancamento,
            this.Quitada});
            this.dgvLista.DataSource = this.RecDespSource;
            this.dgvLista.Location = new System.Drawing.Point(7, 48);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(742, 398);
            this.dgvLista.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "Código";
            this.id.Name = "id";
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // Pagamento
            // 
            this.Pagamento.DataPropertyName = "tipo";
            this.Pagamento.HeaderText = "Tipo Pagamento";
            this.Pagamento.Name = "Pagamento";
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descrição";
            this.descricao.Name = "descricao";
            // 
            // vencimento
            // 
            this.vencimento.DataPropertyName = "vencimento";
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            // 
            // lancamento
            // 
            this.lancamento.DataPropertyName = "lancamento";
            this.lancamento.HeaderText = "Lançamento";
            this.lancamento.Name = "lancamento";
            // 
            // Quitada
            // 
            this.Quitada.DataPropertyName = "efetuada";
            this.Quitada.HeaderText = "efetuada";
            this.Quitada.Name = "Quitada";
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCadastro.Controls.Add(this.panel1);
            this.tabCadastro.Location = new System.Drawing.Point(4, 22);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(754, 453);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.rbbReceber);
            this.panel1.Controls.Add(this.rbPagar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnPagar);
            this.panel1.Controls.Add(this.cbPagar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpPagar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbDescPagar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ValorPagar);
            this.panel1.Location = new System.Drawing.Point(232, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 292);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(154, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "&Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbbReceber
            // 
            this.rbbReceber.AutoSize = true;
            this.rbbReceber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbbReceber.Location = new System.Drawing.Point(47, 215);
            this.rbbReceber.Margin = new System.Windows.Forms.Padding(2);
            this.rbbReceber.Name = "rbbReceber";
            this.rbbReceber.Size = new System.Drawing.Size(62, 17);
            this.rbbReceber.TabIndex = 14;
            this.rbbReceber.TabStop = true;
            this.rbbReceber.Text = "Receita";
            this.rbbReceber.UseVisualStyleBackColor = true;
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbPagar.Location = new System.Drawing.Point(47, 193);
            this.rbPagar.Margin = new System.Windows.Forms.Padding(2);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(67, 17);
            this.rbPagar.TabIndex = 13;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "Despesa";
            this.rbPagar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(17, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contas a Pagar e Receber";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnPagar.FlatAppearance.BorderSize = 0;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPagar.Location = new System.Drawing.Point(44, 240);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(104, 32);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "&Salvar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbPagar
            // 
            this.cbPagar.AutoSize = true;
            this.cbPagar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbPagar.Location = new System.Drawing.Point(176, 203);
            this.cbPagar.Name = "cbPagar";
            this.cbPagar.Size = new System.Drawing.Size(82, 17);
            this.cbPagar.TabIndex = 10;
            this.cbPagar.Text = "Conta Paga";
            this.cbPagar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(45, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Vencimento";
            // 
            // dtpPagar
            // 
            this.dtpPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagar.Location = new System.Drawing.Point(44, 161);
            this.dtpPagar.Name = "dtpPagar";
            this.dtpPagar.Size = new System.Drawing.Size(215, 20);
            this.dtpPagar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(45, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição";
            // 
            // tbDescPagar
            // 
            this.tbDescPagar.Location = new System.Drawing.Point(44, 112);
            this.tbDescPagar.Name = "tbDescPagar";
            this.tbDescPagar.Size = new System.Drawing.Size(215, 20);
            this.tbDescPagar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(45, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // ValorPagar
            // 
            this.ValorPagar.DecimalPlaces = 2;
            this.ValorPagar.Location = new System.Drawing.Point(44, 68);
            this.ValorPagar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ValorPagar.Name = "ValorPagar";
            this.ValorPagar.Size = new System.Drawing.Size(214, 20);
            this.ValorPagar.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 479);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDespSource)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorPagar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.CheckBox cbPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ValorPagar;
        private System.Windows.Forms.TabPage tabLista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbbReceber;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Button btnAlterar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource RecDespSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn lancamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Quitada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCadastrar;
    }
}