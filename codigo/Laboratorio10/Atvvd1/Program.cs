using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Filas filas = new Filas();

            int valor = 0;
            string continuar = "";
            string remover = "";
            int opcao = 0;

            do{

            Console.WriteLine("====== filas DINAMICA ======");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Inserir.");
            Console.WriteLine("2- Remover.");
            Console.WriteLine("3- Sair");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());
                filas.inserir(valor);

            }

            Console.WriteLine(" ");

            if(opcao == 2)
            {
                Console.WriteLine("Valor excluido "+filas.remover());
            }

            if(opcao == 3){
                break;
            }

            Console.WriteLine(" ");
            Console.WriteLine("filas atual");
            filas.imprimir();

            Console.WriteLine(" ");
            Console.WriteLine("Deseja continuar? ");
            continuar = Console.ReadLine();
            continuar =continuar.ToUpper();
            }while (continuar == "S");
            filas.imprimir();
        }
    }
}