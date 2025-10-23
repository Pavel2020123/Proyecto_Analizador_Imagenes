using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
   public class Imagen
    {
        public int IdImagen { get; set; }
        public int IdUsuario { get; set; }      // Relación con Usuario
        public string RutaArchivo { get; set; } // Ruta donde se guarda la imagen
        public DateTime FechaSubida { get; set; }
        public string Resolucion { get; set; }

    }
}
