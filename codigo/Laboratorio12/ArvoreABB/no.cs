using System;

namespace ABB
{
    class No
    {
        public int elemento;
        public No esquerda;
        public No direita;
        public No(int elemento)
        {
            this.Node(elemento,null,null);
        }
        void Node(int elemento, No esquerda, No direita)
        {
            this.elemento = elemento;
            this.esquerda = esquerda;
            this.direita = direita;
            
        }
    }
}