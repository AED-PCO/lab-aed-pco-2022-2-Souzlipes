using System;

namespace Laboratorio6{
    class SelectionSort{


        static int [] Selection(int []vet)
        {   
            int aux = 0;
            int atribuicao = 0;
            int comp = 0;

            for(int i=0; i<vet.Length; i++){
                for(int j=0; j <vet.Length; j++){
                    comp++;
                    if(vet[i] < vet[j]){
                        aux = vet[j];
                        atribuicao++;
                        vet[j] = vet[i];
                        atribuicao++;
                        vet[i] = aux;
                        atribuicao++;
                    }
                }
            }
            Console.WriteLine(atribuicao + " " + comp);
            return vet;
        }

        public static void Main(string[] args){
            int []vet = new int[]{4, 19, 8, 1, 7, 9, 18, 10, 0, 2};
            
            Selection(vet);
            for(int i=0; i<vet.Length; i++)
                Console.Write(vet[i]);
        }
    }
}