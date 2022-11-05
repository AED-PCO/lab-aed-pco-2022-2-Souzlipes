using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd1{

        public static void Main(string[] args) {
             int []vetor = new int[5];
             int[] vetorFinal = new int[5];
             int shift = 0;

            for (int j = 0; j < vetor.Length; j++){
                int valor = j * j;
                inserirPosicoes(vetor, ref shift, valor);
            }

            Console.WriteLine(" ");
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetor[i]);
            Console.WriteLine(" ");
            copiaFila(vetor, vetorFinal, ref shift);
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetor[i]);
            Console.WriteLine(" ");
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetorFinal[i]);    
        
            Console.WriteLine("\n"+shift);
        }
        public static void inserirPosicoes(int []vetor, ref int shift, int valor){
            vetor[shift] = valor;
            shift++;
        }
        public static void retirarPosicoes(int []vetor, ref int shift, int[] vetorFinal){
            int fim = shift - 1;
            Console.WriteLine(fim);
            for(int i = 1; i < shift; i++){
                int aux = vetor[i-1];
                
                vetor[i-1] = vetor[i];
                vetorFinal[i-1] = aux;
                vetorFinal[i]=vetor[fim];
            }
            
            //vetorFinal[fim]=vetor[fim];
            shift-=1;
        }
        public static void copiaFila(int[] vetor, int[] vetorFinal, ref int shift){
            //for (int i = 0; i < vetor.Length; i++){
            retirarPosicoes(vetor, ref shift,vetorFinal);
            //}
        }
    }
}