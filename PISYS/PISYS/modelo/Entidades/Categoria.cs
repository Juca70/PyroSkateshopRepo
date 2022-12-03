using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISYS.modelo.Entidades
{
    public class Categoria
    {   
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
    }
}
