using System;

namespace AVL
{
    class No
    {
        public int elemento;
        public int altura;
        public No esquerda;
        public No direita;
        public No(int elemento)
        {
            this.Node(elemento,null,null,0);
        }
        void Node(int elemento, No esquerda, No direita,int altura)
        {
            this.elemento = elemento;
            this.esquerda = esquerda;
            this.direita = direita;
            this.altura = altura;
        }
    }
}