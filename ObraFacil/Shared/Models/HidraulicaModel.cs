using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ObraFacil.Shared.Models
{
    public class HidraulicaModel
    {
        public int Quantidadetorneiras { get; set; }
        public int QuantidadeChuveiros { get; set; }
        public int QuantidadeSaidasEsgoto { get; set; }
        public DateTime PrevisaoEntregaAlvenaria { get; set; }
    }
}
