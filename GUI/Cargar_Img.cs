using GUI.Configuracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Cargar_Img : Form
    {




        public Cargar_Img()
        {
            InitializeComponent();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Historial f5 = new Historial();
            f5.ShowDialog();
            this.Show();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion1 f6 = new Configuracion1();
            f6.ShowDialog();
            this.Show();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private async void btnAnalizar_Click(object sender, EventArgs e)
        {
            try
            {
                rtbResultado.ReadOnly = true;
                string predictionKey = "9c9f4e05714044baa131c6ec6c9b765e";
                string predictionEndpoint = "https://southcentralus.api.cognitive.microsoft.com/customvision/v3.0/Prediction/341ae276-7977-4abe-98ac-7e3b94b2975b/classify/iterations/Iteration4/image";

                string imagePath = pbFoto.ImageLocation;
                if (string.IsNullOrEmpty(imagePath) || !File.Exists(imagePath))
                {
                    MessageBox.Show("Primero selecciona una imagen válida.");
                    return;
                }

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Prediction-Key", predictionKey);

                    byte[] imageData = File.ReadAllBytes(imagePath);
                    using (var content = new ByteArrayContent(imageData))
                    {
                        content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                        var response = await httpClient.PostAsync(predictionEndpoint, content);
                        string result = await response.Content.ReadAsStringAsync();

                        rtbResultado.Clear();

                        using (var doc = JsonDocument.Parse(result))
                        {
                            var predictions = doc.RootElement.GetProperty("predictions");

                            rtbResultado.SelectionFont = new Font("Segoe UI", 13, FontStyle.Bold);
                            rtbResultado.SelectionColor = Color.Black;
                            rtbResultado.AppendText("🔍 RESULTADOS DEL ANÁLISIS\n\n");

                            foreach (var pred in predictions.EnumerateArray())
                            {
                                string tag = pred.GetProperty("tagName").GetString();
                                double prob = pred.GetProperty("probability").GetDouble() * 100;

                                Color color = prob >= 80 ? Color.Green :
                                              prob >= 50 ? Color.Orange :
                                              Color.Gray;

                                rtbResultado.SelectionFont = new Font("Segoe UI", 12, FontStyle.Regular);
                                rtbResultado.SelectionColor = color;
                                rtbResultado.AppendText($"🧠 {tag}: {prob:F2}%\n");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al analizar la imagen: " + ex.Message);
            }
        }


        private void btnSubii_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            var ruta = ofd.FileName;
            pbFoto.ImageLocation = ruta;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnInicioLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal f1 = new Principal();
            f1.ShowDialog();
            this.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro f4 = new Registro();
            f4.ShowDialog();
            this.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void rtbResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
