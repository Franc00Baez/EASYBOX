using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public byte IdCategoria { get; set; }
        public string Nombre { get; set; }

        public Categoria(byte idcategoria, string nombre)
        {
            IdCategoria = idcategoria;
            Nombre = nombre;
        }
    }
}
