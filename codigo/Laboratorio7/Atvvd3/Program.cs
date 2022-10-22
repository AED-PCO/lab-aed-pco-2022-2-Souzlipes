using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd3{
        public static void Main(string[] args){
            String linha;

            StreamReader sr = new StreamReader("arq1.txt");
            linha = sr.ReadLine();

            
            
            StreamWriter sw = new StreamWriter ("saida.txt");
            sw.WriteLine(Invert(linha));

            sr.Close();
            sw.Close();
        }

        static string Invert(string linha){
            char [] palavra = linha.ToCharArray();
            string result = string.Empty;
            for(int i = palavra.Length - 1; i >= 0; i--){

                result+= palavra[i];
            }

            return result;
        }
    }
}