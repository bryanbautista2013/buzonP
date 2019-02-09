using System;
using System.Collections.Generic;

namespace proyectoBuzon.Models
{
    public partial class Tipoqueja
    {
        public Tipoqueja()
        {
            Politicaquejas = new HashSet<Politicaquejas>();
            Quejas = new HashSet<Quejas>();
        }

        public int IdTipoq { get; set; }
        public string NombreTipoq { get; set; }

        public ICollection<Politicaquejas> Politicaquejas { get; set; }
        public ICollection<Quejas> Quejas { get; set; }
    }
}
