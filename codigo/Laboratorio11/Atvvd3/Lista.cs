using System;

namespace Atvvd3
{
    class ListaCircular
    {
        private SentinelaCircular primeiro, atual;


        public ListaCircular()
        {
           primeiro = new SentinelaCircular();
           primiero.prox = primeiro;
           primeiro.anterior = primeiro;
           atual = primeiro;
        }

        public void inserirInicio(int x)
        {
            SentinelaCircular elemento = new SentinelaCircular(x);
            primeiro.prox = aux;
            atual = aux;
            aux.prox = aux;
            aux.ant = aux;
        }

        public void inserirFim(int x)
        {
            SentinelaCircular elemento = new SentinelaCircular(x);
            SentinelaCircular aux = primeiro.prox;
            while (aux.proximo != primeiro.proximo)
            {
                aux = aux.prox;

            }
            atual = elemento;
            atual.prox = primeiro.prox;
            elemento.ant = aux;
            elemento.prox = primeiro.prox;
            aux.prox = elemento;
            primeiro.prox.ant = atual;
        }

        public void inserir(int x, int pos){
            int i =0;

            SentinelaCircular elemento = new SentinelaCircular(x);
            SentinelaCircular aux = primeiro.prox;

            while (i < pos && aux != atual)
            {
                i++;
                aux = aux.prox;
            }
            if(aux == atual && cont < pos)
            {
                atual = elemento;
                atual.prox = primeiro.prox;
                elemento.ant = aux;
                elemento.prox = primeiro.prox;
                aux.prox = elemento;
                primeiro.prox.ant = atual;
            }else
            {
                atual.prox = primeiro.prox;
                elemento.prox = aux;
                aux.ant.prox = elemento;
                aux.ant = elemento;
                elemento.ant = aux.ant;
                
                if(primei)
            }
        }
        // public void removerFim()
        // {
        //     if(primeiro == ultimo)
        //     {
        //         Console.WriteLine("Lista invalida, verifique se a algum valor!"); 
        //         return -1; 
        //     }

        //     int elemento = ultimo.elemento;
        //     ultimo = ultimo.ant;
        //     ultimo.prox.ant;
        //     ultimo.prox;
        //     return elemento;
        // }

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