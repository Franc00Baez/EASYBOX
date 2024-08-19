using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RoleType Rol { get; set; }
        public string ImgPerfil { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Eliminado { get; set; }

        public Usuario()
        {
            IdUsuario = 0;
            Eliminado = false;
        }

        public Usuario (int idusuario, string nombre, string email, string password, RoleType rol, string imgperfil, bool eliminado)
        {
            IdUsuario = idusuario;
            Nombre = nombre;
            Email = email;
            Password = password;
            Rol = rol;
            FechaCreacion = DateTime.Now;
            Eliminado = eliminado;
        }
    }
}
