using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            int x = (this.Size.Width - Contenedor_Central.Width) / 2;
            int y = (this.Size.Height - Contenedor_Central.Height) / 2;

            Contenedor_Central.Location = new Point(x, y);
        }
    }
}
