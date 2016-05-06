using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsForms.DataAccess;

namespace WindowsForms.DataAccess.DataTableStructure
{
    class DataTableStructureEstado
    {
        public DataTable dtReadEstado()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("IdEstado", typeof(Int32));
                dt.Columns.Add("Nombre", typeof(String));
                dt.Columns.Add("Descripcion", typeof(String));
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
