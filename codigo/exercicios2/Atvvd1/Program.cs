/*
Escreva um método recursivo que retorne o fatorial de um número.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio2{
    class fatorial{

        static int Fat(int x){
            int aux = 1;
            
            if(x == 2) 
                return(2);

            aux = x * Fat(x-1);
            return aux;
        }
        static void Main(string[] args){
            int x;
            Console.WriteLine("Informe o nº que deseja o fatorial: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine(Fat(x));
        }
    }
}