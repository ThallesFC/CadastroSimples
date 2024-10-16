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
    public partial class Resultadoforms : Form
    {
        public Resultadoforms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buscarforms form5 = new Buscarforms();
            form5.Show();
            this.Hide();
        }
    }
}
