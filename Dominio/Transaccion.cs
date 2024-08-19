using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Transaccion
    {
        public int IdTransaccion { get; set; }
        public Usuario Creador { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public Decimal Monto { get; set; }
        public Caja Caja { get; set; }
        public TipoMovimiento Movimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public bool Eliminado { get; set; }

        public Transaccion(int idtransaccion, Usuario creador, string descripcion, Categoria categoria, Decimal monto, Caja caja, TipoMovimiento movimiento, DateTime fechamovimiento, bool eliminado)
        {
            IdTransaccion = idtransaccion;
            Creador = creador;
            Descripcion = descripcion;
            Categoria = categoria;
            Monto = monto;
            Caja = caja;
            Movimiento = movimiento;
            FechaMovimiento = fechamovimiento;
            Eliminado = eliminado;
        }
    }
}
