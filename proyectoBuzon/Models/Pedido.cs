using System;
using System.Collections.Generic;

namespace proyectoBuzon.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            Quejas = new HashSet<Quejas>();
        }

        public int IdPedido { get; set; }
        public int IdCl { get; set; }

        public TblCliente IdClNavigation { get; set; }
        public ICollection<Quejas> Quejas { get; set; }
    }
}
