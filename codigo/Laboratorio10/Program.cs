using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Filas f = new Filas();

            int valor = 0;
            string continuar = "";
            string remover = "";

            do{
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());
                f.inserir(valor);

                Console.WriteLine("Deseja continua? ");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();
            }while(continuar == "S");

            
            Console.WriteLine("Deseja exlcuir um valor? ");
            remover = Console.ReadLine();
            remover = remover.ToUpper();

            while(remover == "S")
            {
                Console.WriteLine("Valor excluido "+f.remover());
                Console.WriteLine("Deseja exlcuir outro valor? ");
                remover = Console.ReadLine();
                remover = remover.ToUpper();
            }

            f.imprimir();
        }
    }
}