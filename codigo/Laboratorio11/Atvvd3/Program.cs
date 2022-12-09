using System;

namespace Atvvd3
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCircular listas = new ListaCircular();

            string continuar = "";

            int pos = 0;

            Console.WriteLine("Informe um valor: ");
            int valor = int.Parse(Console.ReadLine());
            
            listas.inserir(valor,pos);

            Console.WriteLine("Informe um valor: ");
            valor = int.Parse(Console.ReadLine());
            
            listas.inserir(valor,pos);

            listas.removerInicio();
            
            listas.imprimir();
        }
    }
}