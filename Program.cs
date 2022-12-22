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
        bool exibirMenu = true;

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("Bem vindo ao Hotel n200");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");


        while (exibirMenu)
        {
            Console.WriteLine("[1]Cadastrar Hospede \n[2]Selecionar Suite \n[3]Listar Hospedes \n[4]Dar baixa em Hospede \n[5]Sair do sistema ");
            int opcao = int.Parse(Console.ReadLine());
            menu escolha = (menu)opcao;

            switch (escolha)
            {
                case menu.cadastrarHospedes:
                cadastrarHospedes();
                break;

                case menu.escolherSuite:
                escolherSuite();
                break;

                case menu.listarHospedes:
                listarHospedes();
                break;

                case menu.darBaixaEmHospede:
                darBaixaEmHospede();
                break;

                case menu.sair:
                exibirMenu = false;
                Console.WriteLine("Obrigado por visitar o Hotel");
                Console.WriteLine("Até a proxima");
                break;
            }
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
    
    static void escolherSuite()
    {
        Console.WriteLine("Escolha a suite");
        Console.WriteLine("[1]Basica \n[2]Mediana \n[3]Premium ");
        int opcaoSuite = int.Parse(Console.ReadLine());
        int Basica = 1;
        int Mediana = 2;

        if (opcaoSuite == Basica)
        {
            Console.WriteLine($"Você escolheu a suite Basica");
        }
        else if(opcaoSuite == Mediana)
        {
            Console.WriteLine($"Você escolheu a suite Mediana");
        }
        else 
        {
            Console.WriteLine($"Você escolheu a suite Premium");
        }

    }

    static void listarHospedes()
    {
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");
        Console.WriteLine("Os Hospedes atuais são");
        foreach(Pessoa p in pList)
        {
            Console.WriteLine($"{p.Nome}, {p.CPF}, {p.Nascimento}");
        }
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=");
    }

    static void darBaixaEmHospede()
    {
        Console.WriteLine("Dando baixa em hospede");
        Console.WriteLine("Qual hospede vai sair?");
        string saindo = Console.ReadLine();

    }
} 