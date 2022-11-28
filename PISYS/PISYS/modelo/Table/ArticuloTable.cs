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
        private const string UPDATE = "UPDATE Articulo SET descripcion=";
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
