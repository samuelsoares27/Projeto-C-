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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CADASTRO = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPagar = new System.Windows.Forms.Button();
            this.cbPagar = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpPagar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescPagar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorPagar = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.rbPagar = new System.Windows.Forms.RadioButton();
            this.rbbReceber = new System.Windows.Forms.RadioButton();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.CADASTRO.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorPagar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CADASTRO);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 5);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 512);
            this.tabControl1.TabIndex = 1;
            // 
            // CADASTRO
            // 
            this.CADASTRO.Controls.Add(this.panel1);
            this.CADASTRO.Location = new System.Drawing.Point(4, 25);
            this.CADASTRO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CADASTRO.Name = "CADASTRO";
            this.CADASTRO.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CADASTRO.Size = new System.Drawing.Size(784, 483);
            this.CADASTRO.TabIndex = 0;
            this.CADASTRO.Text = "tabPage1";
            this.CADASTRO.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(189, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 359);
            this.panel1.TabIndex = 1;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(126, 306);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cbPagar.Location = new System.Drawing.Point(256, 239);
            this.cbPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dtpPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.tbDescPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.ValorPagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ValorPagar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ValorPagar.Name = "ValorPagar";
            this.ValorPagar.Size = new System.Drawing.Size(285, 22);
            this.ValorPagar.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvLista);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(784, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLista.Location = new System.Drawing.Point(4, 4);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowTemplate.Height = 24;
            this.dgvLista.Size = new System.Drawing.Size(776, 475);
            this.dgvLista.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 519);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.CADASTRO.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ValorPagar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CADASTRO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.CheckBox cbPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescPagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ValorPagar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbbReceber;
        private System.Windows.Forms.RadioButton rbPagar;
        private System.Windows.Forms.DataGridView dgvLista;
    }
}