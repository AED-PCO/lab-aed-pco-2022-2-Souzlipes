using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd1{

        public static void Main(string[] args) {
             int []vetor = new int[5];
             int shift = 0;

            for (int j = 0; j < vetor.Length; j++){
                int valor = j * j;
                inserirPosicoes(vetor, ref shift, valor);
            }

            Console.WriteLine(" ");
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetor[i]);
            Console.WriteLine(" ");
            shift = retirarPosicoes(vetor,ref shift);
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetor[i]);
        
            Console.WriteLine("\n"+shift);
        }
        public static void inserirPosicoes(int []vetor, ref int shift, int valor){
            vetor[shift] = valor;
            shift++;
        }
        public static void retirarPosicoes(int []vetor, ref int shift){

            console.WriteLine("Valor retirado é: {0}",vetor[shift]);
            shift-=1;
        }
    }
}