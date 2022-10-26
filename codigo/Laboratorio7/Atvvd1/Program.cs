using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd1{
        public static void Main(string[] args){
            string []texto = textoCompara.Split(" ");

            Console.WriteLine("Escreva um texto: ");
            texto= Console.ReadLine(); 

            //Compara(texto);


            int igual  = 0;
            int diferente = 0;
            StreamReader sr = new StreamReader("arqu1.txt");
            string linha = sr.ReadLine();

           while(linha != null){
            string []arquivos = linha.Split(" ");
            
            for(int i = 0; i < arquivos.Length; i++){
                Console.WriteLine(arquivos[i]);
                    if(arquivos[i] == textoCompara)
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

        static void Compara(string texto){
            string texto;

            Console.WriteLine("Escreva um texto: ");
            texto= Console.ReadLine(); 

            Compara(texto);


            int igual  = 0;
            int diferente = 0;
            StreamReader sr = new StreamReader("arqu1.txt");
            string linha = sr.ReadLine();

           while(linha != null){
            string []arquivos = linha.Split(" ");
            string []texto = textoCompara.Split(" ");
            for(int i = 0; i < arquivos.Length; i++){
                Console.WriteLine(arquivos[i]);
                    if(arquivos[i] == textoCompara)
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