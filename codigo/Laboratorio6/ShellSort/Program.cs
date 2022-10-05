using System;

namespace Laboratorio3{
    class Ordem{
        static int[] ShellSort(int []valor, int TAM){
            for (int h = TAM / 2; h > 0; h /= 2){
                for (int i = h; i < TAM; i++){
                    var currentKey = valor[i];
                    var k = i;
                    while (k >= h && valor[k - h] > currentKey){
                        valor[k] = valor[k - h];
                        k -= h;
                    }
                    valor[k] = currentKey;
                }
            }
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