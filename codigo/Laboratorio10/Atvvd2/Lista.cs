using System;

namespace Lista
{
    class Listas
    {
        private Sentinela primeiro, ultimo;
        public Listas()
        {
            primeiro = new Sentinela();
            ultimo = primeiro;
        }
        public void inserir(int x)
        {
            ultimo.prox = new Sentinela(x); //Nesse momento ele insere a proxima posição na ultima
            ultimo = ultimo.prox; // A ultima posição é inserida no proximo que por sua vez é declarado como nulo
        }
        public void inserirLista(int x, int pos)
        {
            if (pos < 0 )
            {
                Console.WriteLine("Fila vazia.");
            }else if (pos == 0)
            {
                inserir(x);
            }else
            {
                Sentinela i = primeiro;
                for (int j = 0; j < pos; j++, i = i.prox);
                Sentinela aux = new Sentinela(x);
                aux.prox = i.prox;
                i.prox = aux;
                aux = i = null;
            }
        }
        public int remover(int pos)
        {

            if (primeiro == ultimo)
            {
                Console.WriteLine("Fila Vazia");
                return -1;
            }
            Sentinela aux = primeiro; // Guarda a primeira posição;
            primeiro = primeiro.prox; //Primeira posição quebra apontando para o proximo elemento na fila;
            int retirar = primeiro.elemento; // retirar corresponde ao elemento retirado;
            aux.prox = null; // Aponta o elemento retirado para nullo;
            aux = null; // Destroi o elemento removido; */
            return -1;
        }
        public int removerLista(int pos)
        {
            int elemento = 0;

            if (primeiro == ultimo || pos < 0)
            {
                Console.WriteLine("Fila Vazia");
                return -1;
            }
            if(pos == 0){
                elemento = remover();
            }

            Sentinela i = primeiro;
            for (int j = 0; j < pos; j++, i = i.prox);
            Sentinela aux = i.prox;
            elemento = aux.elemento;
            i.prox = aux.prox;
            aux.prox = null;
            i = aux = null;

            return elemento;

        }
        public void imprimir()
        {
            for(Sentinela i = primeiro.prox; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }
    }
}