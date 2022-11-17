using System;

namespace Calculadora_Polonesa
{
    class Capsula
    {
        public string valor;
        public Capsula apontador;

        public Capsula() { }
        public Capsula(string valor)
        {
            this.valor = valor;
            apontador = null;
        }
    }
}