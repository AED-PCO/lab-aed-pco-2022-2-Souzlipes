/*
Atividade I

Alguns números de quatro a /garis mos possuem uma característica particular,Se separamo
esse número em dois grupos e os somarmos encontramos um outro número cujo quadrada
exatamente igual ao número fornecido anteriormente. Veja o exemplo:
Número =3025
Separando o número em dois grupos de dois algarismos temos o 30 e o 25
A soma de 30 com 25 é igual a 55 o
O Quadrado de 55 é igual a 3025.
Faça um programa que mostre os números de 1000 a 9999 que possuem essa caracteristica.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio1{
    class Num{
        static void Main(string[] args){
            for(int i=0; i<9999; i++){
                int numero1 = (i/100);
                int numero2 = (i%100);
                int soma = numero1 + numero2;
                if(Math.Pow(soma,2) == i)
                    Console.WriteLine(i);
                }    
                Console.ReadKey();
            }
        }
    }