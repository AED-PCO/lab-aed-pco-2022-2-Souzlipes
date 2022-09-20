/*
Escreva um método recursivo que receba  uma frase e retorne a mesma frase, sem 
nenhuma vogal. 

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio2{
    class pow{

        static string retiraVogal(char []caractere, char []vogal, int pos){
            string aux = "";
            int comp = 0;
            int atribuicao = 0;
            int somatorio = 0;
            comp ++;
            if (pos == caractere.Length) 
                return (""); 

            comp++;
            if(pos < caractere.Length){
                for (int i = 0; i < vogal.Length; i++){
                    comp++;
                    if (caractere[pos] == vogal[i]){
                        aux = caractere[pos].ToString();
                        aux = "";
                        atribuicao++;
                        return retiraVogal(caractere, vogal,pos+1);
                    }else{
                        atribuicao++;
                        aux = caractere[pos].ToString();    
                    }
                }
            }
            Console.Write("Comparacao: "+atribuicao+" ");
            Console.Write("Comparacao: "+comp+" ");

            somatorio++;
            Console.WriteLine("Somatorio: "+somatorio);
            return aux = aux + retiraVogal(caractere, vogal,pos+1);
        }

        static void Main(string[] args){
            string palavra;
            char [] vogal =new char[] {'a','e','i','o','u','A','E','I','O','U'};
            Console.Write("Insira uma palavra: ");
            palavra = Console.ReadLine();
            char[] caractere = palavra.ToCharArray();

            retiraVogal(caractere, vogal,0);
            Console.WriteLine(retiraVogal(caractere, vogal,0));
        }
    }
}