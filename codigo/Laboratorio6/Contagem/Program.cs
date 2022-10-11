using System;

namespace Laboratorio6{
    class ContagingSort{


        static int [] Contagem(int []vetor, int maior)
        {   
            int atribuicao = 0;
            int somatorio = 0;
            int[] cumulativa = new int[maior];

            // frequência
            for (int i = 0; i < vetor.Length; i++) {
                cumulativa[vetor[i] - 1] += 1;
                somatorio++;
                atribuicao++;
            }
            
            // cumulativa
            for (int i = 1; i < cumulativa.Length; i++) {
                cumulativa[i] += cumulativa[i-1];
                somatorio++;
                atribuicao++;
            }

            int[] aux = new int[vetor.Length];

            for (int i = vetor.Length - 1; i >= 0; i--) {
                aux[cumulativa[vetor[i] - 1] -1] = vetor[i];
                atribuicao++;
                cumulativa[vetor[i] - 1] -= 1;
                atribuicao++;

            }
            Console.WriteLine(atribuicao + " " + somatorio);
            return aux;  
        }

        public static void Main(string[] args){
            int []vetor = new int[]{1, 2, 8, 8, 3, 2, 7, 5, 5, 6};
            
            int []resultado = Contagem(vetor, 8);
            for(int i=0; i<resultado.Length; i++)
                Console.Write(resultado[i]);
        }
    }
}