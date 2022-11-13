using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd2{

        public static void Main(string[] args) {
             int []vetor = new int[5];
             int shift = 0;
             int valor = 0;


            for (int j = 0; j < vetor.Length; j++){
                valor = j * j;
                
                if (shift < 5){
                    Console.WriteLine("Inserindo valor: " + valor);
                    InserirFila(vetor, ref shift, valor);
                    shift += 1;
                    Console.WriteLine(shift);
                }
            }

            for (int i = 0; i < vetor.Length; i++)
                    Console.Write(" "+vetor[i]);

            Console.WriteLine(" ");
           
           string retirar = "";

            Console.WriteLine("Deseja retirar posições na fila? ");
            retirar = Console.ReadLine();
            retirar = retirar.ToUpper();
            
            
           if(retirar == "S"){
                Console.WriteLine("Qual valor? ");
                valor = int.Parse(Console.ReadLine());

                retirarPosicoes(vetor, ref shift, valor);
                

                for (int i = 0; i < vetor.Length; i++)
                    Console.Write(" "+vetor[i]);

                Console.WriteLine(" ");


                string inserir = "";

                Console.WriteLine("Deseja reenserir alguma posição?");
                inserir = Console.ReadLine();
                inserir = inserir.ToUpper();

                
                if(inserir == "S"){
                    Console.WriteLine("Qual valor? ");
                    valor = int.Parse(Console.ReadLine());

                    inserirPosicoes(vetor, ref shift, valor);

                    for (int i = 0; i < vetor.Length; i++)
                        Console.Write(" "+vetor[i]);
                }
            
           }
           
           if(retirar == "N"){
            
           }
        }
        public static int[] inserirPosicoes(int []vetor, ref int shift, int valor){
            vetor[shift] = valor;
            shift++;
            return vetor;
        }

        public static int[] retirarPosicoes(int []vetor, ref int shift, int valor){
            int aux;

            for(int i = 0; i < vetor.Length; i++){
                
                if(valor == vetor[i]){
                    aux  = vetor[i];
                    Console.WriteLine(vetor[i]);
                    vetor[i] = vetor[shift-1];
                    shift = i;
                    Console.WriteLine("Valor retirado: {0}",aux);
                    break;
                }
                
                if(valor != vetor[i]){
                    Console.WriteLine("Valor não encontrado");
                }
            }
            return vetor;
        }

        public static int[] InserirFila(int[] vetor, ref  int shift, int valor){  
            vetor[shift] = valor;
            return vetor;
        }
    }
}