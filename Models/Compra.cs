using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TEORIA_PC1.Models
{
    public class Compra
    {
        public string? Nombre { get; set; }
        public string? Correo { get; set; }
        public DateTime FechaOperacion { get; set; }
        public List<string>? Instrumentos { get; set; }
        public decimal MontoAbonar { get; set; }

        public decimal Comision { get { return MontoAbonar < 300 ? 3 : 1; } }
        public decimal IGV { get { return (MontoAbonar + Comision) * 0.18m; } }
        public decimal TotalPagar { get { return MontoAbonar + Comision + IGV; } }
    }
}