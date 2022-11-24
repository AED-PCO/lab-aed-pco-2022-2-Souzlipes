using System;

namespace Atvvd3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilhas pilha = new Pilhas();

            int valor = 0;
            string continuar = "";
            int opcao = 0;
            

            do{

            Console.WriteLine("====== PILHA DINAMICA ======");
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
                pilha.inserir(valor);

            }

            Console.WriteLine(" ");

            if(opcao == 2)
            {
                Console.WriteLine("Valor excluido "+pilha.remover());
            }

            if(opcao == 3){
                break;
            }

            Console.WriteLine(" ");
            Console.WriteLine("Pilha atual");
            pilha.imprimir();

            Console.WriteLine(" ");
            Console.WriteLine("Deseja continuar? ");
            continuar = Console.ReadLine();
            continuar =continuar.ToUpper();
            }while (continuar == "S");
            pilha.imprimir();
        }
    }
}