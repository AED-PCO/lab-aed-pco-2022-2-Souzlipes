using System;

namespace Fila
{
    class Program
    {
        static void Main(string[] args)
        {
            Listas listas = new Listas();

            int valor = 0;
            int pos = 0;
            string especific = "";
            string continuar = "";
            string remover = "";

            do{
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());
                listas.inserir(valor);

                Console.WriteLine("Deseja continua? ");
                continuar = Console.ReadLine();
                continuar = continuar.ToUpper();
            }while(continuar == "S");

            Console.WriteLine("Deseja inserir um valor em uma posição especifica? ");
            especific = Console.ReadLine();
            especific = especific.ToUpper();

            while (especific == "S" ){
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe um posiçaõ para inserir o valor: ");
                pos = int.Parse(Console.ReadLine());
                listas.inserirLista(valor,pos);

                Console.WriteLine("Deseja inserir outro valor? ");
                especific = Console.ReadLine();
                especific = especific.ToUpper();

            }

            
            Console.WriteLine("Deseja exlcuir um valor? ");
            remover = Console.ReadLine();
            remover = remover.ToUpper();

            while(remover == "S")
            {
                Console.WriteLine("Informe uma posiçao para retirar: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor excluido "+listas.removerLista(valor));
                
                Console.WriteLine("Deseja exlcuir outro valor? ");
                remover = Console.ReadLine();
                remover = remover.ToUpper();
            }

            Console.WriteLine("Deseja inserir um valor em uma posição especifica? ");
            especific = Console.ReadLine();
            especific = continuar.ToUpper();

            while (especific == "S" ){
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe um posiçaõ para inserir o valor: ");
                pos = int.Parse(Console.ReadLine());
                listas.inserirLista(valor,pos);
            }

            listas.imprimir();
        }
    }
}