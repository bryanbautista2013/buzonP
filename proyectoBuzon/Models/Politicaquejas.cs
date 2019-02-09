using System;
using System.Collections.Generic;

namespace proyectoBuzon.Models
{
    public partial class Politicaquejas
    {
        public int IdPoliticaQuejas { get; set; }
        public int IdTipoq { get; set; }
        public int IdPolitica { get; set; }

        public Politicas IdPoliticaNavigation { get; set; }
        public Tipoqueja IdTipoqNavigation { get; set; }
    }
}
