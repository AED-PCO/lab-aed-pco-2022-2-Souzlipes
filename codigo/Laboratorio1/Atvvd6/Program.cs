/*
Faça um programa que chame uma função capaz de calcular.x7, sendo e y inteiros:
Utilize passagem de parâmetros por referência.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio1{
    class funcao{

        static int Multiplica(ref int x, ref int y){
            int potencia = 1;
            int atribuicao = 0;
            for(int i = 0; i < y; i++){
                potencia *= x;
                atribuicao++;
            }
            Console.WriteLine("Atribuicao: " + atribuicao);
            return potencia;
        }
        static void Main(string[] args){
            int x, y;
            Console.WriteLine("Informe um valor: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua potencia: ");
            y = int.Parse(Console.ReadLine());

            int result =  Multiplica(ref x, ref y);

            Console.WriteLine("A potencia do seu numero é: "+result);
        }
    }
}