using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ObraFacil.Infra.Entities
{
    public class AlvenariaModel
    {
        public int TamanhoParedes { get; set; }
        public int AlturaBloco { get; set; }
        public int LarguraBloco { get; set; }
        public int ProfundidadeBloco { get; set; }
        public int QuantidadePilares { get; set; }
        public int AlturaPilar { get; set; }
        public int LarguraPilar { get; set; }
        public int ProfundidadePilar { get; set; }
        public DateTime PrevisaoEntregaAlvenaria { get; set; }
    }
}
