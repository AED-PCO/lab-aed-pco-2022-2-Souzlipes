/*
Uma multiplicação pode ser vista como uma sequência de somas. 
Escreva um método recursivo que realize a multiplicação de dois números inteiros,
A e B, recebidos por  parâmetro.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/


using System;

namespace exercicio2{
    class multiplica{

        static int Multiplica(int A, int B){
            int aux;
            int atribuicao = 1;
            int comp = 0;
            int somatorio = 0;
            if(B == 0)
                return(0);
             
            if (B < 0){
                aux = A*-1 + Multiplica(A, B+1);
                atribuicao++;
                somatorio++;
                Console.Write("Atribuicao: " + atribuicao+" ");
                Console.Write("Somatorio: " + somatorio+" ");
            } 
            else {
                aux = A + Multiplica(A, B-1);
                somatorio++;
                atribuicao++;
                Console.Write("Atribuicao: " + atribuicao+" ");
                Console.Write("Somatorio: " + somatorio+" ");
                
            }
            comp++;
            Console.WriteLine("Comparacao: "+comp);
            return(aux);
        }
        static void Main(string[] args){
            int A, B;
            Console.Write("Informe dois nº: ");
            string [] linha = Console.ReadLine().Split(' ');
            A=int.Parse(linha[0]);
            B=int.Parse(linha[1]);
            Console.Write(Multiplica(A, B));
        }
    }
}