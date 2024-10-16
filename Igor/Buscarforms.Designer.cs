namespace Igor
{
    partial class Buscarforms
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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.Label();
            this.txtbUsuario = new System.Windows.Forms.Label();
            this.txtbuscaNome = new System.Windows.Forms.TextBox();
            this.txtbuscaUsuario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.trabalhoIgorDataSet = new Igor.TrabalhoIgorDataSet();
            this.trabalhoIgorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtbuscaSenha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoIgorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoIgorDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(265, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 307);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(345, 360);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Cadastros";
            // 
            // txtbNome
            // 
            this.txtbNome.AutoSize = true;
            this.txtbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNome.Location = new System.Drawing.Point(191, 172);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(64, 25);
            this.txtbNome.TabIndex = 1;
            this.txtbNome.Text = "Nome";
            // 
            // txtbUsuario
            // 
            this.txtbUsuario.AutoSize = true;
            this.txtbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbUsuario.Location = new System.Drawing.Point(185, 212);
            this.txtbUsuario.Name = "txtbUsuario";
            this.txtbUsuario.Size = new System.Drawing.Size(79, 25);
            this.txtbUsuario.TabIndex = 2;
            this.txtbUsuario.Text = "Usuario";
            // 
            // txtbuscaNome
            // 
            this.txtbuscaNome.Location = new System.Drawing.Point(265, 175);
            this.txtbuscaNome.Name = "txtbuscaNome";
            this.txtbuscaNome.Size = new System.Drawing.Size(251, 22);
            this.txtbuscaNome.TabIndex = 4;
            // 
            // txtbuscaUsuario
            // 
            this.txtbuscaUsuario.Location = new System.Drawing.Point(265, 215);
            this.txtbuscaUsuario.Name = "txtbuscaUsuario";
            this.txtbuscaUsuario.Size = new System.Drawing.Size(251, 22);
            this.txtbuscaUsuario.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(607, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 324);
            this.dataGridView1.TabIndex = 10;
            // 
            // trabalhoIgorDataSet
            // 
            this.trabalhoIgorDataSet.DataSetName = "TrabalhoIgorDataSet";
            this.trabalhoIgorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trabalhoIgorDataSetBindingSource
            // 
            this.trabalhoIgorDataSetBindingSource.DataSource = this.trabalhoIgorDataSet;
            this.trabalhoIgorDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // txtbuscaSenha
            // 
            this.txtbuscaSenha.Location = new System.Drawing.Point(265, 254);
            this.txtbuscaSenha.Name = "txtbuscaSenha";
            this.txtbuscaSenha.Size = new System.Drawing.Size(251, 22);
            this.txtbuscaSenha.TabIndex = 6;
            // 
            // Buscarforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1098, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtbuscaSenha);
            this.Controls.Add(this.txtbuscaUsuario);
            this.Controls.Add(this.txtbuscaNome);
            this.Controls.Add(this.txtbUsuario);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Name = "Buscarforms";
            this.Text = "Buscarforms";
            this.Load += new System.EventHandler(this.Buscarforms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoIgorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trabalhoIgorDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtbNome;
        private System.Windows.Forms.Label txtbUsuario;
        private System.Windows.Forms.TextBox txtbuscaNome;
        private System.Windows.Forms.TextBox txtbuscaUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trabalhoIgorDataSetBindingSource;
        private TrabalhoIgorDataSet trabalhoIgorDataSet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbuscaSenha;
    }
}