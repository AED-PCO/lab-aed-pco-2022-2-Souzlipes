using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd2{

        public static void Main(string[] args) {
             int []vetor = new int[5];
             int []copia = new int[5];
             int shift = 0;

            for (int j = 0; j < vetor.Length; j++){
                int valor = j * j;
                inserirPosicoes(vetor, ref shift, valor);
            }

            Console.WriteLine(" ");
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetor[i]);
            Console.WriteLine(" ");

            copia = copiarPilha(vetor, shift);
            

            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", copia[i]);
        
            Console.WriteLine("\n"+shift);
        }
        public static void inserirPosicoes(int []vetor, ref int shift, int valor){
            vetor[shift] = valor;
            shift++;
        }
        public static int retirarPosicoes(int []vetor, ref int aux){
            aux --;
            
            Console.WriteLine("Removendo da pilha o elemento: " + vetor[aux]);
            return vetor[aux];
        }

        public static int[] copiarPilha(int []vetor, int shift){
            int []aux = new int[vetor.Length];
            int []copia = new int[vetor.Length];
        

            for(int i = 0; i <vetor.Length;){
                inserirPosicoes(aux, ref i, retirarPosicoes(vetor, ref shift));
            }

            shift = vetor.Length;

            for(int i = 0; i < vetor.Length;)
                inserirPosicoes(copia, ref i, retirarPosicoes(aux, ref shift));

            return copia;

        }
    }
}