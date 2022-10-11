using System;

namespace Laboratorio6{
    class bubble{

        /*static void lerVetor(int[]valor){
            for(int i=0; i < valor.Length; i++){
                Console.WriteLine("Informe valores aleatoriamente: ");
                valor [i] = int.Parse(Console.ReadLine());
            }
        }*/
        static int [] Bubble(int []vet)
        {   
            int aux = 0;
            int atribuicao = 0;
            int comp = 0;

            for(int i=0; i<vet.Length; i++){
                for(int j=0; j <vet.Length - 1; j++){
                    if(vet[j] > vet[j + 1]){
                        aux = vet[j];
                        atribuicao++;
                        vet [j] = vet[j + 1];
                        atribuicao++;
                        vet [j + 1] = aux;
                        atribuicao++;
                    }
                    comp++;
                }
            }
            Console.WriteLine(atribuicao + " " + comp);
            return vet;
        }

        public static void Main(string[] args){
            int []vet = new int[]{4, 19, 8, 1, 7, 9, 18, 10, 0, 2};
            
            Bubble(vet);
            for(int i=0; i<vet.Length; i++)
                Console.Write(vet[i]);
        }
    }
}