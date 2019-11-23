namespace NubancoApp
{
    partial class FormLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnLogarCom = new System.Windows.Forms.Button();
            this.btnLogarSem = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lblSair = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = global::NubancoApp.Properties.Resources.Logo_XPEvents1;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // btnLogarCom
            // 
            this.btnLogarCom.BackColor = System.Drawing.Color.ForestGreen;
            resources.ApplyResources(this.btnLogarCom, "btnLogarCom");
            this.btnLogarCom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogarCom.Name = "btnLogarCom";
            this.btnLogarCom.UseVisualStyleBackColor = false;
            this.btnLogarCom.Click += new System.EventHandler(this.btnLogarCom_Click);
            // 
            // btnLogarSem
            // 
            this.btnLogarSem.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.btnLogarSem, "btnLogarSem");
            this.btnLogarSem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogarSem.Name = "btnLogarSem";
            this.btnLogarSem.UseVisualStyleBackColor = false;
            this.btnLogarSem.Click += new System.EventHandler(this.btnLogarSem_Click);
            // 
            // tbxEmail
            // 
            resources.ApplyResources(this.tbxEmail, "tbxEmail");
            this.tbxEmail.Name = "tbxEmail";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbxSenha
            // 
            resources.ApplyResources(this.tbxSenha, "tbxSenha");
            this.tbxSenha.Name = "tbxSenha";
            // 
            // lblSair
            // 
            resources.ApplyResources(this.lblSair, "lblSair");
            this.lblSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSair.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSair.Name = "lblSair";
            this.lblSair.Click += new System.EventHandler(this.LblSair_Click);
            // 
            // FormLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.lblSair);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnLogarSem);
            this.Controls.Add(this.btnLogarCom);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogarCom;
        private System.Windows.Forms.Button btnLogarSem;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label lblSair;
    }
}

