using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igor
{
    public partial class Cadastroforms : Form
    {
        public Cadastroforms()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            txtcadUsuario.Clear();
            txtcadSenha.Clear();
            txtcadNome.Clear();
            

            txtcadNome.Focus();
        }

        private void botaoRegistrar_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-AVQC5G3\\SQLEXPRESS;Initial Catalog=TrabalhoIgor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("INSERT INTO Login_new(nome,usuario,senha) VALUES('" + txtcadNome.Text + "','" + txtcadUsuario.Text + "','" + txtcadSenha.Text + "')", conn2);

            try
            {
                conn2.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro realizado!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro durante o cadastro!" + ex);
            }

            finally 
            { 
                conn2.Close(); 
            }
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            this.Hide();
        }
    }
}
