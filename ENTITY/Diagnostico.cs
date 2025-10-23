using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
   
        public class Diagnostico
        {
            public int IdDiagnostico { get; set; }
            public int IdAnalisis { get; set; }    // Relación con Analisis
            public DateTime FechaDiagnostico { get; set; }
            public string DiagnosticoFinal { get; set; } // Ejemplo: “eczema leve”
            public string Recomendacion { get; set; }    // Ejemplo: “consultar a un dermatólogo”
            public string Observaciones { get; set; }    // Comentarios adicionales
        }
    
}
