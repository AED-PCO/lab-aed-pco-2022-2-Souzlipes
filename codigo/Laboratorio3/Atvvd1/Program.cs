using System;

namespace Laboratorio3{
    class Ordem{

        static int[] swap(int[]valor){
            if(valor[0] > valor[1]){
                valor[1] = valor[0];
                return valor;
            }else{
                valor[0] = valor[1];
                return valor;
            }
        }

        static int[] ordernarVetor(int []valor){
            
            if(valor.Length == 1){
                return valor;
            }
            if(valor.Length == 2){
                if(valor[0] > valor[1]){
                    swap(valor);
                    return valor;
                }
                return valor;
            }

            if(valor.Length % 2 ==0){
                int []sub1 = new int[valor.Length / 2];
                int []sub2 = new int[valor.Length / 2];

                sub1 = ordernarVetor(sub1);
                sub2 = ordernarVetor(sub2);

                Console.WriteLine("teste");

                for(int i = 0; i < valor.Length; i++)
                    sub1[i] = valor[i];

                for(int i = 0; i < valor.Length; i++)
                    sub2[i] = valor[i];    

                int contador1 = 0, contador2 = 0, aux1 = 0, aux2 = 0;
                
                for(int i = 0; i < valor.Length; i++){
                    if(sub1[contador1] < sub2[contador1] && aux1 == 0){
                        valor[i] = sub1[contador1];
                        if(contador1 < sub1.Length -1)
                            contador1++;
                        aux1++;
                    }
                    else if(sub1[contador2] > sub2[contador2] && aux2 == 0){
                        valor[i] = sub2[contador2];
                        if(contador2 > sub2.Length -1)
                            contador2++;
                        aux1++;
                    }
                    else if (aux1 != 0){
                        valor[i] = sub2[contador2];
                        contador2++;
                    }else{
                        valor[i] = sub1[contador1];
                        contador1++;
                    }
                }
                

            }else{
                int []sub1 = new int[valor.Length / 2];
                int []sub2 = new int[(valor.Length / 2)+1];

                for(int i = 0; i < valor.Length; i++)
                    sub1[i] = valor[i];

                for(int i = 0; i < valor.Length; i++)
                    sub2[i] = valor[i + valor.Length / 2];
                
                int contador1 = 0, contador2 = 0, aux1 = 0, aux2 = 0;
                
                for(int i = 0; i < valor.Length; i++){
                    if(sub1[contador1] < sub2[contador1] && aux1 == 0){
                        valor[i] = sub1[contador1];
                        if(contador1 < sub1.Length -1)
                            contador1++;
                        aux1++;
                    }
                    else if(sub1[contador2] > sub2[contador2] && aux2 == 0){
                        valor[i] = sub2[contador2];
                        if(contador2 > sub2.Length -1)
                            contador2++;
                        aux1++;
                    }
                    else if (aux1 != 0){
                        valor[i] = sub2[contador2];
                        contador2++;
                    }else{
                        valor[i] = sub1[contador1];
                        contador1++;
                    }
                }
                return valor;
            }
            return valor;

        }

        static void Main(string[] args){
            int []valor = new int[] {7, 5, 1, 3, 4, 6};
            ordernarVetor(valor);  
            
            for(int i = 0; i < valor.Length; i++){
                Console.Write(valor[i]);
            }
        }
    }
}