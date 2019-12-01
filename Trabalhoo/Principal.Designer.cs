namespace Trabalhoo
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RecDespSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblreceber = new System.Windows.Forms.Label();
            this.lblpagar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbPagarReceber = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnSemFiltro = new System.Windows.Forms.Button();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
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
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDespSource)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 590);
            this.tabControl1.TabIndex = 1;
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.SystemColors.Window;
            this.tabLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabLista.Controls.Add(this.panel4);
            this.tabLista.Controls.Add(this.panel3);
            this.tabLista.Controls.Add(this.panel2);
            this.tabLista.Location = new System.Drawing.Point(4, 25);
            this.tabLista.Margin = new System.Windows.Forms.Padding(4);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(4);
            this.tabLista.Size = new System.Drawing.Size(1008, 561);
            this.tabLista.TabIndex = 1;
            this.tabLista.Text = "Lista";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvLista);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(4, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 438);
            this.panel4.TabIndex = 10;
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.AutoGenerateColumns = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.dgvLista.DataSource = this.RecDespSource;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(0, 0);
            this.dgvLista.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLista.MultiSelect = false;
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(1000, 438);
            this.dgvLista.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "id";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "valor";
            this.Column1.HeaderText = "Valor";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Tipo";
            this.Column2.HeaderText = "Tipo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "descricao";
            this.Column3.HeaderText = "Descrição";
            this.Column3.Name = "Column3";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "vencimento";
            this.Column6.HeaderText = "Vencimento";
            this.Column6.Name = "Column6";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "lancamento";
            this.Column4.HeaderText = "Lançamento";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Efetuada";
            this.Column5.HeaderText = "Efetuada";
            this.Column5.Name = "Column5";
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblreceber);
            this.panel3.Controls.Add(this.lblpagar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(4, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 65);
            this.panel3.TabIndex = 9;
            // 
            // lblreceber
            // 
            this.lblreceber.AutoSize = true;
            this.lblreceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreceber.ForeColor = System.Drawing.Color.Green;
            this.lblreceber.Location = new System.Drawing.Point(205, 25);
            this.lblreceber.Name = "lblreceber";
            this.lblreceber.Size = new System.Drawing.Size(185, 25);
            this.lblreceber.TabIndex = 9;
            this.lblreceber.Text = "Contas a Receber";
            // 
            // lblpagar
            // 
            this.lblpagar.AutoSize = true;
            this.lblpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpagar.ForeColor = System.Drawing.Color.Red;
            this.lblpagar.Location = new System.Drawing.Point(17, 25);
            this.lblpagar.Name = "lblpagar";
            this.lblpagar.Size = new System.Drawing.Size(162, 25);
            this.lblpagar.TabIndex = 8;
            this.lblpagar.Text = "Contas a Pagar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbPagarReceber);
            this.panel2.Controls.Add(this.btnCadastrar);
            this.panel2.Controls.Add(this.btnApagar);
            this.panel2.Controls.Add(this.btnSemFiltro);
            this.panel2.Controls.Add(this.btnFiltro);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 50);
            this.panel2.TabIndex = 8;
            // 
            // cbbPagarReceber
            // 
            this.cbbPagarReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPagarReceber.FormattingEnabled = true;
            this.cbbPagarReceber.Location = new System.Drawing.Point(787, 7);
            this.cbbPagarReceber.Name = "cbbPagarReceber";
            this.cbbPagarReceber.Size = new System.Drawing.Size(209, 37);
            this.cbbPagarReceber.TabIndex = 11;
            this.cbbPagarReceber.SelectedIndexChanged += new System.EventHandler(this.cbbPagarReceber_SelectedIndexChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 2);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 43);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnApagar.Location = new System.Drawing.Point(249, 2);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(117, 43);
            this.btnApagar.TabIndex = 9;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSemFiltro
            // 
            this.btnSemFiltro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSemFiltro.FlatAppearance.BorderSize = 0;
            this.btnSemFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemFiltro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnSemFiltro.Location = new System.Drawing.Point(494, 2);
            this.btnSemFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSemFiltro.Name = "btnSemFiltro";
            this.btnSemFiltro.Size = new System.Drawing.Size(135, 43);
            this.btnSemFiltro.TabIndex = 8;
            this.btnSemFiltro.Text = "Limpar Filtros";
            this.btnSemFiltro.UseVisualStyleBackColor = false;
            this.btnSemFiltro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFiltro.FlatAppearance.BorderSize = 0;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.SystemColors.Window;
            this.btnFiltro.Location = new System.Drawing.Point(371, 2);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(117, 43);
            this.btnFiltro.TabIndex = 7;
            this.btnFiltro.Text = "Filtrar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAlterar.Location = new System.Drawing.Point(126, 2);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(117, 43);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.SystemColors.Highlight;
            this.tabCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCadastro.Controls.Add(this.panel1);
            this.tabCadastro.Location = new System.Drawing.Point(4, 25);
            this.tabCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastro.Size = new System.Drawing.Size(1008, 561);
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
            this.panel1.Location = new System.Drawing.Point(309, 87);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 359);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Brown;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(205, 295);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 39);
            this.button3.TabIndex = 15;
            this.button3.Text = "&Cancelar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbbReceber
            // 
            this.rbbReceber.AutoSize = true;
            this.rbbReceber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbbReceber.Location = new System.Drawing.Point(63, 265);
            this.rbbReceber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbbReceber.Name = "rbbReceber";
            this.rbbReceber.Size = new System.Drawing.Size(77, 21);
            this.rbbReceber.TabIndex = 14;
            this.rbbReceber.TabStop = true;
            this.rbbReceber.Text = "Receita";
            this.rbbReceber.UseVisualStyleBackColor = true;
            // 
            // rbPagar
            // 
            this.rbPagar.AutoSize = true;
            this.rbPagar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbPagar.Location = new System.Drawing.Point(63, 238);
            this.rbPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPagar.Name = "rbPagar";
            this.rbPagar.Size = new System.Drawing.Size(85, 21);
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
            this.label7.Location = new System.Drawing.Point(23, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 29);
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
            this.btnPagar.Location = new System.Drawing.Point(59, 295);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(139, 39);
            this.btnPagar.TabIndex = 11;
            this.btnPagar.Text = "&Salvar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cbPagar
            // 
            this.cbPagar.AutoSize = true;
            this.cbPagar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbPagar.Location = new System.Drawing.Point(235, 250);
            this.cbPagar.Margin = new System.Windows.Forms.Padding(4);
            this.cbPagar.Name = "cbPagar";
            this.cbPagar.Size = new System.Drawing.Size(104, 21);
            this.cbPagar.TabIndex = 10;
            this.cbPagar.Text = "Conta Paga";
            this.cbPagar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
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
            this.dtpPagar.Location = new System.Drawing.Point(59, 198);
            this.dtpPagar.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPagar.Name = "dtpPagar";
            this.dtpPagar.Size = new System.Drawing.Size(285, 22);
            this.dtpPagar.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(60, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição";
            // 
            // tbDescPagar
            // 
            this.tbDescPagar.Location = new System.Drawing.Point(59, 138);
            this.tbDescPagar.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescPagar.Name = "tbDescPagar";
            this.tbDescPagar.Size = new System.Drawing.Size(285, 22);
            this.tbDescPagar.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(60, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // ValorPagar
            // 
            this.ValorPagar.DecimalPlaces = 2;
            this.ValorPagar.Location = new System.Drawing.Point(59, 84);
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 590);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDespSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource RecDespSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn lancamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Quitada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnSemFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblreceber;
        private System.Windows.Forms.Label lblpagar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.ComboBox cbbPagarReceber;
    }
}