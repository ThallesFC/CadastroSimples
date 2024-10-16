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
    public partial class Editarforms : Form
    {
        public Editarforms()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txteditNome.Clear();
            txteditUsuario.Clear();
            txteditSenha.Clear();

            txteditNome.Focus();
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            Menuforms form2 = new Menuforms();
            form2.Show();
            this.Hide();
        }

        private void bntcadDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn2 = new SqlConnection("Data Source=DESKTOP-AVQC5G3\\SQLEXPRESS;Initial Catalog=TrabalhoIgor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("DELETE FROM Login_new WHERE usuario = '" + txteditUsuario.Text + "'", conn2);

            try
            {
                conn2.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Exclusão de cadastro realizada!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro durante a exclusão do cadastro!" + ex);
            }

            finally
            {
             conn2.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn4 = new SqlConnection("Data Source=DESKTOP-AVQC5G3\\SQLEXPRESS;Initial Catalog=TrabalhoIgor;Integrated Security=True");

           string query = "UPDATE Login_new SET nome = @nome, usuario = @usuario, senha = @senha WHERE nome = @nome OR usuario = @usuario";

            SqlCommand cmd = new SqlCommand(query, conn4);
            cmd.Parameters.AddWithValue("@nome", this.txteditNome.Text);
            cmd.Parameters.AddWithValue("@usuario", this.txteditUsuario.Text);
            cmd.Parameters.AddWithValue("@senha", this.txteditSenha.Text);

            try
            {
                conn4.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Atualização realizada com sucesso!");
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Ocorreu um erro durante a atualização. Por favor, tente novamente."+ex);
            }
            finally
            {
                conn4.Close();
            }
        }


    }
}