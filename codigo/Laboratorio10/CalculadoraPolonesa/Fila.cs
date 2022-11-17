using System;

namespace Calculadora_Polonesa
{
    class Filas
    {
        private Capsula primeiro, ultimo;
        public Filas()
        {
            primeiro = new Capsula();
            ultimo = primeiro;
        }
        public void adicionar(string num)
        {
            ultimo.apontador = new Capsula(num);
            ultimo = ultimo.apontador;
        }
        public string remover()
        {
            if (primeiro == ultimo)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fila Vazia");
                Console.ResetColor();
                return "";
            }
            Capsula aux = primeiro;
            primeiro = primeiro.apontador;
            string sair = primeiro.valor;
            aux.apontador = null;
            aux = null;
            return sair;
        }
        public void imprimi()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A fila: ");

            for (Capsula i = primeiro.apontador; i != null; i = i.apontador)
                Console.Write(i.valor);

            Console.WriteLine();
            Console.ResetColor();
        }
        public bool vazia()
        {
            if (primeiro == ultimo) return true;
            return false;
        }
    }
}