using System;

namespace Laboratorio3{
    class Ordem{

        static void lerVetor(int[]valor){
            for(int i=0; i < valor.Length; i++){
                Console.WriteLine("Informe valores aleatoriamente: ");
                valor [i] = int.Parse(Console.ReadLine());
            }
        }

        static void SubVetorCompara(int[]valor, int inicio, int fim){
            int meio = (inicio + fim) / 2;
            int lengthInicio = meio - inicio + 1;
            int lengthFim = fim - meio;
            int i,j;
            int []inicioArray = new int[lengthInicio];
            int []fimArray = new int[lengthFim];

            for(i = 0; i < lengthInicio; i++)
                inicioArray[i] = valor[inicio + i];
            for(j = 0; j < lengthFim; j++)
                fimArray[j] = valor[meio + 1 + j];
            i = 0;
            j = 0;
            int k = inicio;

            while(i < lengthInicio && j < lengthFim){
                if(inicioArray[i] <= fimArray[j]){
                    valor[k++] = inicioArray[i++];
                }else{
                    valor[k++] = fimArray[j++];
                }
            }

            while(i < lengthInicio){
                valor[k++] = inicioArray[i++];
            }
            while(j < lengthFim){
                valor[k++] = fimArray[j++];
            }
        }

        static int[] MergeSort(int []valor, int inicio, int fim){
            if(inicio < fim){
                int meio = (inicio + fim) / 2;
                MergeSort(valor, inicio, meio);
                MergeSort(valor, meio + 1, fim);
                SubVetorCompara(valor, inicio,fim);
            }
            return valor;
        }

        static void Main(string[] args){
            int []valor = new int[6];
            lerVetor(valor);
            MergeSort(valor, 0, valor.Length - 1);
            
            for(int i = 0; i < valor.Length; i++){
                Console.Write(valor[i]);
            }
        }
    }
}