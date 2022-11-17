using System;

namespace Calculadora_Polonesa
{
    class Pilhas
    {
        private Capsula primeiro;
        public Pilhas()
        {
            primeiro = null;
        }
        public void adicionar(string num)
        {
            Capsula aux = new Capsula(num);
            aux.apontador = primeiro;
            primeiro = aux;
            aux = null;
        }
        public string remover()
        {
            if (primeiro == null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Expressão Invalida");
                Console.ResetColor();
                return "";
            }
            string sair = primeiro.valor;
            Capsula aux = primeiro;
            primeiro = primeiro.apontador;
            aux.apontador = null;
            aux = null;
            return sair;
        }
        public void imprimi()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A pilha: ");
            imprimi(primeiro);
            Console.WriteLine();
            Console.ResetColor();
        }
        private void imprimi(Capsula primeiro)
        {
            if (primeiro != null)
            {
                imprimi(primeiro.apontador);
                Console.Write(primeiro.valor);
            }
        }
        public string verTopo()
        {
            if(primeiro == null)
                return "=";
            return primeiro.valor;
        }
        public void resultado()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("O resultado da operação é: ");
            resultado(primeiro);
            Console.WriteLine();
            Console.ResetColor();
        }
        private void resultado(Capsula primeiro)
        {
            if (primeiro != null)
            {
                resultado(primeiro.apontador);
                Console.Write(primeiro.valor);
            }
        }
    }
}