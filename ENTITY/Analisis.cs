using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Analisis
    {
        public int IdAnalisis { get; set; }
        public int IdImagen { get; set; }       // Relación con Imagen
        public DateTime FechaAnalisis { get; set; }
        public string ZonaCorporal { get; set; } 
        public string Mensaje_Usuario { get; set; }      // "Completado", "Error", etc.
    }
}