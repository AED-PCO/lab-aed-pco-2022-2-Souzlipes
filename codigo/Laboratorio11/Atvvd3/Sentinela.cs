using System;

namespace Atvvd3
{
    class SentinelaCircular
    {
        public int elemento;
        public  SentinelaCircular prox, ant;
        public SentinelaCircular() {}
        public SentinelaCircular(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
            this.ant = null;

        }
    }
}