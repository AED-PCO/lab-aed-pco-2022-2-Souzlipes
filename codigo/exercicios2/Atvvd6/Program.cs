/*
Escreva um método recursivo que receba  uma frase e retorne a mesma frase, sem 
nenhuma vogal. 

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/

using System;

namespace exercicio2{
    class pow{

        static string retiraVogal(string palavra, char []vogal){
            if (palavra == "") 
                return (""); 
            for(int i=0; i<vogal.Length; i++){
                if(palavra[0] == vogal[i]) 
                    palavra = "";
                    return retiraVogal(palavra, vogal); 
            }

            return retiraVogal(palavra, vogal);
        }

        static void Main(string[] args){
            string palavra;
            char [] vogal =new char[] {'a','e','i','o', 'u'};
            Console.Write("Insira uma palavra: ");
            palavra = Console.ReadLine();

            retiraVogal(palavra, vogal);
            Console.WriteLine(retiraVogal(palavra, vogal));
        }
    }
}