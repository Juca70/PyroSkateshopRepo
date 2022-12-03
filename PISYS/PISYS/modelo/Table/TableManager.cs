using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISYS.modelo.Table
{
    public class TableManager
    {
        /*
         * Pon aquí tu liga de conexión al servidor de SQL Server
         */
        private const string stringConnection = 
            "Server=localhost\\SQLEXPRESS;Database=pyrodatabase;Trusted_Connection=True;";

        private ArticuloTable articuloTable;

        private CategoriaTable categoriaTable;

        public void TryConnection()
        {
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(stringConnection);
                conn.Open();
                MessageBox.Show("Se conecto al servidor cone éxito", "Mensaje");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en la conexión");
            }
        }

        public ArticuloTable ArticuloTable 
        {
            get
            {
                if (articuloTable == null)
                {
                    return new ArticuloTable(stringConnection);
                }

                return articuloTable;
            }
        }

        public CategoriaTable Categoria
        {
            get
            {
                if (categoriaTable == null)
                {
                    return new CategoriaTable(stringConnection);
                }

                return categoriaTable;
            }
        }

        
    }
}
