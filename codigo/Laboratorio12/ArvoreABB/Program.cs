using System;

namespace ABB
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreBinaria Arvore = new ArvoreBinaria();

            string continuar = "";
            

            do{
            int valor = 0;
            int pos = 0;
            string especifica = "";
            int opcao = 0;

            Console.WriteLine("====== Arvore ABB ======");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1- Inserir Raiz.");
            Console.WriteLine("2- Inserir Folhas.");
            Console.WriteLine("3- Pesquisa.");
            Console.WriteLine("4- remover.");
            Console.WriteLine("5- Imprimir em ordem.");
            Console.WriteLine("6- Imprimir pre ordem.");
            Console.WriteLine("7- Imprimi pos ordem.");
            Console.WriteLine("8- Sair");
            opcao = int.Parse(Console.ReadLine());

            if(opcao == 1)
            {
                Console.WriteLine("Informe um valor para inserir: ");
                valor = int.Parse(Console.ReadLine());

                Arvore.inserir(valor);

            }
            
            Console.WriteLine(" ");

            if(opcao == 2)
            {
               Console.WriteLine("Informe um valor para inserir: ");
               valor = int.Parse(Console.ReadLine());

                Arvore.inserirSubRaiz(valor);
            }

            if(opcao == 3){
                bool resultado;

                Console.WriteLine("Qual valor deseja pesquisar na arvore? ");
                valor = int.Parse(Console.ReadLine());
                resultado = Arvore.pesquisar(valor);

                Console.WriteLine("O valor é {0}", resultado);
            }

             if(opcao == 4)
            {
               Console.WriteLine("Informe um valor para remover: ");
               valor = int.Parse(Console.ReadLine());

                Arvore.remover(valor);
            }

            if(opcao == 5)
            {
               Arvore.EmOrdem();
            }

            if(opcao == 6)
            {
              Arvore.preOrdem();
            }

            if(opcao == 7)
            {
                Console.WriteLine("A raiz: ");
                valor = int.Parse(Console.ReadLine());
                Arvore.posOrdem();
            }

            if(opcao == 8)
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