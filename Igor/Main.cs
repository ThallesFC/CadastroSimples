using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Igor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-AVQC5G3\\SQLEXPRESS;Initial Catalog=TrabalhoIgor;Integrated Security=True;Encrypt=False");

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void botaoEntrar_Click(object sender, EventArgs e)
        {
            string username, user_password;

            username = txtUsuario.Text;
            user_password = txtSenha.Text;

            try
            {
                string querry = "SELECT * FROM Login_new WHERE usuario = '" + txtUsuario.Text + "' AND senha = '" + txtSenha.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = txtUsuario.Text;
                    user_password = txtSenha.Text;

                    // pagina que deve ser carregada a seguir
                    Menuforms form2 = new Menuforms();
                    form2.Show();
                    this.Hide();

                }
                else {
                    MessageBox.Show("Invalid login details","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtSenha.Clear();

                    // para focar o usuario
                    txtUsuario.Focus();
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();

            txtUsuario.Focus();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Quer mesmo sair", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else{
                this.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cadastroforms form3 = new Cadastroforms();
            form3.Show();
            this.Hide();
        }
    }
}
