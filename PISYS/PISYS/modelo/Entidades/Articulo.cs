using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISYS.modelo
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Medida { get; set; }
        public int CantExistencia { get; set; }
        public decimal CostoCompra { get; set; }
        public decimal CostoDolares { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Estado { get; set; }
    }
}
