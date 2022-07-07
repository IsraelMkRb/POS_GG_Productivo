using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Negocio.Catalogos.Articulos;

namespace POS_GG.Formularios.BOH.Catalogos
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Articulos_Load(object sender, EventArgs e)
        {
            //Obtenemos la coleccion completa de articulos de la base de datos
            List<Datos.general_Articulos> ListaDeArticulos = Herramientas.GetItems();
            /*Recorremos la lista de articulos y se llenamos el indice que aparece a la izquierda
              Para la visualizacion de todos los articulos */
            for (int i = 0; i < ListaDeArticulos.Count; i++)
            {
                Indice.Rows.Add(ListaDeArticulos[i].ID,ListaDeArticulos[i].Nombre);
            }
            //Rellenamos los campos de inicio.
            ID.Text = ListaDeArticulos[0].ID.ToString();
            nombre.Text = ListaDeArticulos[0].Nombre;
            display.Text = ListaDeArticulos[0].Display;
            precio.Text = "$ " + ListaDeArticulos[0].Precio.ToString();
            PrecioModificable.Checked = ListaDeArticulos[0].Precio_Modificable;
            //Obtenemos la coleccion de Modificadores por Articulo
            List<Datos.general_Articulo_Modificador_Dtl> modificadoresPorItem = Herramientas.GetModPerItem();
            //Obtenemos la coleccion de todos los modificadores
            List<Datos.general_Modificadores> modificadores = Herramientas.GetModificadores();
            //Hacemos un array de los combobox que tenemos de Modificadores para recorrerlos
            ComboBox[] ListadeCBModificadores = { Modificador1,Modificador2,Modificador3,Modificador4,Modificador5 };
            //Rellenamos todos los espacios de Modificadores del formulario
            for (int i = 0; i < ListadeCBModificadores.Length; i++)
            {
                for (int r = 0; r < modificadores.Count; r++)
                {
                    string textoDelRegistro = $"{ modificadores[r].ID } { modificadores[r].Nombre }";
                    ListadeCBModificadores[i].Items.Add(textoDelRegistro);
                }
            }

        }


        #endregion
    }
}
