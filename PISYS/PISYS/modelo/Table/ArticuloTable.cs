using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISYS.modelo.Table
{
    public class ArticuloTable : Table<Articulo, int>
    {
        private const string INSERT = "INSERT INTO Articulo (descripcion, tipo, categoria, marca, " +
            "medida, cant_existencia, precio_venta, precio_dolares, costo_compra, estado)";
        
        private const string UPDATE = "UPDATE Articulo SET descripcion=@descrip, tipo=@tipo, categoria=@cat, " +
            "marca=@marca, medida=@medida, cant_existencia=@cant, precio_venta=@precio_v, precio_dolares=@precio_d, " +
            "consto_compra=@costo_c, estado=@estado";

        private const string DELETE = "DELETE FROM Articulo WHERE id=@id";

        private const string SELECTALL = "SELECT * FROM Articulo";

        private const string SELECTBYTIPO = "SELECT * FROM Articulo WHERE tipo=@tipo";

        private const string SELECTBYCAT = "SELECT * FROM Articulo WHERE categoria=@cat";

        private string stringConnection;

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

        public List<Articulo> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
