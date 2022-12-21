using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Reserva
    {
        public List<Pessoa> Pessoa;
        public Suite Suite;
        public int diasReservados;

        public Reserva (List<Pessoa> pessoa, Suite suite, int diasreservados)
        {
            Pessoa = pessoa;
            Suite = suite;
            diasReservados = diasreservados;
        }
    }
}