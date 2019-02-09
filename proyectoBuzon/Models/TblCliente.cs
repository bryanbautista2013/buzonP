using System;
using System.Collections.Generic;

namespace proyectoBuzon.Models
{
    public partial class TblCliente
    {
        public TblCliente()
        {
            Pedido = new HashSet<Pedido>();
            Quejas = new HashSet<Quejas>();
            Sugerencias = new HashSet<Sugerencias>();
        }

        public int IdCl { get; set; }
        public string CedulaCl { get; set; }
        public string NombresCl { get; set; }
        public string ApellidosCl { get; set; }
        public DateTime FechaNacimientoCl { get; set; }
        public string TelefonoCl { get; set; }
        public string CorreoCl { get; set; }

        public ICollection<Pedido> Pedido { get; set; }
        public ICollection<Quejas> Quejas { get; set; }
        public ICollection<Sugerencias> Sugerencias { get; set; }
    }
}
