using System;

namespace Laboratorio3{
    class Ordem{

        static int[] ordenaSub(int[]sub){
            int aux = 0;
            if(sub[0] > sub[1]) {
                aux = sub[0];
                sub[0] = sub[1];
                sub[1] = aux;
                return sub;
            }
            return sub;
        }

        static int[] ordernarVetor(int []valor){
            if(valor.Length == 1) return valor;

            int metade1 = valor.Length / 2;
            int metade2 = valor.Length - metade1;
            int []sub1 = new int[metade1];
            int []sub2 = new int[metade2];

            for(int i = 0; i < metade1; i++){
                sub1[i] = valor[i];
            }
            for(int i = metade2, j = 0; i < valor.Length; i++, j++){
                sub2[j] = valor[i];
            }

            sub1 = ordernarVetor(sub1);
            sub2 = ordernarVetor(sub2);
            int []oredenado1  = ordenaSub(sub1);
            int []oredenado2 = ordenaSub(sub2);
            
            
            int []sw = new int[valor.Length];

            for(int i = 0; i <sub1.Length; i++){sw[i] = oredenado1[i];}
            for(int i = 3; i <valor.Length; i++){sw[i] = oredenado2[i];}


            return sw;
        }

        static void Main(string[] args){
            int []valor = new int[] {7,2,9,0,4,3};
            int []teste = new int[6];

            teste = ordernarVetor(valor);  
            
            for(int i = 0; i < valor.Length; i++){
                Console.Write(teste[i]);
            }
        }
    }
}