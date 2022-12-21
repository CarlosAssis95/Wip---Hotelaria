using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotelaria.Models
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public int CPF;
        public string Nascimento;
        
        public Pessoa(string nome, int idade, int cpf, string nascimento)
        {
            Nome = nome;
            Idade = idade;
            CPF = cpf;
            Nascimento = nascimento;
        }
    }
}