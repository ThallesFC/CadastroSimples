using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Igor
{
    public partial class Menuforms : Form
    {
        public Menuforms()
        {
            InitializeComponent();
        }

        private void Menuforms_Load(object sender, EventArgs e)
        {

        }

        private void localizarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscarforms form5 = new Buscarforms();
            form5.Show();
            this.Hide();
        }

        private void editarCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editarforms form4 = new Editarforms();
            form4.Show();
            this.Hide();
        }

        private void voltarAPaginaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main form1 = new Main();
            form1.Show();
            this.Hide();
        }
    }
}
