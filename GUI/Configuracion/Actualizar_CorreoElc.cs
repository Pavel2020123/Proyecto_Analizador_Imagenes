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
    public partial class Actualizar_CorreoElc : Form
    {
        public Actualizar_CorreoElc()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion1 f12 = new Configuracion1();
            f12.ShowDialog();
            this.Show();
        }
        // Prueba para que Git lo detecte

        private void Actualizar_CorreoElc_Load(object sender, EventArgs e)
        {

        }
    }
}
