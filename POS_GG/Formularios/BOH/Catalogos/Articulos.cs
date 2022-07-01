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

namespace POS_GG.Formularios.BOH.Catalogos
{
    public partial class Articulos : Form
    {
        public Articulos()
        {
            InitializeComponent();
        }

        private void Articulos_Resize(object sender, EventArgs e)
        {
            //Ajustamos tamaño del indice donde aparecen todos los articulos
            Indice.Height = this.Height - (Indice.Location.Y - this.Location.Y) * 2;
            //Ajustamos el tamaño del formulario
            FormularioArticulos.Location = new Point(Indice.Width + 30, FormularioArticulos.Location.Y);
            FormularioArticulos.Height = this.Height - (FormularioArticulos.Location.Y - this.Location.Y) * 2;
            FormularioArticulos.Width = this.Width - Indice.Width - 50;
            //Ajustamos general
            foreach (Control control in FormularioArticulos.SelectedTab.Controls)
            {
                
            }
        }

        private void General_pag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Indice_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Articulos_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(this.ClientRectangle,
                                                                                        Color.White,Color.Gray, 90);
            //Color.FromArgb(192, 192, 255)
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
        
    }
}
