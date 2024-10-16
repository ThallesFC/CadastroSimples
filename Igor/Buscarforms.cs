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
    public partial class Buscarforms : Form
    {
        public Buscarforms()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtbuscaNome.Clear();
            txtbuscaUsuario.Clear();
            txtbuscaSenha.Clear();

            txtbuscaNome.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menuforms form2 = new Menuforms();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = getData();
        }

        private void Buscarforms_Load(object sender, EventArgs e)
        {
         
        }

        private DataTable getData()
        {
            DataTable dtTabela = new DataTable();
            SqlConnection conn3 = new SqlConnection("Data Source=DESKTOP-AVQC5G3\\SQLEXPRESS;Initial Catalog=TrabalhoIgor;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login_new", conn3);

            conn3.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            dtTabela.Load(reader);

            return dtTabela;
        }
    }
}
