using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISYS.modelo
{
    public class DetalleVenta
    {
        public IdDetalleVenta Id { get; set; }
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
    }

    public class IdDetalleVenta
    {
        public Venta Venta { get; set; }
        public Articulo Articulo { get; set; }
    }
}
