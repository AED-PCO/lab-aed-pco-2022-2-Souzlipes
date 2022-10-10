using System;

namespace Laboratorio3{
    class Quicksort{

        static void Swap(int[]valor, int inicio, int part){
            int aux = valor[part];
            valor[part] = valor[inicio];
            valor[inicio] = aux;
            Console.Write(".");
        }

        static int ComparaVetor(int []valor, int inicio, int fim){
            int pivor = valor[inicio];
            int part = inicio;
            for(int i = inicio + 1; i < fim; i++){
                if(valor[i] <= pivor){
                    part+=1;
                    Swap(valor, i, part);
                }
            }

            Swap(valor, inicio, part);

            return part;
        }
        static int[] QuickSort(int []valor, int inicio, int fim){
            if(inicio < fim){
                int ponto_pivo = ComparaVetor(valor,inicio,fim);
                QuickSort(valor,inicio, ponto_pivo - 1);
                QuickSort(valor,ponto_pivo + 1,fim);
            }
            return valor;
        }

        static void Main(string[] args){
            int []valor = new int[] { 1, 20, 49, 0, 18, 44, 7, 80, 3};

            QuickSort(valor,0, valor.Length - 1);
            
            for(int i = 0; i < valor.Length; i++){
                Console.Write(" "+valor[i]);
            }
        }
    }
}