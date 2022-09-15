using System;

namespace Laboratorio3{
    class buscaBinaria{
        static int pesquisaBinaria(int[] vetor, int valor, int meio, int pos)
        {   
            if(valor == vetor[meio])
                return pos = meio;
            else if (valor > vetor[meio])
                return pesquisaBinaria(vetor, valor, meio+1, pos);
            else
                return pesquisaBinaria(vetor, valor, meio-1, pos);
        }

        public static void Main(string[] args){
            int []vetor = new int[] {1, 40, 7 ,9, 10, 90, 8};
            int valor, pos = 0;
            Console.Write("Informe um valor:");
            valor = int.Parse(Console.ReadLine());

            Array.Sort(vetor);
            int meio;
            int min = 0;
            int max = vetor.Length - 1;

            meio = (int)(min + max) / 2;
            Console.Write("A posição do nº solicitado é a {0}º",pesquisaBinaria(vetor, valor,meio, pos));

        }
    }
}