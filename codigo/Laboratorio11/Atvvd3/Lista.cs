using System;

namespace Atvvd3
{
    class ListaCircular
    {
        private SentinelaCircular primeiro, ultimo;
        public ListaCircular()
        {
            primeiro = new SentinelaCircular();
            primeiro.prox = primeiro;
            primeiro.ant = primeiro;
            ultimo = primeiro;
        }
        public void inserirInicio(int x)
        {
            SentinelaCircular aux = new SentinelaCircular(x);
            aux.ant = primeiro;
            aux.prox = primeiro.prox;
            primeiro.ant = ultimo;
            ultimo.prox = primeiro;
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
            ultimo.prox = new SentinelaCircular(x);
            ultimo.prox.ant = ultimo; 
            ultimo = ultimo.prox;
            primeiro.ant = ultimo;
            ultimo.prox = primeiro;
        }

        public int removerInicio()
        {
            if(primeiro == ultimo)
            {
                Console.WriteLine("Lista invalida, verifique se a algum valor!"); 
                return -1; 
            }
            SentinelaCircular aux = new SentinelaCircular();
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
                SentinelaCircular i = primeiro;
                int j = 0;
                while(j < pos)
                {
                    j++;
                    i = i.prox;
                }

                SentinelaCircular aux = new SentinelaCircular(x);
                aux.ant = i; //Conecata no valor anterior
                aux.prox = i.prox; // Conecta no valor posterior
                if(aux == ultimo)
                {
                    primeiro.ant = aux;
                    aux.prox = primeiro;
                }else
                {
                    primeiro.ant = ultimo;
                    ultimo.prox = primeiro;
                }

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
                SentinelaCircular i = primeiro;
                int j = 0;
                while(j <= pos)
                {
                    j++;
                    i = i.prox;
                }
                i.ant.prox = i.prox; //Conecta o valor anterior com o posterior
                i.prox.ant = i.ant; //Conecta o valor anterior com o posterior
                elemento = i.elemento; // Caputro o elemento retirado
                primeiro.ant = ultimo;
                ultimo.prox = primeiro;
                i.prox = i.ant = null;
                i = null;
            }
            return elemento;
        }

        public int Tamanho()
        {
            int tamanho = 0;

            for(SentinelaCircular i = primeiro.prox; i != null; i = i.prox){
                tamanho++;
            }
            return tamanho;
        }

        public void imprimir()
        {
            for(SentinelaCircular i = primeiro.prox; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }

    }
}