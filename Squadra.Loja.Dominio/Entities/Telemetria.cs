using System;
using System.Collections.Generic;
using System.Text;

namespace Squadra.Loja.Dominio.Entities
{
    class Telemetria
    {
        public int Id { get; set; }

        public int IdCliente { get; set; }

        public int IdVendedor { get; set; }

        public DateTime Data { get; set; }
    }
}
