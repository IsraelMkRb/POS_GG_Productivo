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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Cerrar_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ingresar_button_Click(object sender, EventArgs e)
        {
            //Obtenemos el listado de empleados con login desde la bd
           List<Datos.empleados_login_dtl> infologinempleados = Negocio.Empleados_Login.Get();
            //Recorremos el listado de datos 
            foreach (var empleado in infologinempleados)
            {
                if(empleado.passwordlogin == password_textbox.Text && empleado.userlogin == user_textbox.Text)
                {   //Si existe una configuracion de login igual al ingresado
                    //creamos token de usuario
                    string token = Negocio.Empleados_Login.GetToken(empleado.ID);
                    //Creamos la instancia para abrir el formulario principal y le pasamos el token generado
                    //Le pasamos el formulario de login por si cierran sesion, este regrese.
                    Index ingresoindex = new Index(token);
                    //mostramos index y escondemos login.
                    ingresoindex.Show();
                    this.Hide();                    
                }
                else
                {
                    //Enviamos mensaje de error de login y reseteamos espacio de texto
                    MessageBox.Show("Usuario o contraseña equivocado, favor de verificar","Usuario no encontrado");
                    user_textbox.Text = "";
                    password_textbox.Text = "";
                    user_textbox.Focus();
                }
            }
        }

        private void user_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                //Si presionan Enter mientras este en el textbox de usuario mandamos llamar la funcion de validar ingreso
                Ingresar_button_Click(sender,new EventArgs());
            }
        }
        
        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                //Si presionan Enter mientras este en el textbox de contraseña mandamos llamar la funcion de validar ingreso
                Ingresar_button_Click(sender, new EventArgs());
            }
        }
    }
}
