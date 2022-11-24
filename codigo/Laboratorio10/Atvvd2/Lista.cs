using System;

namespace Atvvd2
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
            ultimo = ultimo.prox; // A ultima posição é inserida no proximo que por sua vez é declarado como nulo na class sentinela
        }
        public void inserirLista(int x, int pos)
        {
            Sentinela aux2 = new Sentinela();
            int tamanho = Tamanho();

            if (pos < 0 )
            {
                Console.WriteLine("Lista vazia.");
            }else if(pos == 0){
                inserir(x);
            }else if(pos > tamanho)
            {
                Console.WriteLine("Posição invalida");
            }
            else{
                Sentinela i = primeiro; // i elemento a frente
                int j = 0;
                while (j < pos)
                {
                    j++;
                    i = i.prox;
                    // precorre o estrutura ate encontrar o element desejado
                } 
                Sentinela aux = new Sentinela(x); // Atribui o valor e aponta para nullo
                aux.prox = i.prox; // Aponta o novo valor para a proxima posição ou aponta para nulo caso seja a ultima
                i.prox = aux; //A ponta o valor anterior a a posição inserida para a posição inserida
                aux = null;
                i = null;
            }
        }
        public int remover(int pos)
        {

            if (primeiro == ultimo)
            {
                Console.WriteLine("Lista Vazia");
                return -1;
            }
            Sentinela aux = primeiro; // Guarda a primeira posição;
            primeiro = primeiro.prox; //Primeira posição quebra apontando para o proximo elemento na fila;
            int resp = primeiro.elemento; // Resp corresponde ao elemento retirado;
            aux.prox = null; // Aponta o elemento retirado para nullo;
            aux = null; // Destroi o elemento removido;
            return resp;
        }
        public int removerLista(int pos)
        {
            int elemento = 0;

            if (primeiro == ultimo || pos < 0)
            {
                Console.WriteLine("Lista Vazia");
                return -1;
            }
            if(pos == 0){
                elemento = remover(pos);
            }

            Sentinela i = primeiro;
            int j = 0;
            while (j < pos)
            {
                j++;
                i = i.prox;
            }
            
            Sentinela aux = i.prox; // Armazeno a posição de i na variavel aux
            elemento = aux.elemento; // capturo o valor contido na posição de aux
            i.prox = aux.prox; // Conecto i com o proximo elemento do auxiliar
            aux.prox = null; //Aponto para nulo o elemento retirado
            i = aux = null; //Destruo o elemento

            return elemento;

        }

        public int Tamanho()
        {
            int tamanho = 0;

            for(Sentinela i = primeiro.prox; i != null; i = i.prox){
                tamanho++;
            }
            return tamanho;
        }
        public void imprimir()
        {
            for(Sentinela i = primeiro.prox; i!= null; i = i.prox)
                Console.Write("{0} ", i.elemento);
        }
    }
}