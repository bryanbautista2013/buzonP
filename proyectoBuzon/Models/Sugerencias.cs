using System;
using System.Collections.Generic;

namespace proyectoBuzon.Models
{
    public partial class Sugerencias
    {
        public int IdS { get; set; }
        public int IdCl { get; set; }
        public string DescripcionS { get; set; }
        public DateTime FechaS { get; set; }
        public int IdTiposug { get; set; }

        public TblCliente IdClNavigation { get; set; }
        public Tiposugerencia IdTiposugNavigation { get; set; }
    }
}
