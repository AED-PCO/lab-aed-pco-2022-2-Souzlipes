/*
Faça um programa que receba os elementos de uma matriz de 5 linhas por 3 colunas.
Mostre a soma dos elementos de cada uma das linhas e das colunas da matriz.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio1{
    class vetor{
    public static void Main(string[] args){
        int [,] matriz = new int[5,3];
        int []somaLinha = new int[5];

        lerMatriz(matriz);  
        calculaMatriz(matriz, somaLinha);


    }
    public static void lerMatriz(int [,]matriz) {
        int atribuicao = 2;
        int i, j;
        for(i = 0; i < matriz.GetLength(0); i++){
            for(j = 0; j < matriz.GetLength(1); j++){
                matriz[i, j] = int.Parse(Console.ReadLine());
                atribuicao++;
            }
        }
        Console.WriteLine("Atribuicao 1 = "+atribuicao);
    }
     public static void calculaMatriz(int [,]matriz, int []somaLinha){
        int i, j, total = 0;
        int atribuicao = 5;
        int somatorio = 0;

        for(i = 0; i < matriz.GetLength(0); i++){
            somaLinha[i] = 0; 
            for( j = 0; j < matriz.GetLength(1); j++){
                somaLinha[i] += matriz[i,j];
                somatorio++;
                atribuicao++;
            }
        total += somaLinha[i];
        somatorio++;
        atribuicao++;
        }
        for(i = 0; i < 5; i++){
            Console.WriteLine("Valor da soma da linha da matriz:"+somaLinha[i]+" ");
        }

        Console.WriteLine("Atribuicao 2 = "+atribuicao);
        Console.WriteLine("Somatorio "+somatorio);
    }
}

}