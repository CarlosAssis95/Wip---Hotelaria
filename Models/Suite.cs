using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Suite
    {
        public string tipoDeQuarto;
        public int Capacidade;
        public decimal valorDeDiaria;

        public Suite(string tipodequarto, int capacidade, decimal valordediaria)
        {
            tipoDeQuarto = tipodequarto;
            Capacidade = capacidade;
            valorDeDiaria = valordediaria;
        }
    }
}