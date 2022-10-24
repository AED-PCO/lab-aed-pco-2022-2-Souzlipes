using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd3{
        public static void Main(string[] args){
            string CPF = string.Empty;
            string espaco = " ";
            string []result = new string[50000];
            for(int i=0; i <50000; i++){
                result[i] += espaco + GerarCpf(CPF) + espaco;
            }

            MergeSort(result, 0, result.Length-1);
            
        }

        public static String GerarCpf(string semente){
            int comp = 0;
            int atribuicao = 0;
            int somatorio = 0;

            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random rnd = new Random();
            semente = rnd.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++){
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];
                atribuicao++;
                somatorio++;
            }

            resto = soma % 11;
            atribuicao++;
            comp++;
            if (resto < 2){
                resto = 0;
                atribuicao++;
            }else{
                atribuicao++;
                resto = 11 - resto;
            }
            semente = semente + resto;
            somatorio++;
            atribuicao++;
            soma = 0;

            for (int i = 0; i < 10; i++){
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];
                atribuicao++;
                somatorio++;
            }
            resto = soma % 11;
            atribuicao++;
            comp++;
            if (resto < 2){
                resto = 0;
                atribuicao++;
            }else{
                atribuicao++;
                resto = 11 - resto;
            }
            semente = semente + resto;
            atribuicao++;
            somatorio++;

            Console.WriteLine(somatorio+" "+atribuicao+" "+comp);
            
            return semente;
        }

        static void SubVetorCompara(string []valor, int inicio, int meio, int fim){
            int lengthInicio = meio - inicio + 1;
            int lengthFim = fim - meio;
            int i,j;
            string []inicioArray = new string[lengthInicio];
            string []fimArray = new string[lengthFim];

            for(i = 0; i < lengthInicio; i++) inicioArray[i] = valor[inicio + i];
            for(j = 0; j < lengthFim; j++) fimArray[j] = valor[meio + 1 + j];

            i = 0;
            j = 0;
            int k = inicio;

            for(; i < lengthInicio && j < lengthFim; k++){
                float n1 = float.Parse(inicioArray[i]);
                float n2 = float.Parse(fimArray[j]);

                if(n1 <= n2){
                    valor[k] = inicioArray[i];
                    i++;
                }else{
                    valor[k] = fimArray[j];
                    j++;
                }
            }
            for(; i < lengthInicio; i++, k++) valor[k] = inicioArray[i];
            for(; j < lengthFim; j++, k++) valor[k] = fimArray[j];
        }

        static void MergeSort(string []valor, int inicio, int fim){
            if(inicio < fim){
                int meio = inicio + (fim - inicio) / 2;
                MergeSort(valor, inicio, meio);
                MergeSort(valor, meio + 1, fim);
                SubVetorCompara(valor, inicio, meio, fim);
            }

        }
}
}