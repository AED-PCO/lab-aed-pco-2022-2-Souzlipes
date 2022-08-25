/*
Escreva um método recursivo que receba uma frase e uma letra como parâmetros. 
Este método deve retornar a quantidade de ocorrências desta letra nesta frase.

Turma (9795100) Algoritmos e Estruturas de Dados - Campos Contegem noite laboratório 102.

By: Luis Felipe de Souza Pereira.
*/


using System;

namespace exercicio2{
    class pow{

        static int Letras(string palavra, char caracter){
            if (palavra == "") 
                return 0; 
            if(palavra[0] == caracter) 
                return Letras(palavra.Substring (1), caracter)+1; 

            return Letras(palavra.Substring (1), caracter);
        }

        static void Main(string[] args){
            string palavra;
            char caractere;
            Console.Write("Insira uma palavra: ");
            palavra = Console.ReadLine();
            Console.WriteLine("Qual letra você deseja buscar na palavra? ");
            caractere = Console.ReadKey().KeyChar;

            int result = Letras(palavra, caractere);
            Console.WriteLine("\n \nNa sua palavra informada, possui {0} letras {1}", result, caractere);
        }
    }
}