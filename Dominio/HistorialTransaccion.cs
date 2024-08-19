using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class HistorialTransaccion
    {
        public int IdHistorial { get; set; }
        public int IdTransaccion { get; set; }
        public string Descripcion { get; set; }
        public Categoria Categoria { get; set; }
        public Decimal Monto { get; set; }
        public TipoMovimiento Movimiento { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Accion { get; set; }

        public HistorialTransaccion(int idhistorial, int idtransaccion, string descripcion, Categoria categoria, Decimal monto, TipoMovimiento movimiento, DateTime fechamovimiento, DateTime fechamodificacion, string accion)
        {
            IdHistorial = idhistorial;
            IdTransaccion = idtransaccion;
            Descripcion = descripcion;
            Categoria = categoria;
            Monto = monto;
            Movimiento = movimiento;
            FechaMovimiento = fechamovimiento;
            FechaModificacion = fechamodificacion;
            Accion = accion;
        }
    }
}
