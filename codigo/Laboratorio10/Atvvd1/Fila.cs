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
            ultimo.prox = new Sentinela(x); //Nesse momento ele insere a proxima posição na ultima
            ultimo = ultimo.prox; // A ultima posição é inserida no proximo que por sua vez é declarado como nulo
        }
        public int remover()
        {
            if (primeiro == ultimo)
            {
                Console.WriteLine("Fila Vazia");
                return -1;
            }
            Sentinela aux = primeiro; // Guarda a primeira posição;
            primeiro = primeiro.prox; //Primeira posição quebra apontando para o proximo elemento na fila;
            int resp = primeiro.elemento; // Resp corresponde ao elemento retirado;
            aux.prox = null; // Aponta o elemento retirado para nullo;
            aux = null; // Destroi o elemento removido;
            return resp;
        }
        public void imprimir()
        {
            for(Sentinela i = primeiro.prox; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }
    }
}