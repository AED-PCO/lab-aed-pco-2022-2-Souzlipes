using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd2{

        public static void Main(string[] args) {
             int []vetor = new int[5];
             int shift = 0;

             int atribuicao = 0;

            for (int j = 0; j < vetor.Length; j++){
                int valor = j * j;
                atribuicao++;
                inserirPosicoes(vetor, ref shift, valor);
            }

            Console.WriteLine(" ");
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetor[i]);
            Console.WriteLine(" ");
            shift = retirarPosicoes(vetor,ref shift);
            shift -= 1;
            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", vetor[i]);
        
            

            Console.WriteLine(atribuicao);
        }
        public static void inserirPosicoes(int []vetor, ref int shift, int valor){
            vetor[shift] = valor;
            int atribuicao =0;
            atribuicao++;
            shift++;
            Console.WriteLine(atribuicao);
        }
        public static int retirarPosicoes(int []vetor, ref int aux){
            int atribuicao =0;
            aux -= 1;
            atribuicao++;
            Console.WriteLine("Removendo da pilha o elemento: " + vetor[aux]);
            Console.WriteLine(atribuicao);
            return aux;
        }
    }
}