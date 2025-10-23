using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioRepositorio : ICrud<Usuario>
    {
        string ruta = "Usuarios_Analizador.txt";



        public string Guardar(Usuario usuario)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(ruta, true))
                {
                    sw.WriteLine($"{usuario.IdUsuario};{usuario.Nombre};{usuario.Correo};{usuario.FechaRegistro};{usuario.TipoPiel}");
                }
                return $"Se guardó el usuario {usuario.Nombre}";
            }
            catch (Exception ex)
            {
                return "Error al guardar ..." + "\n" + ex.Message;
            }
        }

        public Usuario ConsultarPorId(int id)
        {
            try
            {
                if (!File.Exists(ruta)) return null;

                using (StreamReader lector = new StreamReader(ruta))
                {
                    while (!lector.EndOfStream)
                    {
                        var linea = lector.ReadLine();
                        Usuario usuario = MapearUsuario(linea);

                        if (usuario.IdUsuario == id)
                        {
                            return usuario;
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Usuario> ObtenerTodas()
        {
            List<Usuario> listaUsuarios = new List<Usuario>();
            try
            {
                if (!File.Exists(ruta)) return listaUsuarios;

                using (StreamReader lector = new StreamReader(ruta))
                {
                    while (!lector.EndOfStream)
                    {
                        var linea = lector.ReadLine();
                        listaUsuarios.Add(MapearUsuario(linea));
                    }
                }
                return listaUsuarios;
            }
            catch (Exception)
            {
                return new List<Usuario>();
            }
        }

        private Usuario MapearUsuario(string linea)
        {
            var aux = linea.Split(';');

            Usuario usuario = new Usuario
            {
                IdUsuario = int.Parse(aux[0]),
                Nombre = aux[1],
                Correo = aux[2],
                FechaRegistro = DateTime.Parse(aux[3]),
                TipoPiel = aux[4]


            };

            return usuario;
        }

        public string Eliminar(int id)
        {
            try
            {
                if (!File.Exists(ruta)) return "No existe el archivo de usuarios.";

                var usuarios = ObtenerTodas();
                var usuarioAEliminar = usuarios.Find(u => u.IdUsuario == id);

                if (usuarioAEliminar == null)
                {
                    return $"No se encontró el usuario con ID {id}.";
                }

                usuarios.Remove(usuarioAEliminar);

                using (StreamWriter sw = new StreamWriter(ruta, false))
                {
                    foreach (var u in usuarios)
                    {
                        sw.WriteLine($"{u.IdUsuario};{u.Nombre};{u.Correo};{u.FechaRegistro};{u.TipoPiel}");
                    }
                }

                return $"Usuario con ID {id} eliminado correctamente.";
            }
            catch (Exception ex)
            {
                return "Error al eliminar ..." + "\n" + ex.Message;
            }
        }
    }
}

