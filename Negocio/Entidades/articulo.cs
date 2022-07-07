using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    class Articulo
    {
        public int ID { set; get; }
        public string Nombre { get; set; }
        public string Display { get; set; }
        public decimal Precio { get; set; }
        public int Impuestos { get; set; }
        public int Categoria { get; set; }
        public bool PrecioModificable { get; set; }
        public bool TieneModificadores { get; set; }
        public int[] Modificador { get; set; }
    }
}
