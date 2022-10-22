# Documentação da aula de laboratório

Para cada aula de laboratório, salvar print da execução de cada atividade com o resultado da execução do programa.


Atividade I

```c#
    public int alg1(int n){
        int res = 1; //atribuição
        for(int i=n; i>1; i--){ //laço
            res = res*i; //atribuição
        }
        return res; //return
    }
```

Resultado:
    1 - A operação mais relevante é N
    2- Marcações
    3- Atribuição = N
       Multiplicação = N-1
       return = 1
    4- Não a variações


Atividade II

```c#
    public int alg2(int[] arr, int x){
        for(int i=0; i<arr.length; i++){ // laço
            if(arr[i] == x) return x; // COmparação
        }
        return -1; //return
    }	
```

Resultado:
    1 - A operação mais relevante é comparação N
    2- Marcações
    3- Pior caso: Se o "x" não existir ou estiver na ultima posição, passando por todo o vetor:
       Medio caso: Se o "x" existir e estiver na primeira ou ultima casa;
       Melhor caso: "x" na primeira casa.
    4- Sim, se o "x" existir retorna o valor senão retornar -1.


Atividade III

```c#
    double[] alg3(double []arr1){  
        double[] res;
        for(int pos = 0; pos<arr1.length; pos++){ // laço
            for(int j = 0; j<arr1.length; j++){ //laço
                    if(j!=pos) // Comparação
                res[pos] += arr1[pos]/arr1[j]; //atribuição
            }
        }
        return res; // return
    }

```

Resultado:
    1 - A operação mais relevante é comparação N² - N;
    2- Marcações;
    3- Pior caso: Seria quando a operação fosse falsa, pois ele compararia, porem não executaria sendo a complixidade N²;
       Melhor caso: Comparação sendo verdadeira, a complexidade seria N² - N;
    4- Não a variações.



Atividade IV

```c#
    public double[] alg4(int[] dados){        
        double[] vet = new double[dados.length]; // atribuição
        for(int i=0; i<dados.length; i++){//laço
            double soma=0.0; // atribuição
            for(int j=0; j<=i; j++) //laço
                soma += dados[j]; // atribuição e soma
            vet[i] = soma/(i+1); // atribuição
        }
        return vet; // return
    }

```
Resultado:
    1 - A operação mais relevante é N²;
    2- Marcações;
    3- Em todos os casos a operação executaria N²;
    4- Não a variações.




