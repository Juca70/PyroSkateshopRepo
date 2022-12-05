using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pyroskateshop_Inventory_System.Modelo.Table
{
    public class TableManager
    {
        private const string stringConnection = "Server=localhost\\SQLEXPRESS;Database=Pisys_db;Trusted_Connection=True;";

        private UsuarioTable usuarioTable;
        
        public void TryConnection()
        {
            SqlConnection conn = null; 
            
            try
            {
                conn = new SqlConnection(stringConnection);
                conn.Open();
                MessageBox.Show("Conexión establecida", "Éxito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falló la conexión", "Error");
            }

        }

        public UsuarioTable UsuarioTable
        {
            get
            {
                if (usuarioTable == null)
                {
                    return new UsuarioTable(stringConnection);
                }
                return usuarioTable;
            }
        }
    }
}
