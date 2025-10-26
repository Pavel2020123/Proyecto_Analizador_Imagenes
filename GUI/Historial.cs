using ENTITY;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Historial : Form
    {

        ServicioUsuario servicio = new ServicioUsuario();

        public Historial()
        {
            InitializeComponent();
        }

        private void dgvHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {

            List<Usuario> listaUsuarios = servicio.ObtenerTodas();
            dgvHistorial.DataSource = listaUsuarios;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
