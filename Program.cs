using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotelaria.Models;

class Program
{
    enum menu {cadastrarHospedes = 1, escolherSuite, listarHospedes, darBaixaEmHospede, sair}
    static List<Pessoa> pList = new List<Pessoa>();
    static void Main(string [] args)
    {
        Suite Basica = new Suite("Basica" , 2, 30m);
        Suite Mediana = new Suite("Mediana", 3, 50m);
        Suite Premium = new Suite("Premium", 4, 100m);

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("Bem vindo ao Hotel n200");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("[1]Cadastrar Hospede \n[2]Selecionar Suite \n[3]Listar Hospedes \n[4]Dar baixa em Hospede \n[5]Sair do sistema ");
        int opcao = int.Parse(Console.ReadLine());
        menu escolha = (menu)opcao;

        switch (escolha)
        {
            case menu.cadastrarHospedes:
            cadastrarHospedes();
            break;
        }
    }
    static void cadastrarHospedes()
    {   
        Console.WriteLine("Digite o nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o CPF:");
        string cpf = Console.ReadLine();
        Console.WriteLine("Digite a data de nascimento");
        string nascimento = Console.ReadLine();

        Pessoa pessoa = new Pessoa(nome, cpf, nascimento);
        pList.Add(pessoa);
    } 
} 