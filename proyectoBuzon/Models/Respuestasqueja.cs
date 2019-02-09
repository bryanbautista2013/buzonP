using System;
using System.Collections.Generic;

namespace proyectoBuzon.Models
{
    public partial class Respuestasqueja
    {
        public int IdRespuestaq { get; set; }
        public int IdQ { get; set; }
        public string DescResp { get; set; }

        public Quejas IdQNavigation { get; set; }
    }
}
