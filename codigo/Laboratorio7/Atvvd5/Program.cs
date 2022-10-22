using System;
using System.IO;

namespace Laboratorio7{
    class Atvvd5{
        public static void Main(string[] args){
            int a = 6;
            int []v = new int[]{10, 5, 7, 15, 22, 9, 30};
            int result = Funcao(a,v);
            Console.Write(result);
        }

        static int Funcao(int a,int []v){
            if (a == 0) 
                return v[0];
            else{
                int x;               
                x = Funcao(a-1,v);
                if(x > v[a-1]){

                    return x;
                }else{

                    return v[a-1];
                }
            }

           
        }
    }
}