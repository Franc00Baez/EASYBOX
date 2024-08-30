using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }
        public string ImgPerfil { get; set; }
        public bool Eliminated { get; set; }
        public DateTime CreationDate { get; set; }

        public Usuario(int id, string name,string email, string password, int idrol, string imgperfil, bool eliminated, DateTime creationdate)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            IdRol = idrol;
            ImgPerfil = imgperfil;
            Eliminated = eliminated;
            CreationDate = creationdate;
        }

        public override string ToString()
        {
            string info = "ID: " + Id + "\nNombre: " + Name + "\nEmail: " + Email + "\nPassword: " + Password + "\nidRol: " + IdRol + "\nEliminated: " + Eliminated.ToString() + "\nFecha de creacion: " + CreationDate.ToString("G");
            return info;
        }
    }
}
