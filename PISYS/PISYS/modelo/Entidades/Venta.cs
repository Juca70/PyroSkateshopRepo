using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISYS.modelo
{
    public class Venta
    {
        public int ID { get; set; }
        public Usuario usuario { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }
        public string TipoPago { get; set; }
        public decimal Total { get; set; }
        public string Estado { get; set; }
    }
}
