using PISYS.modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISYS.modelo.Table
{
    public class CategoriaTable 
    {
        private string stringConnection;

        private const string SELECTALL = "SELECT * FROM Categoria WHERE id=@id";

        public CategoriaTable(string stringConnection)
        {
            this.stringConnection = stringConnection;
        }

        public Categoria Obtener(int id)
        {
            Categoria categoria = null;

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTALL, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    categoria = new Categoria();
                    categoria.Id = reader.GetInt32(0);
                    categoria.Descripcion = reader.GetString(1);
                    categoria.Tipo = reader.GetString(2);
                }
            }

            return categoria;
        }
    }
}
