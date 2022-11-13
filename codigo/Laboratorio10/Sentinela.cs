using System;

namespace Fila
{
    class Sentinela
    {
        public int elemento;
        public Sentinela prox;
        
        public Sentinela() {}
        public Sentinela(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
        }
    }
}