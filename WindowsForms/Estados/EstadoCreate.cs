using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.Estados
{
    public partial class EstadoCreate : Form
    {
        public EstadoCreate()
        {
            InitializeComponent();
        }

        private void btnGuardar(object sender, EventArgs e)
        {

        }

        private void btnRegresar(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            main.Show();
            this.Close();
        }
    }
}
