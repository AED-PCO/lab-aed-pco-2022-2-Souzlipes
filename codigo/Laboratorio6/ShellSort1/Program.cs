using System;

namespace Laboratorio6{
    class Shell{
        static int[] ShellSort(int []valor, int TAM){
            int comp = 0;
            int atribuicao = 0;
            for (int h = TAM / 2; h > 0; h /= 2){
                for (int i = h; i < TAM; i++){
                    int chave = valor[i];
                    int k = i;
                    comp++;
                    while (k >= h && valor[k - h] > chave){
                        valor[k] = valor[k - h];
                        atribuicao++;
                        k -= h;
                        atribuicao++;
                    }
                    atribuicao++;
                    valor[k] = chave;
                }
            }
            Console.WriteLine(atribuicao + " " + comp);
            return valor;
        }

        static void Main(string[] args){
            int []valor = new int[] { 1, 20, 49, 0, 18, 44, 7, 80, 3};

            ShellSort(valor, valor.Length);
            
            for(int i = 0; i < valor.Length; i++){
                Console.Write(valor[i]);
            }
        }
    }
}