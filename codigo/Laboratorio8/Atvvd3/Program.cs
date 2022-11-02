using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd2{

        public static void Main(string[] args) {
             int []vetor = new int[5];
             int shift = 0;
             int valor = 0;

            for (int j = 0; j < 5/2; j++){
                valor = j * j;
                if (shift < 5){
                    Console.WriteLine("Inserindo valor: " + valor);
                    InserirFila(vetor, ref shift, valor);
                    shift += 1;
                }
            }

            Console.WriteLine(vetor);


            valor = 5 * 5;
            if (shift < 5){
                InserirFila(vetor, ref shift, valor);
                shift += 1;
                Console.WriteLine(vetor);
            }else{
                inserirPosicoes(-1, vetor,  ref shift, valor + 2);
                shift += 1;
                inserirPosicoes(3, vetor, ref shift, valor);
                shift += 1;
                inserirPosicoes(9, vetor, ref shift, valor * valor);
                shift += 1;
            }
        }
        public static int[] inserirPosicoes(int flag,int []vetor, ref int shift, int valor){
            if (flag < 0)
            {
                vetor = InserirFila(vetor, ref shift, valor);
                return vetor;
            }
            if (flag > shift)
                flag = shift;
            for(int i = shift; i > flag; i--)
                
            {
                vetor[i] = vetor[i - 1];
            }
            vetor[flag] = valor;
            return vetor;
        }

        public static int[] InserirFila(int[] vetor, ref  int shift, int valor){
            vetor[shift] = valor;
            return vetor;
        }
    }
}