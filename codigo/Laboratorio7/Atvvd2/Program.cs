using System;

namespace Laboratorio7{
    class Atvvd2{
        public static void Main(string[] args){
            int valor = 6;
            FuncRec1(valor);
            Console.WriteLine(valor);
        }

        static int FuncRec1(int a){
            if(a <= 1)
                return 0;
            else
                return FuncRec1((a-2)+5);
        }
    }
}