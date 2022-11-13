using System;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilhas pilha = new Pilhas();

            int valor = 0;
            string continuar = "";
            string remover = "";

            do{
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());
                pilha.inserir(valor);

                Console.WriteLine("Deseja continua? ");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();
            }while(continuar == "S");

            
            Console.WriteLine("Deseja exlcuir um valor? ");
            remover = Console.ReadLine();
            remover = remover.ToUpper();

            while(remover == "S")
            {
                Console.WriteLine("Valor excluido "+pilha.remover());
                Console.WriteLine("Deseja exlcuir outro valor? ");
                remover = Console.ReadLine();
                remover = remover.ToUpper();
            }

            pilha.imprimir();
        }
    }
}