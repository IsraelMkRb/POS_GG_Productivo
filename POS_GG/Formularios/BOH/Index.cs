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

        private void cerrar_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrar_button_MouseMove(object sender, MouseEventArgs e)
        {
            cerrar_button.BackColor = Color.Red;
        }

        private void cerrar_button_MouseLeave(object sender, EventArgs e)
        {
            cerrar_button.BackColor = SystemColors.ActiveCaption;
        }

        private void cambiartamaño_button_Click(object sender, EventArgs e)
        {
            if(this.Size == Screen.PrimaryScreen.WorkingArea.Size)
            {
                //cuando el formulario cubra toda la pantalla ajustamos a tamaño original
                this.Size = new Size(923, 546);
                this.Location = new Point(50, 59);
            }
            else
            {
                this.Size = Screen.PrimaryScreen.WorkingArea.Size;
                this.Location = new Point(0, 0);
            }

            //ajustamos tamaño de contenedores
            Cabezera_contendedor.Width = this.Width;
            contenedor_opciones.Width = this.Width;
            Contendedor_central.Width = this.Width-2;
            Contendedor_central.Height = this.Height - Cabezera_contendedor.Height - contenedor_opciones.Height-2;
            //Ajustamos los controladores de cada contendedor
            //Cabezera
            cerrar_button.Location = new Point(this.Width-cerrar_button.Width,cerrar_button.Location.Y);
            cambiartamaño_button.Location = new Point(this.Width - cerrar_button.Width - cambiartamaño_button.Width, cambiartamaño_button.Location.Y);
            minimizar_button.Location = new Point(this.Width-cerrar_button.Width-cambiartamaño_button.Width-minimizar_button.Width,minimizar_button.Location.Y);

        }

        public int xClick = 0;
        public int yClick = 0;
        /// <summary>
        /// Funcion para mover el formulario cuando presionan la cebezera y mueven el mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cabezera_contendedor_MouseMove(object sender, MouseEventArgs e)
        {
            //Si al detectarse movimiento del raton pero no se tiene el boton izquierdo presionado, solo se registra el valor x y
            if (e.Button != MouseButtons.Left)
            { xClick = e.X; yClick = e.Y; }
            else //Pero si se encuentra presionado el boton izquierdo se pasan los valores x y del raton al formulario para que se mueva con el
            { this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick); }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Index_Load(object sender, EventArgs e)
        {
        }

        private void informeCuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
