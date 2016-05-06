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
    public partial class EstadoUpdate : Form
    {
        SqlConn sqlconnection = new SqlConn();        

        public EstadoUpdate(int idEstado)
        {
            InitializeComponent();
            SqlConnection conn = sqlconnection.OpenConnection();
            MessageBox.Show(idEstado.ToString());

            DataTable dtEstado = new DataTable();
            DataTableStructureEstado dtStructureEstado = new DataTableStructureEstado();

            dtEstado = dtStructureEstado.dtReadEstado();

            string qry = "Select id_estado as IdEstado, est_nombre as Nombre, est_descripcion as Descripcion";
            qry += " from Colegio.dbo.estado Where id_estado =" + idEstado;

            SqlCommand command = new SqlCommand(qry, conn);
            SqlDataAdapter sqladapter = new SqlDataAdapter(command);
            sqladapter.Fill(dtEstado);

            txtId.Text = dtEstado.Rows[0]["IdEstado"].ToString();
            txtNombreEstado.Text = dtEstado.Rows[0]["Nombre"].ToString();
            txtDescripcionEstado.Text = dtEstado.Rows[0]["Descripcion"].ToString();

            sqlconnection.CloseConnection();

        }

        private void btnGuardar(object sender, EventArgs e)
        {
            EstadosIndex indexForm = new EstadosIndex();

            try
            {
                int idEstado = Convert.ToInt32(txtId.Text);
                string Nombre = txtNombreEstado.Text;
                string Descripcion = txtDescripcionEstado.Text;

                //string qry = "Update Colegio.dbo.estado set est_nombre='" + Nombre + "',est_descripcion='" + Descripcion + "' where id_estado=" + idEstado;
                string qry = "Update Colegio.dbo.estado set est_nombre= @Nombre,est_descripcion= @Descripcion where id_estado= @idEstado";
                //string qry = "Update Colegio.dbo.estado set est_nombre='Mierda',est_descripcion='Solo prueba estupida' where id_estado=3";

                SqlConnection conn = sqlconnection.OpenConnection();                
                SqlCommand command = new SqlCommand(qry,conn);
                command.Parameters.AddWithValue("Nombre", Nombre);
                command.Parameters.AddWithValue("Descripcion", Descripcion);
                command.Parameters.AddWithValue("idEstado", idEstado);
                SqlTransaction sqltransaction = conn.BeginTransaction(IsolationLevel.Serializable);

                try
                {
                    command.ExecuteNonQuery();
                    sqltransaction.Commit();
                    sqlconnection.CloseConnection();
                    MessageBox.Show("Guardado con exito!");                                        
                }
                catch (Exception ex) {
                    sqltransaction.Rollback();
                    sqlconnection.CloseConnection();
                    MessageBox.Show("Error en la transaccion");
                    throw ex;                      
                }
                
            }
            catch (Exception ex) {
                throw ex;
            }

            indexForm.Show();
            this.Close();
        }
    }
}
