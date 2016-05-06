using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms.Estados;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstados(object sender, EventArgs e)
        {
            EstadosIndex estadoForm = new EstadosIndex();
            this.Hide();
            estadoForm.ShowDialog();
            this.Show();            
        }
    }
}
