using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace ObraFacil.Infra.Entities
{
    public class EletricaModel
    {
        public int QuantidadeDisjuntores { get; set; }
        public int QuantidadeTomada { get; set; }
        public int QuantidadeInterruptores { get; set; }
        public int QuantidadeLampadas { get; set; }
        public DateTime PrevisaoEntregaEletrica { get; set; }
    }
}

