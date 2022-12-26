using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotelaria.Models;

class Program
{
    enum menu {cadastrarHospedes = 1, listarHospedes, darBaixaEmHospede, sair}
    // LISTA QUE FAZ O RECEBE AS PESSOAS NO PROGRAMA HOTEL.
    static List<Pessoa> pList = new List<Pessoa>();

    static void Main(string [] args)
    {

        // OPÇÕES DE SUITE DISPONIVEIS NO PROGRAMA HOTEL 
        Suite Basica = new Suite("Basica" , 2, 30m);
        Suite Mediana = new Suite("Mediana", 3, 50m);
        Suite Premium = new Suite("Premium", 4, 100m);
        bool exibirMenu = true;

        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine("Bem vindo ao Hotel n200");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-");

        // OPÇÕES DISPONIVEIS NO MENU
        while (exibirMenu)
        {
            Console.WriteLine("[1]Cadastrar Hospede \n[2]Listar Hospedes \n[3]Dar baixa em Hospede \n[4]Sair do sistema ");
            int opcao = int.Parse(Console.ReadLine());
            menu escolha = (menu)opcao;

            switch (escolha)
            {
                case menu.cadastrarHospedes:
                cadastrarHospedes();
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
    // FUNÇÃO QUE CADASTRA MEUS HOSPEDES NA LISTA
    static void cadastrarHospedes()
    {  
    const int NAO = 2;
    bool opcao = true;
        
        while(opcao)
        {
            Console.WriteLine("Digite o nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF:");
            string cpf = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento");
            string nascimento = Console.ReadLine();
            Console.WriteLine("Quer cadastrar outra pessoa [1]SIM ou [2]NAO?");
            int escolha = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, cpf, nascimento);
            pList.Add(pessoa);

        if (escolha == NAO)
        {
            opcao = false;
        }
        }
    // CHAMADA DA FUNÇÃO ESCOLHER SUITE DENTRO DO CADASTRO DE HOSPEDES
    escolherSuite();
    
    }     
    // FUNCAO DE ESCOLHA DE SUITES
    static void escolherSuite()
    {
        Console.WriteLine("Escolha a suite");
        Console.WriteLine("[1]Basica R$30,00 diaria \n[2]Mediana R$50,00 diaria \n[3]Premium R$100,00 diaria ");
        int opcaoSuite = int.Parse(Console.ReadLine());
        int Basica = 1;
        int Mediana = 2;
        int Premium = 3; 

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

        // VARIAVEIS COM VALOR DA DIARIA DE CADA SUITE
        Basica = 40;
        Mediana = 50;
        Premium = 100;

        // CAPTURA A QUANTIDADE DE DIAS QUE VAI ESTAR HOSPEDADO
        Console.WriteLine("Vai estar conosco por quantos dias?");
        int dias = int.Parse(Console.ReadLine()); 
        decimal total = opcaoSuite * dias;  // FAZ O CALCULO DO VALOR DA DIARIA X OS DIAS QUE VAI ESTAR HOPEDADO

        Console.WriteLine($"Voce vai pagar o total de {total} Reais");
        Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

    }
    // FUNÇÃO QUE LISTA OS HOSPEDES CADASTRADOS NA MINHA LISTA
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
    // FUNÇÃO QUE RETIRA OS HOSPEDES DA MINHA LISTA DANDO BAIXA NO HOTEL
    static void darBaixaEmHospede()
    {
        Console.WriteLine("Dando baixa em hospede");
        Console.WriteLine("Qual hospede vai sair?");
        string saindo = Console.ReadLine();

         for(int contador = 0; contador < pList.Count(); ++contador)
        {
            if(pList.ElementAt(contador).Nome == saindo)
            {
                pList.RemoveAt(contador);
                Console.WriteLine($"Você removeu o " + saindo);
                Console.WriteLine("-=-=-=-=-=-=-=-==-=-=-=-=");
            }
        }
    }
} 