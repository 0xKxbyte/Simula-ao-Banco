using System;

class Banner
{
    public static void MostrarBanner()
    {
        Console.WriteLine(@"
   _____ _                 _                             ____                        
  / ____(_)               | |                           |  _ \                       
 | (___  _ _ __ ___  _   _| | __ _  ___ __ _  ___ ______| |_) | __ _ _ __   ___ ___  
  \___ \| | '_ ` _ \| | | | |/ _` |/ __/ _` |/ _ \______|  _ < / _` | '_ \ / __/ _ \ 
  ____) | | | | | | | |_| | | (_| | (_| (_| | (_) |     | |_) | (_| | | | | (_| (_) |
 |_____/|_|_| |_| |_|\__,_|_|\__,_|\___\__,_|\___/      |____/ \__,_|_| |_|\___\___/ 
                                    )_)   Autor: 0xKxbyte                                           
        ");
    }
}

class Program
{
    static void Main()
    {
        Banner.MostrarBanner();


        // Variáveis
        int SaldoAtual = 1000;


        while (true)
        {
            Console.WriteLine("");

            // Menu
            Console.WriteLine("1 - Ver Saldo");
            Console.WriteLine("2 - Depositar");
            Console.WriteLine("3 - Sacar");
            Console.WriteLine("4 - Sair");


            Console.WriteLine("");
            Console.Write("Escolha: ");
            int opcao = int.Parse(Console.ReadLine()!);


            if (opcao == 1)
            {
                //teste
                Console.Write($"Saldo Atual: {SaldoAtual}");
                Console.WriteLine("");
            }

            if (opcao == 2)
            {


                Console.Write("Quanto de Deposito: ");
                int deposito = int.Parse(Console.ReadLine()!);

                //SaldoAtual += deposito; TEM DESSA FORMA, mais eu nao sabia, tive que pergunta para alguem
                SaldoAtual = SaldoAtual + deposito;

                Console.Write("Saldo Atual: ");
                Console.Write(SaldoAtual);

                Console.WriteLine("");
            }

            if (opcao == 3)
            {
                Console.Write("Quanto Deseja Sacar: ");
                int sacar = int.Parse(Console.ReadLine()!);

                if (sacar > SaldoAtual)
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
                else
                {
                    SaldoAtual = SaldoAtual - sacar;

                    Console.Write("Saldo Atual: ");
                    Console.WriteLine(SaldoAtual);
                }

                if (sacar > 100000)
                {
                    Console.WriteLine("Valor muito alto!");
                }
                else if (sacar > SaldoAtual)
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
                else
                {
                    SaldoAtual -= sacar;

                    Console.Write("Saldo Atual: ");
                    Console.WriteLine(SaldoAtual);
                }
            }

            if (opcao == 4)
            {
                Console.Write("Deseja Sair s/n: ");
                string sair = Console.ReadLine()!.ToUpper();

                if (sair == "S")
                {
                    Environment.Exit(0); //força o fechamento do programa , Creditos: Microsoft C# .NET 8
                }

                if (sair == "s")
                {
                    Environment.Exit(0); //força o fechamento do programa , Creditos: Microsoft C# .NET 8
                }

                else if (sair == "N")
                {
                    Console.Write("Retornando ao Menu... ");
                    Console.WriteLine("");
                }

                else if (sair == "n")
                {
                    Console.Write("Retornando ao Menu... ");
                    Console.WriteLine("");
                }

                else
                {
                    Console.Write("Opçao Invalida Retornando");
                    //Console.ReadLine(); pode tirar no final que quiser
                    Environment.Exit(0);

                }
            }

            if (opcao != 1 &&
                opcao != 2 &&
                opcao != 3 &&
                opcao != 4)
            {
                Console.WriteLine("Essa opção está inválida");
                Environment.Exit(0);
            }

        }
    }
}