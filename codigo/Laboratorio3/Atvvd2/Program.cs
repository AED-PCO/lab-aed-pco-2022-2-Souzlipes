using System;

namespace Laboratorio3{
    class Ordem{

        static int[] ordernarVetor(int []valor){
            
            
            
            int metade1 = valor.Length / 2;
            int metade2 = valor.Length - metade1;
            int []sub1 = new int[metade1];
            int []sub2 = new int[metade2];

            for(int i = 0; i < 3; i++){
                sub1[i] = valor[i];
            }
            for(int i = 3, j = 0; j < 6; i++, j++){
                sub2[j] = valor[i];
            }

            if(valor.Length == 1) return valor;

            sub1 = ordernarVetor(sub1);
            sub2 = ordernarVetor(sub2);

            
            int []sw = new int[valor.Length];
            for(int i = 0; i < sub1.Length; i++){
                for(int j = 0; j < sub1.Length; j++){
                    if(sub1[i] < sub2[j]){
                        sw[i] = sub1[i];
                       
                    }else{
                        sw[i] = sub2[j];      
                    }   
                }
            }
            for(int i = 0; i < sw.Length; i++){
                Console.Write(sw[i]);
            }
            return sw;
        }

        static void Main(string[] args){
            int []valor = new int[] {7,2,9,0,4,8};
            ordernarVetor(valor);  
            
            for(int i = 0; i < valor.Length; i++){
                Console.Write(valor[i]);
            }
        }
    }
}