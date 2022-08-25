/*
Escreva um método recursivo que calcule a soma dos elementos de valor par de um 
vetor de números inteiros positivos.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio2{
    class Soma{
        static void lerVetor(int []valor){
            int i;
            for (i = 0; i < valor.Length; i++){
                Console.Write("Informe 5 valores: ");
                valor[i] = int.Parse(Console.ReadLine());

                if(valor[i] % 2 == 1)
                    valor[i] = 0;
            }
            
        }

        static int SomaPar(int []valor,int i){
           if(i < valor.Length)
                return valor[i] + SomaPar(valor, i+1);
           
           return (0);
        }
        static void Main(string[] args){
            int []valor = new int[5];
            lerVetor(valor);
            
            Console.Write(SomaPar(valor,0));
        }
    }
}