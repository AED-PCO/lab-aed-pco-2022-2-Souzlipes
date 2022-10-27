using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd1{
        public static void Main(string[] args){
            string texto;

            Console.WriteLine("Escreva um texto: ");
            texto= Console.ReadLine();
            string[] palavras = texto.Split(" "); 

            int igual  = 0;
            int diferente = 0;
            StreamReader sr = new StreamReader("arqu1.txt");
            string linha = sr.ReadLine();

            string[] arquivos = linha.Split(" ");


           while(linha != null){
                for(int i = 0; i < arquivos.Length;i++){
                    for(int j = 0; j < palavras.Length; j++){
                        if(arquivos[i] == palavras[j])
                            igual++;
                }
                    diferente++;
                }
           linha = sr.ReadLine();
           }
           sr.Close();

           Console.WriteLine("Possui {0} palavras iguais.",igual);
           Console.WriteLine("Possui {0} palavras diferentes.",diferente - igual);

    

        }
    }
}