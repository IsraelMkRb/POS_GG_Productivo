using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio.Catalogos.Articulos
{
    public static class Herramientas
    {
        /// <summary>
        /// Obtiene la lista total de los articulos registrados en sistema
        /// </summary>
        /// <returns></returns>
        public static List<general_Articulos> GetItems()
        {
            using (GemaEntities1 db = new GemaEntities1())
            {
                return db.general_Articulos.ToList();
            }
        }
        /// <summary>
        /// Devuelve la lista de modificador por Item que hay en sistema
        /// </summary>
        /// <returns></returns>
        public static List<general_Articulo_Modificador_Dtl> GetModPerItem()
        {
            using (GemaEntities1 db = new GemaEntities1())
            {
                return db.general_Articulo_Modificador_Dtl.ToList();
            }
        }
        /// <summary>
        /// Obtienes la lista de modificadores totales que hay en sistema
        /// </summary>
        /// <returns>Regresa un tipo list con los modificadores</returns>
        public static List<general_Modificadores> GetModificadores()
        {
            using (GemaEntities1 db = new GemaEntities1())
            {
                return db.general_Modificadores.ToList();
            }
        }
    }
}
