using System;

namespace Atvvd1
{
    class ListaDupla
    {
        private SentinelaDuplo primeiro, ultimo;
        public ListaDupla()
        {
            primeiro = new SentinelaDuplo();
            ultimo = primeiro;
        }
        public void inserirInicio(int x)
        {
            SentinelaDuplo aux = new SentinelaDuplo(x);
            aux.ant = primeiro;
            aux.prox = primeiro.prox;
            primeiro.prox = aux;
            if(primeiro == ultimo)
            {
                ultimo = aux;
            }else
            {
                aux.prox.ant = aux;
            }
            aux = null;
        }

        public void inserirFim(int x)
        {
            ultimo.prox = new SentinelaDuplo(x); // Declara o valor para inserir
            ultimo.prox.ant = ultimo; // Aponta os apontadores para ultima valor inserido
            ultimo = ultimo.prox;
        }

        public int removerInicio()
        {
            if(primeiro == ultimo)
            {
                Console.WriteLine("Lista invalida, verifique se a algum valor!"); 
                return -1; 
            }
            SentinelaDuplo aux = new SentinelaDuplo();
            primeiro = primeiro.prox; 
            int elemento = primeiro.elemento;
            aux.prox = primeiro.ant = null;
            aux = null;
            return elemento;
        }

        public int removerFim()
        {
            if(primeiro == ultimo)
            {
                Console.WriteLine("Lista invalida, verifique se a algum valor!"); 
                return -1; 
            }

            int elemento = ultimo.elemento;
            ultimo = ultimo.ant;
            ultimo.prox.ant = null;
            ultimo.prox = null;
            return elemento;
        }

        public void inserir(int x, int pos)
        {
            int tamanho = Tamanho();

            if(pos < 0 || pos > tamanho)
            {
                Console.WriteLine("Posição invalida!");
            }else if (pos == 0)
            {
                inserirInicio(x);
            }else if (pos == tamanho)
            {
                inserirFim(x);
            }else
            {
                SentinelaDuplo i = primeiro;
                int j = 0;
                while(j < pos)
                {
                    j++;
                    i = i.prox;
                }

                SentinelaDuplo aux = new SentinelaDuplo(x);
                aux.ant = i; //Conecata no valor anterior
                aux.prox = i.prox; // Conecta no valor posterior
                aux.ant.prox = aux.prox.ant = aux; //Conecta duplamente
                aux = i = null;
            }
        }

        public int remover(int pos)
        {
            int tamanho = Tamanho();
            int elemento = 0;

            if(pos < 0 || pos > tamanho)
            {
                Console.WriteLine("Posição invalida!");
            }else if (pos == 0)
            {
                removerInicio();
            }else if (pos == tamanho -1)
            {
                removerFim();
            }else
            {
                SentinelaDuplo i = primeiro;
                int j = 0;
                while(j <= pos)
                {
                    j++;
                    i = i.prox;
                }
                i.ant.prox = i.prox; //Conecta o valor anterior com o posterior
                i.prox.ant = i.ant; //Conecta o valor anterior com o posterior
                elemento = i.elemento; // Caputro o elemento retirado
                i.prox = i.ant = null;
                i = null;
            }
            return elemento;
        }

        public int Tamanho()
        {
            int tamanho = 0;

            for(SentinelaDuplo i = primeiro.prox; i != null; i = i.prox){
                tamanho++;
            }
            return tamanho;
        }

        public void imprimir()
        {
            for(SentinelaDuplo i = primeiro.prox; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }

    }
}