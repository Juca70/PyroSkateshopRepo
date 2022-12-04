using Ejemplo_Krypton.Modelo.Entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Krypton.Modelo.Table
{
    public class UsuarioTable : Table<Usuario, int>
    {
        private string stringConnection;

        private const string SELECT = "SELECT * FROM Usuario WHERE nombre=@username and contraseña=@password";

        public UsuarioTable(string stringConnection)
        {
            this.stringConnection = stringConnection;
        }

        public void Eliminar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Insertar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Modifificar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario Obtener(int id)
        {
            return null;
        }

        private Usuario Convertir(SqlDataReader reader)
        {
            Usuario obj = new Usuario();
            obj.Id = reader.GetInt32(0);
            obj.Nombre = reader.GetString(1);
            obj.Contraseña = reader.GetString(2);
            obj.FechaAlta = reader.GetString(3);
            obj.PreguntaRecup = reader.GetString(4);
            obj.RespuestaRecup = reader.GetString(5);
            obj.TipoUsuario = reader.GetString(6);
            return obj;
        }

        public Usuario Obtener(string username, string password)
        {
            Usuario usuario = null;
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                SqlCommand cmd = new SqlCommand(SELECT, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    usuario = Convertir(reader);
                }
            }

            return usuario;
        }

        public List<Usuario> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
