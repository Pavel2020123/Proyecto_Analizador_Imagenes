namespace GUI
{
    partial class Cargar_Img
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargar_Img));
            this.btnInicioLogo = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSubii = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicioLogo
            // 
            this.btnInicioLogo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnInicioLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnInicioLogo.Image")));
            this.btnInicioLogo.Location = new System.Drawing.Point(58, 150);
            this.btnInicioLogo.Name = "btnInicioLogo";
            this.btnInicioLogo.Size = new System.Drawing.Size(88, 54);
            this.btnInicioLogo.TabIndex = 0;
            this.btnInicioLogo.Text = "                     ";
            this.btnInicioLogo.UseVisualStyleBackColor = false;
            this.btnInicioLogo.Click += new System.EventHandler(this.btnInicioLogo_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnHistorial.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Image")));
            this.btnHistorial.Location = new System.Drawing.Point(58, 310);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(88, 67);
            this.btnHistorial.TabIndex = 1;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfiguracion.Image")));
            this.btnConfiguracion.Location = new System.Drawing.Point(58, 399);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(88, 67);
            this.btnConfiguracion.TabIndex = 2;
            this.btnConfiguracion.UseVisualStyleBackColor = false;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.Location = new System.Drawing.Point(12, 555);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(90, 66);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSubii);
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(201, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 594);
            this.panel1.TabIndex = 4;
            // 
            // btnSubii
            // 
            this.btnSubii.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubii.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSubii.Location = new System.Drawing.Point(245, 504);
            this.btnSubii.Name = "btnSubii";
            this.btnSubii.Size = new System.Drawing.Size(138, 49);
            this.btnSubii.TabIndex = 3;
            this.btnSubii.Text = "CARGAR";
            this.btnSubii.UseVisualStyleBackColor = false;
            this.btnSubii.Click += new System.EventHandler(this.btnSubii_Click);
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(175, 443);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(275, 20);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Haz clic para seleccionar una imagen ";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(214, 372);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(169, 26);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Cargar imagen";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.Location = new System.Drawing.Point(89, 26);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(426, 315);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 86);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // rtbResultado
            // 
            this.rtbResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbResultado.Location = new System.Drawing.Point(885, 53);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.Size = new System.Drawing.Size(371, 366);
            this.rtbResultado.TabIndex = 6;
            this.rtbResultado.Text = "";
            this.rtbResultado.TextChanged += new System.EventHandler(this.rtbResultado_TextChanged);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAnalizar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAnalizar.Location = new System.Drawing.Point(986, 531);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(132, 49);
            this.btnAnalizar.TabIndex = 7;
            this.btnAnalizar.Text = "ANALIZAR";
            this.btnAnalizar.UseVisualStyleBackColor = false;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(58, 229);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 62);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Cargar_Img
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1296, 676);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnInicioLogo);
            this.Name = "Cargar_Img";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicioLogo;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnSubii;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.Button btnAgregar;
    }
}