using System;

namespace Laboratorio3{
    class buscaBinaria{
        static int pesquisaBinaria(int[] vetor, int valor, int meio, int pos)
        {   
            int comp = 0;
            int atribuicao = 1;
            int somatorio = 0;

            comp++;
            if(valor == vetor[meio]){
                atribuicao++;
                return pos = meio;
            }else if (valor > vetor[meio]){
                comp++;
                somatorio++;
                Console.Write("Comparação: "+comp+" ");
                Console.Write("Atribuição: "+atribuicao+" ");
                Console.Write("Somatório: "+somatorio+" ");
                
                return pesquisaBinaria(vetor, valor, meio+1, pos);
            }else{
                Console.Write("Comparação: "+comp+" ");
                Console.Write("Atribuição: "+atribuicao+" ");
                Console.Write("Somatório: "+somatorio+" ");
                
                return pesquisaBinaria(vetor, valor, meio-1, pos);
            }
        }

        public static void Main(string[] args){
            int []vetor = new int[] {1, 40, 7 ,9, 10, 90, 8};
            int valor, pos = 0;
            int atribuicao = 7;
            int somatorio = 0;


            Console.Write("Informe um valor:");
            valor = int.Parse(Console.ReadLine());
            atribuicao++;

            Array.Sort(vetor);
            int meio;
            int min = 0;
            int max = vetor.Length - 1;
            atribuicao+=2;

            meio = (int)(min + max) / 2;
            somatorio++;
            atribuicao++;


            Console.Write("Atribuição: "+atribuicao+" ");
            Console.Write("Somatório: "+somatorio+" ");
            Console.Write("\n A posição do nº solicitado é a {0}º",pesquisaBinaria(vetor, valor,meio, pos));

        }
    }
}