using System;

namespace Atvvd1
{
    class SentinelaDuplo
    {
        public int elemento;
        public SentinelaDuplo prox,ant;
        public SentinelaDuplo() {}
        public SentinelaDuplo(int elemento)
        {
            this.elemento = elemento;
            this.prox = null;
            this.ant = null;
            
        }
    }
}