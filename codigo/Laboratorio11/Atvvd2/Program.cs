using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd2{

        public static void Main(string[] args) {
             int TAM = 5;
             int []vetor = new int[TAM];
             int inicio = 0;
             int fim = 0;
             int valor = 0;
             int opcao = 0;
             int pos = 0;
             string continuar = "o";
             string especifica = "N";
             do
             {
                Console.WriteLine("============LISTA CIRCULAR ESTATICA============");
                Console.WriteLine(" ");

                Console.WriteLine("Informe os valores iniciais da sua litsa");
                vetor = InserirFila(vetor, ref fim, ref inicio);
                        for(int i = 0; i<vetor.Length; i++){
                            Console.Write(" "+vetor[i]);
                        }


                Console.WriteLine("\nEscolha uma opção: ");
                Console.WriteLine("1- Inserir.");
                Console.WriteLine("2- Remover.");
                Console.WriteLine("3- Sair");
                opcao = int.Parse(Console.ReadLine());


                if(opcao == 1)
                
                {

                    Console.WriteLine("\nDeseja inserir em uma posição retirada? ");
                    especifica = Console.ReadLine();
                    especifica = especifica.ToUpper();

                    if(especifica == "N")
                    {
                        vetor = InserirFila(vetor, ref fim, ref inicio);
                        for(int i = 0; i<vetor.Length; i++){
                            Console.Write(vetor[i]);
                        }
                    }else if(especifica == "S")
                    {
                        vetor = inserirPosicoes(vetor, ref inicio, ref fim);
                        for(int i = 0; i<vetor.Length; i++){
                            Console.Write(vetor[i]);
                        }
                    }

                }else

                if(opcao == 2)
                {
                    Console.Write("\nQual posição deseja retirar? ");
                    pos = int.Parse(Console.ReadLine());
                    vetor = retirarPosicoes(vetor, ref inicio, ref fim, pos);
                    for(int i = 0; i<vetor.Length; i++){
                            Console.Write(vetor[i]);
                        }
                }else 

                if(opcao == 3){
                    break;
                }
                Console.WriteLine("");
                Console.WriteLine("\n\nInsira CTRL + C para sair do programa a qualquer momento!");
                Console.WriteLine("");
                Console.WriteLine("");
             }while (continuar != "S");

        }
        public static int[] inserirPosicoes(int []vetor, ref int inicio, ref int fim){

            if(fim == vetor.Length)
            {
                Console.WriteLine("Lista cheia, por favor retire uma posição!");
                return vetor;
            }else{

                Console.WriteLine("Informe o valor que você deseja inserir na posição {0}:  ",fim);
                vetor[fim] = int.Parse(Console.ReadLine());
                return vetor;
            }

            return vetor;
        }

         public static int[] retirarPosicoes(int []vetor, ref int inicio, ref int fim, int pos)
         {
            if(fim % vetor.Length-1 != 0)
            {
                fim = 0;
            }
            if(pos > vetor.Length-1){
                Console.WriteLine("Posição invalida");
            }

            Console.WriteLine("Valor posição {0} foi excluido: ", pos);
            inicio = pos;
            vetor[inicio] = 00;
            inicio ++;
            fim = pos;

            return vetor;
         }

        public static int[] InserirFila(int[] vetor, ref  int fim, ref int inicio){  
            
            if (inicio == fim)
           {
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine("Informe 5 valores:");
                    vetor[i] = int.Parse(Console.ReadLine());
                    fim++;
                }
            
           }
           return vetor;
        }
    }
}