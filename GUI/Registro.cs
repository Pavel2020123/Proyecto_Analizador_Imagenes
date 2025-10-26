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


    public partial class Registro : Form
    {

        ServicioUsuario servicio = new ServicioUsuario();

        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            try
            {
                if (txtCodigo.Text == string.Empty)
                {
                    return;
                }

                if (cmbTipoPiel.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor selecciona el tipo de piel.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Usuario usuario = new Usuario(int.Parse(txtCodigo.Text.Trim()), txtNombre.Text, txtCorreo.Text,
                                               DateTime.Parse(dtpFechaIngreso.Text.Trim()), cmbTipoPiel.Text);
                var mensaje = servicio.Guardar(usuario);
                MessageBox.Show(mensaje);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbTipoPiel_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }


        private void Nuevo()
        {
            txtCodigo.Text = string.Empty;
            txtNombre.Clear();
            txtCorreo.Clear();
            cmbTipoPiel.SelectedIndex = 0;
            dtpFechaIngreso.Value = DateTime.Now;
            txtCodigo.Focus();

        }

        private void Form4_Load(object sender, EventArgs e)
        {




            cmbTipoPiel.Items.Add("Piel seca");
            cmbTipoPiel.Items.Add("Piel grasa");
            cmbTipoPiel.Items.Add("Piel mixta");
            cmbTipoPiel.Items.Add("Piel normal");


            cmbTipoPiel.SelectedIndex = 0;


        }
    }
}
