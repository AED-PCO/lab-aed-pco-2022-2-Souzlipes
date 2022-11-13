using System;

namespace Fila
{
    class Filas
    {
        private Sentinela primeiro, ultimo;
        public Filas()
        {
            primeiro = new Sentinela();
            ultimo = primeiro;
        }
        public void inserir(int x)
        {
            ultimo.prox = new Sentinela(x);
            ultimo = ultimo.prox;
        }
        public int remover()
        {
            if (primeiro == ultimo)
            {
                Console.WriteLine("Fila Vazia");
                return -1;
            }
            Sentinela aux = primeiro;
            primeiro = primeiro.prox;
            int resp = primeiro.elemento;
            aux.prox = null;
            aux = null;
            return resp;
        }
        public void imprimir()
        {
            for(Sentinela i = primeiro.prox; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }
    }
}