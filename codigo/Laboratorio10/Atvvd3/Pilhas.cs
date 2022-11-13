using System;

namespace Fila
{
    class Pilhas
    {
        private Sentinela topo;
        public Pilhas()
        {
            topo = null;
        }
        public void inserir(int x)
        {
            Sentinela aux = new Sentinela(x);
            aux.prox = topo;
            topo = aux;
            aux = null;
        }
        public int remover()
        {
            if(topo == null)
            {
                Console.WriteLine("Lista vazia!");
                return -1;
            }
            int elemento = topo.elemento;
            Sentinela aux = topo;
            topo = topo.prox;
            aux.prox = null;
            aux = null;
            return elemento;
        }
        public void imprimir()
        {
            for(Sentinela i = topo; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }
    }
}