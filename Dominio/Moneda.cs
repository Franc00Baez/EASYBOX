using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Moneda
    {
        public byte  IdMoneda { get; set; }
        public string Nombre { get; set; }
        public string Signo { get; set; }
        public string Codigo { get; set; }

        public Moneda()
        {
            IdMoneda = 0;
        }
        public Moneda(byte idmoneda, string nombre, string signo, string codigo)
        {
            IdMoneda = idmoneda;
            Nombre = nombre;
            Signo = signo;
            Codigo = codigo;
        }
    }
}
