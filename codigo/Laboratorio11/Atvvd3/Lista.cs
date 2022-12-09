using System;

namespace Atvvd3
{
    class ListaCircular
    {
        private SentinelaCircular primeiro, atual;


        public ListaCircular()
        {
           primeiro = new SentinelaCircular();
           primeiro.prox = primeiro;
           primeiro.ant = primeiro;
           atual = primeiro;
        }

        public void inserirInicio(int x)
        {
            SentinelaCircular elemento = new SentinelaCircular(x);
            primeiro.prox = elemento;
            atual = elemento;
            elemento.prox = elemento;
            elemento.ant = elemento;
        }

        public void inserirFim(int x)
        {
            SentinelaCircular elemento = new SentinelaCircular(x);
            SentinelaCircular aux = primeiro.prox;
            while (aux.prox != primeiro.prox)
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

            int tamanho = Tamanho();

            if(pos < 0 || pos >  tamanho)
            {
                Console.WriteLine("Posição invalida!");
            }else if(pos == 0)
            {
                inserirInicio(x);
            }else if(pos == tamanho)
            {
                inserirFim(x);
            }else{
                SentinelaCircular elemento = new SentinelaCircular(x);
                SentinelaCircular i = primeiro.prox;
                    int j = 0;
                    while(j < pos)
                    {
                        j++;
                        i = i.prox;
                    }

                    atual.prox = primeiro.prox;
                    elemento.prox = i;
                    i.ant.prox = elemento;
                    i.ant = elemento;
                    elemento.ant = i.ant;
                        
                     if(primeiro.prox == i.ant)
                    {
                        primeiro.prox = elemento;
                        primeiro.prox.ant = atual;
                    }
                    
                }
        }
        

        public int removerInicio()
        {
            if(primeiro == atual)
            {
                Console.WriteLine("Lista invalida, verifique se a algum valor!"); 
                return -1; 
            }
            SentinelaCircular elemento = new SentinelaCircular();
            primeiro = primeiro. prox;
            int auxRet = primeiro.elemento;
            elemento.prox = primeiro.ant = null;
            elemento = null;
            return auxRet;
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