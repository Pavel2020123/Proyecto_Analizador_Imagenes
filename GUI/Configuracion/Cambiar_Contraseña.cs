using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Configuracion
{
    public partial class Cambiar_Contraseña : Form
    {
        public Cambiar_Contraseña()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion1 f14 = new Configuracion1();
            f14.ShowDialog();
            this.Show();
        }
    }
}
