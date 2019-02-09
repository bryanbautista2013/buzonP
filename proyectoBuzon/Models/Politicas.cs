using System;
using System.Collections.Generic;

namespace proyectoBuzon.Models
{
    public partial class Politicas
    {
        public Politicas()
        {
            Politicaquejas = new HashSet<Politicaquejas>();
            Quejas = new HashSet<Quejas>();
        }

        public int IdPolitica { get; set; }
        public string NomPolitica { get; set; }

        public ICollection<Politicaquejas> Politicaquejas { get; set; }
        public ICollection<Quejas> Quejas { get; set; }
    }
}
