using System;

namespace Atvvd1
{
    class Sentinela
    {
        public int elemento;
        public Sentinela prox,ant;
        public Sentinela() {}
        public Sentinela(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
            this.ant = null;
        }
    }
}