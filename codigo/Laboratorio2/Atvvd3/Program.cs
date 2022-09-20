/*
Escreva um método recursivo que realize a potenciação entre dois números inteiros, A 
e B, recebidos por parâmetro. Seu método deve, portanto, retornar o resultado de AB

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/


using System;

namespace exercicio2{
    class pow{

        static int Pow(int A, int B){
            int aux = 0;
            int atribuicao = 1;
            int comp = 0;
            int somatorio = 0;

            comp++;
            if(B == -1)
                return(-A);
            comp++;
            if(B == 1)
                return(A);
            comp++;
            if (B < 0){
                aux = A * Pow(A, B+1);
                somatorio++;
                atribuicao++;
                Console.Write("Atribucao: " + atribuicao+" ");
                Console.Write("Somatorio: " + somatorio+" ");
            } 
            else {
                aux = A * Pow(A, B-1);
                somatorio++;
                atribuicao++;
                Console.Write("Atribucao: " + atribuicao+" ");
                Console.Write("Somatorio: " + somatorio+" ");
            }
            comp++;
            Console.WriteLine("Comparacao: " + comp);
            return(aux);
        }
        static void Main(string[] args){
            int A, B;
            Console.Write("Informe dois nº: ");
            string [] linha = Console.ReadLine().Split(' ');
            A=int.Parse(linha[0]);
            B=int.Parse(linha[1]);
            Console.Write(Pow(A, B));
        }
    }
}