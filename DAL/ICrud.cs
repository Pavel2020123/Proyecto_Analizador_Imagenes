using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ICrud<Usuario>
    {
      
        

            string Guardar(Usuario usuario);
            List<Usuario> ObtenerTodas();
            Usuario ConsultarPorId(int id);
            string Eliminar(int id);
        
    }
}
