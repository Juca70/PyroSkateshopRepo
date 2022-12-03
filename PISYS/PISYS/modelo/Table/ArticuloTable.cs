using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISYS.modelo.Table
{
    public class ArticuloTable : Table<Articulo, int>
    {       
        private string stringConnection;

        private const string SELECTALL = 
            "SELECT " +
            "A.id, " +
            "C.descripcion, " +
            "C.tipo, " +
            "A.descripcion, " +
            "A.marca, " +
            "A.medida, " +
            "A.cant_existencias, " +
            "A.costo_compra, " +
            "A.costo_dolares, " +
            "A.precio_venta, " +
            "A.estado " +
            "FROM Articulo A INNER JOIN Categoria C ON A.categoria = C.id";

        private const string SELECTBYTIPO =
            SELECTALL + " WHERE C.tipo = @tipo";

        private const string SELECTBYCATEGORIA =
            SELECTALL + " WHERE C.descripcion = @descrip";

        private const string INSERT = 
            "INSERT INTO Articulo (categoria, descripcion, marca, medida, " +
            "cant_existencias, costo_compra, costo_dolares, precio_venta, estado) " +
            "values(@cat, @descrip, @marca, @medida, @cant, @costc, @costod, " +
            "@preciov, @estado)";

        private const string UPDATE =
            "UPDATE Articulo SET categoria = @cat, descripcion = @descrip, " +
            "marca = @marca, medida = @medida, cant_existencias = @cant," +
            "costo_compra = @costoc, costo_dolares = @costod, precio_venta = @preciov, " +
            "estado = @estado WHERE id = @id";

        private const string DELETE =
            "DELETE FROM Articulo WHERE id = @id";

        public ArticuloTable(string stringConnection)
        {
            this.stringConnection = stringConnection;
        }

        public void Eliminar(Articulo obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Articulo obj)
        {
            throw new NotImplementedException();
        }

        public void Modifificar(Articulo obj)
        {
            throw new NotImplementedException();
        }

        public Articulo Obtener(int id)
        {
            throw new NotImplementedException();
        }

        private Articulo Convertir(SqlDataReader reader)
        {
            Articulo obj = new Articulo();
            obj.Id = reader.GetInt32(0);
            obj.Categoria = reader.GetString(1);
            obj.Tipo = reader.GetString(2);
            obj.Descripcion = reader.GetString(3);
            obj.Marca = reader.GetString(4);
            obj.Medida = reader.GetString(5);
            obj.CantExistencia = reader.GetInt32(6);
            obj.CostoCompra = reader.GetDecimal(7);
            obj.CostoDolares = reader.GetDecimal(8);
            obj.PrecioVenta = reader.GetDecimal(9);
            obj.Estado = reader.GetString(10);
            return obj;
        }
        public List<Articulo> ObtenerTodos()
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conn = new SqlConnection(this.stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTALL, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    lista.Add(Convertir(reader));
                }
            }

            return lista;
        }
        
        public List<Articulo> ObtenerPorCategoria(string categoria)
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTBYCATEGORIA, conn);
                cmd.Parameters.AddWithValue("@descrip", categoria);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(Convertir(reader));
                }
            }

            return lista;
        }
    
        public List<Articulo> ObtenerPorTipo(string tipo)
        {
            List<Articulo> lista = new List<Articulo>();

            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECTBYTIPO, conn);
                cmd.Parameters.AddWithValue("@tipo", tipo);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(Convertir(reader));
                }
            }

            return lista;
        }
    }
}
