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

            copia = copiarFila(vetor, shift);
            

            for (int i = 0; i <vetor.Length; i++)
                Console.Write(" {0} ", copia[i]);
        
            Console.WriteLine("\n"+shift);
        }
        public static void inserirPosicoes(int []vetor, ref int shift, int valor){
            vetor[shift] = valor;
            shift++;
        }
        public static int retirarPosicoes(int []vetor, ref int aux){
            int pos = vetor[0];
            for(int i = 0; i < vetor.Length-1;i++){
                vetor[i] = vetor[i+1];
            }
            aux--;
            return pos;
        }
        public static int retirarPilha(int []aux, ref int pos){
            pos --;
            
            Console.WriteLine("Removendo da pilha o elemento: " + aux[pos]);
            return aux[pos];
        }

        public static int[] copiarFila(int []vetor, int shift){
            int []aux = new int[vetor.Length];
            int []copia = new int[vetor.Length];
        

            for(int i = 0; i <vetor.Length;){
                inserirPosicoes(aux, ref i, retirarPosicoes(vetor, ref shift));
            }

            for(int i = 0; i < vetor.Length;){
                inserirPosicoes(vetor, ref i, aux[i]);
            }

            shift = vetor.Length;

            for(int i = 0; i < vetor.Length;)
                inserirPosicoes(copia, ref i, retirarPilha(aux, ref shift));

            return copia;

        }
    }
}