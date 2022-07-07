using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GG.Formularios.BOH
{
    public partial class Index : Form
    {
        private string token;
        public Index(string token)
        {
            InitializeComponent();
            this.token = token;
            Negocio.Empleados_Login.RefreshStatusToken(token);
        }
        #region Metodos de comportamiento
        //Variable para determinar si el usuario lo cerro por boton o por teclado forzado
        public bool Cerradoporbotonera = false;
        private void Index_Shown(object sender, EventArgs e)
        {
            cambiartamaño_button_Click(sender, e);
        }
        private void Index_Load(object sender, EventArgs e)
        {    
            
        }
        /// <summary>
        /// Valida los formularios abiertos en el contenedor central y devuelve el valor de la busqueda
        /// </summary>
        /// <param name="name">Nombre del formulario</param>
        /// <returns></returns>
        private bool HayUnoAbierto(string name)
        {   //Recorremos los formularios que hay dentro del contenedor central para validar si existe
            foreach (Form form in Contendedor_central.Controls)
            {
                if(form.Name == name) { return true;}
            }
            //si no encontramos nada regresaremos que es falso
            return false;
        }
        /// <summary>
        /// Ajusta el formulario a la configuracion correcta para agregarlo al contenedor principal
        /// </summary>
        /// <param name="formularioaAbrir">la instancia del formulario</param>
        private void AperturaForm(Form formularioaAbrir)
        {
            formularioaAbrir.TopLevel = false;
            formularioaAbrir.FormBorderStyle = FormBorderStyle.None;
            Contendedor_central.Controls.Add(formularioaAbrir);
            formularioaAbrir.Show();
            formularioaAbrir.WindowState = FormWindowState.Maximized;
        }
        /// <summary>
        /// Validaremos si el usuario cerro con los botones configurados o con teclado, o cierre forzado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!Cerradoporbotonera)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Metodos de la Botonera

        private void InformeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            //Validamos si no existe un formulario
            if (!HayUnoAbierto("Articulos"))
            {   //Creamos instancia del formulario seleccionado y la pasamos a configurar para ingresarlo al contenedor principal
                Catalogos.Articulos articulos = new Catalogos.Articulos();
                AperturaForm(articulos);
            }
            Cursor = Cursors.Default;
        }

        private void CerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            Cerradoporbotonera = true;
            this.Close();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cerradoporbotonera = true;
            Application.Exit();
        }
        #endregion
    }
}
