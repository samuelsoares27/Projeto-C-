namespace NubancoApp
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
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.tabLista = new System.Windows.Forms.TabPage();
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorPagar)).BeginInit();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDespSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 589);
            this.tabControl1.TabIndex = 1;
            // 
            // tabCadastro
            // 
            this.tabCadastro.Controls.Add(this.panel1);
            this.tabCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastro.Size = new System.Drawing.Size(1054, 560);
            this.tabCadastro.TabIndex = 0;
            this.tabCadastro.Text = "Cadastro";
            this.tabCadastro.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(341, 85);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 359);
            this.panel1.TabIndex = 1;
            // 
            // rbbReceber
            // 
            this.rbbReceber.AutoSize = true;
            this.rbbReceber.Location = new System.Drawing.Point(63, 265);
            this.rbbReceber.Name = "rbbReceber";
            this.rbbReceber.Size = new System.Drawing.Size(83, 21);
            this.rbbReceber.TabIndex = 14;
            this.rbbReceber.TabStop = true;
            this.rbbReceber.Text = "Receber";
            this.rbbReceber.UseVisualStyleBackColor = true;
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.Location = new System.Drawing.Point(63, 238);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(67, 21);
            this.rbPagar.TabIndex = 13;
            this.rbPagar.TabStop = true;
            this.rbPagar.Text = "Pagar";
            this.rbPagar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contas a Pagar e Receber";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(58, 306);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(139, 28);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "&Salvar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbPagar
            // 
            this.cbPagar.AutoSize = true;
            this.cbPagar.Location = new System.Drawing.Point(256, 250);
            this.cbPagar.Margin = new System.Windows.Forms.Padding(4);
            this.cbPagar.Name = "cbPagar";
            this.cbPagar.Size = new System.Drawing.Size(87, 21);
            this.cbPagar.TabIndex = 10;
            this.cbPagar.Text = "Efetuada";
            this.cbPagar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data Vencimento";
            // 
            // dtpPagar
            // 
            this.dtpPagar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPagar.Location = new System.Drawing.Point(58, 198);
            this.dtpPagar.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPagar.Name = "dtpPagar";
            this.dtpPagar.Size = new System.Drawing.Size(285, 22);
            this.dtpPagar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição";
            // 
            // tbDescPagar
            // 
            this.tbDescPagar.Location = new System.Drawing.Point(58, 138);
            this.tbDescPagar.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescPagar.Name = "tbDescPagar";
            this.tbDescPagar.Size = new System.Drawing.Size(285, 22);
            this.tbDescPagar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // ValorPagar
            // 
            this.ValorPagar.DecimalPlaces = 2;
            this.ValorPagar.Location = new System.Drawing.Point(58, 84);
            this.ValorPagar.Margin = new System.Windows.Forms.Padding(4);
            this.ValorPagar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ValorPagar.Name = "ValorPagar";
            this.ValorPagar.Size = new System.Drawing.Size(285, 22);
            this.ValorPagar.TabIndex = 4;
            // 
            // tabLista
            // 
            this.tabLista.Controls.Add(this.button4);
            this.tabLista.Controls.Add(this.button2);
            this.tabLista.Controls.Add(this.button1);
            this.tabLista.Controls.Add(this.btnAlterar);
            this.tabLista.Controls.Add(this.dgvLista);
            this.tabLista.Location = new System.Drawing.Point(4, 25);
            this.tabLista.Margin = new System.Windows.Forms.Padding(4);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(4);
            this.tabLista.Size = new System.Drawing.Size(1054, 560);
            this.tabLista.TabIndex = 1;
            this.tabLista.Text = "Lista";
            this.tabLista.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(12, 3);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 43);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AutoGenerateColumns = false;
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
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLista.Location = new System.Drawing.Point(4, 52);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(1046, 504);
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 43);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar Filtros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 306);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "&Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 43);
            this.button4.TabIndex = 4;
            this.button4.Text = "Apagar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 589);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorPagar)).EndInit();
            this.tabLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDespSource)).EndInit();
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
    }
}