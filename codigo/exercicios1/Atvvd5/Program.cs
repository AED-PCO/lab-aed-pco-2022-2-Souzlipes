/*
Faça um programa que chame uma função capaz de calcular o Fatorial de um número inteiro

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio1{
    class Num{
        static void Main(string[] args){
            int num, fat=1;
            Console.WriteLine("Informe o nº do fatorial ");
            num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++){
                fat = fat * i;
            }
                
            Console.WriteLine("O fatorial é: {0}",fat);
        }
    }
}