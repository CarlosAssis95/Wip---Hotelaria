using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Pessoa
    {
        public string Nome;
        public string CPF;
        public string Nascimento;
        
        public Pessoa(string nome, string cpf, string nascimento)
        {
            Nome = nome;
            CPF = cpf;
            Nascimento = nascimento;
        }
    }
}