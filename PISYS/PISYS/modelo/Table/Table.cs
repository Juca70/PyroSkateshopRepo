using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISYS
{
    public interface Table<T, K>
    {
        //T -> el tipo de dato del modelo
        //K -> el tipo de dato de la llave primaria

        //Inserta la información en la tabla de la base de datos
        void Insertar(T obj);
        //Modifica la información de una tupla en una tabla
        void Modifificar(T obj);
        //Elimina la información de una tupla en una tabla
        void Eliminar(T obj);
        //Obtiene todas la tuplas de una tabla en una tabla
        List<T> ObtenerTodos();
        //Obtienen una tupla en especifico
        T Obtener(K id);
        
    }
}
