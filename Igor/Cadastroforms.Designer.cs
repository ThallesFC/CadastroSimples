namespace Igor
{
    partial class Cadastroforms
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
            this.cadUsuario = new System.Windows.Forms.Label();
            this.cadSenha = new System.Windows.Forms.Label();
            this.txtcadUsuario = new System.Windows.Forms.TextBox();
            this.txtcadSenha = new System.Windows.Forms.TextBox();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.botaoRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcadNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadUsuario
            // 
            this.cadUsuario.AutoSize = true;
            this.cadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadUsuario.Location = new System.Drawing.Point(181, 171);
            this.cadUsuario.Name = "cadUsuario";
            this.cadUsuario.Size = new System.Drawing.Size(79, 25);
            this.cadUsuario.TabIndex = 3;
            this.cadUsuario.Text = "Usuario";
            this.cadUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // cadSenha
            // 
            this.cadSenha.AutoSize = true;
            this.cadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadSenha.Location = new System.Drawing.Point(184, 214);
            this.cadSenha.Name = "cadSenha";
            this.cadSenha.Size = new System.Drawing.Size(70, 25);
            this.cadSenha.TabIndex = 4;
            this.cadSenha.Text = "Senha";
            // 
            // txtcadUsuario
            // 
            this.txtcadUsuario.Location = new System.Drawing.Point(300, 175);
            this.txtcadUsuario.Name = "txtcadUsuario";
            this.txtcadUsuario.Size = new System.Drawing.Size(219, 22);
            this.txtcadUsuario.TabIndex = 7;
            // 
            // txtcadSenha
            // 
            this.txtcadSenha.Location = new System.Drawing.Point(300, 218);
            this.txtcadSenha.Name = "txtcadSenha";
            this.txtcadSenha.Size = new System.Drawing.Size(219, 22);
            this.txtcadSenha.TabIndex = 8;
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(431, 284);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(88, 34);
            this.botaoLimpar.TabIndex = 10;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // botaoRegistrar
            // 
            this.botaoRegistrar.Location = new System.Drawing.Point(300, 284);
            this.botaoRegistrar.Name = "botaoRegistrar";
            this.botaoRegistrar.Size = new System.Drawing.Size(88, 34);
            this.botaoRegistrar.TabIndex = 9;
            this.botaoRegistrar.Text = "Registrar";
            this.botaoRegistrar.UseVisualStyleBackColor = true;
            this.botaoRegistrar.Click += new System.EventHandler(this.botaoRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre-se";
            // 
            // txtcadNome
            // 
            this.txtcadNome.Location = new System.Drawing.Point(300, 133);
            this.txtcadNome.Name = "txtcadNome";
            this.txtcadNome.Size = new System.Drawing.Size(219, 22);
            this.txtcadNome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // Voltar
            // 
            this.Voltar.Location = new System.Drawing.Point(364, 349);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(88, 34);
            this.Voltar.TabIndex = 11;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = true;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // Cadastroforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcadNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoRegistrar);
            this.Controls.Add(this.botaoLimpar);
            this.Controls.Add(this.txtcadSenha);
            this.Controls.Add(this.txtcadUsuario);
            this.Controls.Add(this.cadSenha);
            this.Controls.Add(this.cadUsuario);
            this.Name = "Cadastroforms";
            this.Text = "Cadastroforms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cadUsuario;
        private System.Windows.Forms.Label cadSenha;
        private System.Windows.Forms.TextBox txtcadUsuario;
        private System.Windows.Forms.TextBox txtcadSenha;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcadNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Voltar;
    }
}