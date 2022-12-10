using System;

namespace ABB
{
    class No
    {
        public int elemento;

        public No node;
        public No esquerda;
        public No direita;
        public No(int elemento)
        {
        }
        public No(int elemento, No esquerda, No direita)
        {
            this.elemento = elemento;
            this.esquerda = esquerda;
            this.direita = direita;
        }
    }
}