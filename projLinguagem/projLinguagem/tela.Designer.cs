namespace projLinguagem
{
    partial class tela
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPontuacao = new System.Windows.Forms.TextBox();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gvLinguagem = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvLinguagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(5, 22);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(73, 15);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtPontuacao
            // 
            this.txtPontuacao.Location = new System.Drawing.Point(73, 74);
            this.txtPontuacao.Name = "txtPontuacao";
            this.txtPontuacao.Size = new System.Drawing.Size(100, 20);
            this.txtPontuacao.TabIndex = 2;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Location = new System.Drawing.Point(8, 81);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(59, 13);
            this.lblPontuacao.TabIndex = 3;
            this.lblPontuacao.Text = "Pontuação";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(115, 118);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gvLinguagem
            // 
            this.gvLinguagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLinguagem.Location = new System.Drawing.Point(34, 149);
            this.gvLinguagem.Name = "gvLinguagem";
            this.gvLinguagem.Size = new System.Drawing.Size(253, 150);
            this.gvLinguagem.TabIndex = 5;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(212, 118);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 311);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.gvLinguagem);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblPontuacao);
            this.Controls.Add(this.txtPontuacao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "tela";
            this.Text = "ProjLinguagem";
            ((System.ComponentModel.ISupportInitialize)(this.gvLinguagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPontuacao;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView gvLinguagem;
        private System.Windows.Forms.Button btnSair;
    }
}

