using System;

namespace ABB
{
    class No
    {
        int elemento;
        No esquerda;
        No direito;
        No(int elemento)
        {
            this(elemento, null, null);
        }
        No(int elemento, No esquerda, No direito)
        {
            this.elemento = elemento;
            this.esquerda = esquerda;
            this.direito = direito;
        }
    }
}