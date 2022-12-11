using System;

namespace AVL
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreAVL Arvore = new ArvoreAVL();

            string continuar = "";
            

            do{
            int valor = 0;
            int opcao = 0;

            Console.WriteLine("====== Arvore AVL ======");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Inserir elemento.");
            Console.WriteLine("2- Pesquisa.");
            Console.WriteLine("3- remover.");
            Console.WriteLine("4- Imprimir em ordem.");
            Console.WriteLine("5- Imprimir pre ordem.");
            Console.WriteLine("6- Imprimi pos ordem.");
            Console.WriteLine("7- Sair");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());

                Arvore.inserir(valor);

            }
            
            Console.WriteLine(" ");

            // if(opcao == 2)
            // {
            //    Console.WriteLine("Informe um valor para inserir: ");
            //    valor = int.Parse(Console.ReadLine());

            //     Arvore.inserirSubRaiz(valor);
            // }

            if(opcao == 2){
                bool resultado;

                Console.WriteLine("Qual valor deseja pesquisar na arvore? ");
                valor = int.Parse(Console.ReadLine());
                resultado = Arvore.pesquisar(valor);

                Console.WriteLine("O valor é {0}", resultado);
            }

             if(opcao == 3)
            {
               Console.WriteLine("Informe um valor para remover: ");
               valor = int.Parse(Console.ReadLine());

                Arvore.remover(valor);
            }

            if(opcao == 4)
            {
               Arvore.EmOrdem();
            }

            if(opcao == 5)
            {
              Arvore.preOrdem();
            }

            if(opcao == 6)
            {
                Arvore.posOrdem();
            }

            if(opcao == 7)
            {
                break;
            }

            Console.WriteLine(" ");

            Console.WriteLine(" ");
            Console.WriteLine("Deseja continuar? ");
            continuar = Console.ReadLine();
            continuar =continuar.ToUpper();
            }while (continuar == "S");
        }
    }
}