using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{




    public class Usuario
    {

        public Usuario()
        {

        }
        public Usuario(int idUsuario, string nombre, string correo, DateTime fechaRegistro, string tipoPiel)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Correo = correo;
            FechaRegistro = fechaRegistro;
            tipoPiel = TipoPiel;
        }
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoPiel { get; set; } // Opcional, dato útil para análisis
    }





}




