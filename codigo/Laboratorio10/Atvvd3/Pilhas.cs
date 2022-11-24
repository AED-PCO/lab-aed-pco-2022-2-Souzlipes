using System;

namespace Atvvd3
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
            Sentinela aux = new Sentinela(x); //isere o proximo elemento
            aux.prox = topo; //Aponto para o ultimo elemento atribuido
            topo = aux; // Declaro o novoe elemento como topo
            aux = null; // Aponto aux par anulo pronto para recceber o proximo elemento
        }
        public int remover()
        {
            if(topo == null)
            {
                Console.WriteLine("Lista vazia!");
                return -1;
            }
            int elemento = topo.elemento; //Identifico o elemento topo
            Sentinela aux = topo; //Declaro aux como topo
            topo = topo.prox; // Declaro o proximo elemento como topo
            aux.prox = null; //Aponto o elemento a ser retirado para nulo
            aux = null; //Destuo o elemento
            return elemento;
        }
        public void imprimir()
        {
            for(Sentinela i = topo; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }
    }
}