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
    public partial class Configuracion1 : Form
    {
        public Configuracion1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cambiar_Usuario f7 = new Cambiar_Usuario();
            f7.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cambiar_Contraseña f8 = new Cambiar_Contraseña();
            f8.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actualizar_CorreoElc f9 = new Actualizar_CorreoElc();
            f9.ShowDialog();
            this.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eliminar_Cuenta f10 = new Eliminar_Cuenta();
            f10.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cargar_Img f11 = new Cargar_Img();
            f11.ShowDialog();
            this.Show();
        }
    }
}
