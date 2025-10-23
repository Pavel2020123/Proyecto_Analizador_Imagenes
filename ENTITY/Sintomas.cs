using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Sintomas
    {
        public int IdSintoma { get; set; }
        public int IdUsuario { get; set; }     // Relación con Usuario
        public string Descripcion { get; set; } // Ejemplo: "picazón", "enrojecimiento"
        public string Intensidad { get; set; }   // Opcional: leve, moderado, severo
    }
}
