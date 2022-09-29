using System;

namespace Laboratorio6{
    class InsertSort{


        static int [] Insert(int []vet)
        {   
            int aux = 0;
            for(int i=1; i<vet.Length; i++){
                aux = vet[i];
                int j = i -1;
                while(j >= 0 && vet[j] > aux ){
                    vet[j+1] = vet[j];
                    j = j-1;
                }
                vet[j + 1] = aux;
            }
            return vet;
        }

        public static void Main(string[] args){
            int []vet = new int[]{4, 19, 8, 1, 7, 9, 18, 10, 0, 2};
            
            Insert(vet);
            for(int i=0; i<vet.Length; i++)
                Console.Write(vet[i]);
        }
    }
}