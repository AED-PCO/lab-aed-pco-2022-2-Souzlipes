using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd1{
        public static void Main(string[] args){
            String linha;
            String texto;

            StreamReader sr = new StreamReader("arqu1.txt");
            linha = sr.ReadLine();

            Console.WriteLine("Escreva um texto: ");
            texto= Console.ReadLine(); 

            sr.Close();
        }

        static void Compara(string linha, string texto){
           for(int i = 0; i < linha.Length; i++){
            for(int j = 1; j < texto.Length; j++){
                if(linha[i] == texto[j]){
                    Console.WriteLine("Letra {0} é IGUAL", texto[j]);
                    Console.WriteLine(linha[i]);
                }else
                    Console.WriteLine("Letra {0} é DIFERENTE", texto[j]);
                
            }
           }

        }
    }
}