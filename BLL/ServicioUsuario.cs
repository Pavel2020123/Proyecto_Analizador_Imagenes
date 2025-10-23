using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioUsuario : ICrud<Usuario>
    {
        List<Usuario> usuarios;
        UsuarioRepositorio usuarioRepositorio;

        public ServicioUsuario()
        {
            usuarioRepositorio = new UsuarioRepositorio();
            usuarios = usuarioRepositorio.ObtenerTodas();
        }


        public string Guardar(Usuario usuario)
        {

            var mensaje = usuarioRepositorio.Guardar(usuario);
            usuarios = usuarioRepositorio.ObtenerTodas();
            return mensaje;
        }


        public List<Usuario> ObtenerTodas()
        {
            return usuarios;
        }

        public Usuario ConsultarPorId(int id)
        {

            foreach (var usuario in usuarios)
            {
                if (usuario.IdUsuario == id)
                {
                    return usuario;
                }
            }
            return null;
        }
        public string Eliminar(int id)
        {
            var usuario = usuarioRepositorio.ConsultarPorId(id);

            if (usuario == null)
            {
                return $"No se encontró el usuario con ID {id}.";
            }

            var mensaje = usuarioRepositorio.Eliminar(id);
            usuarios = usuarioRepositorio.ObtenerTodas();

            return mensaje;
        }
    }
}

