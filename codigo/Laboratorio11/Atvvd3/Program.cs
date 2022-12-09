using System;

namespace Atvvd3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCircular listas = new ListaCircular();

            string continuar = "";
            

            do{
            int valor = 0;
            int pos = 0;
            string especifica = "";
            int opcao = 0;

            Console.WriteLine("====== LISTA CIRCULAR DINAMICA ======");
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

                Console.WriteLine("Dseja inserir em uma posição especifica? ");
                especifica = Console.ReadLine();
                especifica = especifica.ToUpper();
                
                if(especifica == "S")
                {   
                    Console.WriteLine("Informe a posição: ");
                    pos = int.Parse(Console.ReadLine());
                    listas.inserir(valor,pos);
                }else if(especifica == "N")
                {
                    listas.inserirFim(valor);
                }else
                {
                    listas.inserirFim(valor);
                    Console.WriteLine("Posiçao invalida");
                }
                 listas.imprimir();    

            }
            
            Console.WriteLine(" ");

            if(opcao == 2)
            {
                Console.WriteLine("Qual posição deseja remover? ");
                pos = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor excluido "+ listas.remover(pos));
            }

            if(opcao == 3){
                break;
            }

            Console.WriteLine(" ");
            Console.WriteLine("listas atual");
            listas.imprimir();

            Console.WriteLine(" ");
            Console.WriteLine("Deseja continuar? ");
            continuar = Console.ReadLine();
            continuar =continuar.ToUpper();
            }while (continuar == "S");
            listas.imprimir();
        }
    }
}