using System;
using System.Collections.Generic;
using System.Text;

namespace Squadra.Loja.Dominio.Entities
{
    class Vendedor
    {
        public String Nome { get; set; }

        public int Id { get; set; }

        public float TotalVendas { get; set; }

        public ICollection<Cliente> IdClientesVendas { get; set; }

    }
}
