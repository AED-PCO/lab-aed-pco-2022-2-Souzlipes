/*
Faça um programa que receba os elementos de dois vetores, À e B, cada um com 5 posiçoe
Considere que nenhum das vetores possui elementos repetidos.
Crie um vetor resultante C que possua os elementos comuns entre A e B.
Crie um vetor resultante D que contenha os elementos de A que não existam em B.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio1{
    class vetor{
       static void lerVetor(int []valor){
            for (int i = 0; i < 5; i++){
                Console.Write("Informe um valor: ");
                valor[i] = int.Parse(Console.ReadLine());
            }
        }

        static void comparaVetor(int []A,int []B, int[]C, int[]D){


                int i;
                int valorC = 0, valorD = 0, dif=0;

                int atribuicao = 3;
                int comp = 0;
                
                for (i = 0; i < 5; i++){
                    for (int j = 0; j < 5; j++){
                        if (A[j] == B[i]){
                            C[valorC] = A[j];
                            atribuicao++;
                            valorC++;
                        }
                        if (A[i] == B[j]) dif++;
                        comp+=2;
                    }
                    comp++;
                    if (dif == 0){
                        D[valorD] = A[i];
                        atribuicao++;
                        valorD++;
                    }
                    dif = 0;
                    atribuicao++;
                }
                Console.WriteLine("Comp "+comp);
                Console.WriteLine("Atribuicao "+atribuicao);
                
            
        }
        static void Main(string[] args){
            int []A = new int[5];
            int []B = new int[5];
            int []C = new int[5];
            int []D = new int[5];

            int atribuicao = 8;


            lerVetor(A);
            lerVetor(B);
            comparaVetor(A,B,C,D);
            


            for (int i = 0;i <5; i++)
            {
                Console.Write("Valores comuns: " +C[i]+" ");
                Console.Write("Valores diferentes: " +D[i]+" ");
                
            }
        }
    }
}