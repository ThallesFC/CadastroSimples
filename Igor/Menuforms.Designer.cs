namespace Igor
{
    partial class Menuforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuforms));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarAPaginaAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localizarCadastroToolStripMenuItem,
            this.editarCadastroToolStripMenuItem,
            this.voltarAPaginaAnteriorToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // localizarCadastroToolStripMenuItem
            // 
            this.localizarCadastroToolStripMenuItem.Name = "localizarCadastroToolStripMenuItem";
            this.localizarCadastroToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.localizarCadastroToolStripMenuItem.Text = "Localizar Cadastro";
            this.localizarCadastroToolStripMenuItem.Click += new System.EventHandler(this.localizarCadastroToolStripMenuItem_Click);
            // 
            // editarCadastroToolStripMenuItem
            // 
            this.editarCadastroToolStripMenuItem.Name = "editarCadastroToolStripMenuItem";
            this.editarCadastroToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.editarCadastroToolStripMenuItem.Text = "Editar Cadastro";
            this.editarCadastroToolStripMenuItem.Click += new System.EventHandler(this.editarCadastroToolStripMenuItem_Click);
            // 
            // voltarAPaginaAnteriorToolStripMenuItem
            // 
            this.voltarAPaginaAnteriorToolStripMenuItem.Name = "voltarAPaginaAnteriorToolStripMenuItem";
            this.voltarAPaginaAnteriorToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.voltarAPaginaAnteriorToolStripMenuItem.Text = "Voltar a Pagina Anterior";
            this.voltarAPaginaAnteriorToolStripMenuItem.Click += new System.EventHandler(this.voltarAPaginaAnteriorToolStripMenuItem_Click);
            // 
            // Menuforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menuforms";
            this.Text = "Menuforms";
            this.Load += new System.EventHandler(this.Menuforms_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarAPaginaAnteriorToolStripMenuItem;
    }
}