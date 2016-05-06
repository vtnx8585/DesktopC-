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
using WindowsForms.DataAccess.Connection;
using WindowsForms.DataAccess.DataTableStructure;

namespace WindowsForms.Estados
{
    public partial class EstadosIndex : Form
    {
        public EstadosIndex()
        {
            InitializeComponent();
            SqlConn sqlconnection = new SqlConn();
            SqlConnection conn = sqlconnection.OpenConnection();

            DataTable dtEstado = new DataTable();
            DataTableStructureEstado dtStructureEstado = new DataTableStructureEstado();

            String qry = "Select id_estado as IdEstado,est_nombre as Nombre, est_descripcion as Descripcion from Colegio.dbo.estado";

            SqlTransaction transaction = conn.BeginTransaction(IsolationLevel.Serializable);
            SqlCommand command = new SqlCommand(qry,conn, transaction);
                      
            
                  
            SqlDataAdapter sqladapter = new SqlDataAdapter(command);            
            dtEstado = dtStructureEstado.dtReadEstado();
            sqladapter.Fill(dtEstado);
            grdEstadoIndex.DataSource = dtEstado;

            cbEstados.DataSource = dtEstado;
            cbEstados.ValueMember = "IdEstado";
            cbEstados.DisplayMember = "Nombre";

            sqlconnection.CloseConnection();
            command.Dispose();                 
        }

        private void UpdateEstado(object sender, EventArgs e)
        {
            int idEstado = Convert.ToInt32(grdEstadoIndex.CurrentRow.Cells[0].Value);
            EstadoUpdate UpdateForm = new EstadoUpdate(idEstado);
            this.Hide();
            UpdateForm.ShowDialog();
            this.Show();
        }
    }
}
