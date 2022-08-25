/*
Um Número é dito Primo se possui como divisores o número 1 e ele mesmo. Em outras
palavras, um Número Primo possui dois divisores de 1 até ele.
Faça um programa que mostre se um determinado número inteiro, lido pelo teclado, é
Um Número é dito Perfeita se a soma de seus divisores menores que ele é igual a ele. 
Por exemplo, o número 6 possui os divisores 1,2 e 3, cuja soma é igual a 6.
Faça um programa que lista os númaros perfeitos de 1 a 1000.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio1{
    class Num{
        static void Main(string[] args){
            
            int num = 0;
            Console.WriteLine("Informe um numero primo:");
            num = int.Parse(Console.ReadLine());

            bool valor = primo(ref num);

            if(valor == true)
            {
            Console.WriteLine("É primo");
            }else
            {
            Console.WriteLine("Não é primo");
            }
            
            Console.WriteLine("Os nº perfeitos de 1 até 1000 são:");
                for (int i = 1; i <= 1000; i++)
                {
                    int soma = 0;
                    for (int k = i; k > 0; k--)
                    {
                        if (i % k == 0 && k != i) soma += k;
                    }
                    if (soma == i) Console.WriteLine(i);
                }
        }
        static bool primo(ref int num){
            for(int i = 2; i < num;i++){
                if(num % i == 0){
                    return false;
                }
            }
            return true;
        }
    }
}

