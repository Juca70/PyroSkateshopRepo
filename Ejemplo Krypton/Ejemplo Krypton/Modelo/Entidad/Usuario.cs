using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Krypton.Modelo.Entidad
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contraseña { get; set; }
        public string FechaAlta { get; set; }
        public string PreguntaRecup { get; set; }
        public string RespuestaRecup { get; set; }
        public string TipoUsuario { get; set; }
    }
}
