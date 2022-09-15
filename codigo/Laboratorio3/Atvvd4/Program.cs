using System;

namespace Laboratorio3{
    class buscaBinaria{
        static int pesquisaBinaria(int[] vetor, int valor, int meio)
        {   
            if(valor == vetor[meio])
                return meio;
            else if (valor > vetor[meio])
                return pesquisaBinaria(vetor, valor, meio+1);
            else
                return pesquisaBinaria(vetor, valor, meio-1);
        }

        public static void Main(string[] args){
            int []vetor = new int[] {1, 40, 7 ,9, 10, 90, 8};
            int valor;
            Console.Write("Informe um valor:");
            valor = int.Parse(Console.ReadLine());

            Array.Sort(vetor);
            int meio;
            int min = 0;
            int max = vetor.Length - 1;

            meio = (int)(min + max) / 2;
            Console.Write("A posição do nº solicitado é a {0}º",pesquisaBinaria(vetor, valor,meio));

        }
    }
}