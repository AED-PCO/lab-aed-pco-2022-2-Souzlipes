using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd1{
        public static void Main(string[] args){
            string texto;

            Console.WriteLine("Escreva um texto: ");
            texto= Console.ReadLine(); 

            Compara(texto);

        }

        static void Compara(string texto){
            int igual  = 0;
            int diferente = 0;
            StreamReader sr = new StreamReader("arqu1.txt");
            string linha = sr.ReadLine();

            string[] arquivos = linha.Split(" ");

           while(linha != null){
            for(int i = 0; i < arquivos.Length; i++){
                Console.WriteLine(arquivos[i]);
                    if(arquivos[i] == texto)
                        igual++;
                    else
                        diferente++;
           }
           linha = sr.ReadLine();
           }
           sr.Close();

           Console.WriteLine("Possui {0} palavras iguais.",igual);
           Console.WriteLine("Possui {0} palavras diferentes.",diferente);

        }
    }
}