using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Krypton.Modelo.Table
{
    public interface Table<T, K>
    {
        //T -> el tipo de dato del modelo
        //K -> el tipo de dato de la llave primaria

        ///<summary>
        ///Inserta el objeto pasado por parámetro en la tabla
        ///</summary>
        ///<param name="obj"></param>
        void Insertar(T obj);

        ///<summary>
        ///Modifica el objeto pasado por parámetro en la tabla
        /// </summary>
        /// <param name="obj"></param>
        void Modifificar(T obj);

        /// <summary>
        /// Elimina el objeto pasado por parámetro en la tabla
        /// </summary>
        /// <param name="obj"></param>
        void Eliminar(T obj);

        /// <summary>
        /// Regresa una lista con todos las tuplas de la tabla
        /// </summary>
        /// <returns>Una lista con todas las tuplas de la tabla</returns>
        List<T> ObtenerTodos();

        /// <summary>
        /// Regresa la tupla según el Id pasado por parámetro
        /// </summary>
        /// <param name="id"></param>
        /// <returns>La tupla específicada por el Id</returns>
        T Obtener(K id);
    }
}
