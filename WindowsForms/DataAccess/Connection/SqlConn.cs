using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsForms.DataAccess.Connection
{
    class SqlConn
    {
        public SqlConnection OpenConnection() {
            try
            {
                String connection = @"Data Source=RAGNAROK-PC\VITTOPRUEBAS;Initial Catalog=Colegio;User ID=sa;Password=tor85naj85alessa";
                SqlConnection conn = new SqlConnection(connection);
                conn.Open();
                return conn;                
            }
            catch (Exception ex) {
                throw ex;
                MessageBox.Show("Can not open connection ! ");
            }                
        }

        public void CloseConnection()
        {
            try
            {
                String connection = @"Data Source=RAGNAROK-PC\VITTOPRUEBAS;Initial Catalog=Colegio;User ID=sa;Password=tor85naj85alessa";
                SqlConnection conn = new SqlConnection(connection);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
