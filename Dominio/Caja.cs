using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Caja
    {
        public int IdCaja { get; set; }
        public Moneda Moneda { get; set; }
        public Decimal Saldo { get; set; }
        public bool Eliminado { get; set; }

        public Caja()
        {
            IdCaja = 0;
            Moneda = new Moneda();
            Saldo = 0.00m;
            Eliminado = false;
        }
        public Caja(int idcaja, Moneda moneda, Decimal saldo)
        {
            IdCaja = idcaja;
            Moneda = moneda;
            Saldo = saldo;
            Eliminado = false;
        }
    }
}
