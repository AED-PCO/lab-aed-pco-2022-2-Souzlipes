using System;

namespace AVL
{
    class ArvoreAVL
    {
        No raiz, valores;
        public ArvoreAVL()
        {
            raiz = null;
        }
        
        public void inserir(int x)
        {
            raiz = inserirValor(x, raiz);
        }

        No novoNo(int x)
        {
            No novo = new No(x);

                novo.elemento = x;
                novo.esquerda = null;
                novo.direita = null;
                novo.altura = 0;


            return novo;
        }

        No inserirValor(int x, No i) // E recebe valor da raiz
        {
                if(i == null)
                {
                    return novoNo(x);
                }
                else
                {
                    if(x < i.elemento)
                    {

                        i.esquerda = inserirValor(x, i.esquerda);
                    }else
                    if(x > i.elemento)
                    {
                        i.direita = inserirValor(x, i.direita);
                    }else
                    {
                        Console.WriteLine("Inserção não realizada");
                    }
                }

                //Calculo da altura
                i.altura = maior(alturaNo(i.esquerda), alturaNo(i.direita)+1);

                //Verifica se nescessita do balanceamento
                i = balancear(i);


                return i;

        }

        // public void inserirSubRaiz(int x)
        // {

        //         if (raiz == null)
        //         {
        //             raiz = new No(x);
        //         }
        //         if(x < raiz.elemento)
        //         {
        //             Console.WriteLine(raiz.elemento+" Line 44");
        //             subRaiz(x, raiz.esquerda, raiz);
        //         }
        //         if(x > raiz.elemento)
        //         {
        //             subRaiz(x, raiz.direita, raiz);
        //         }
        // }

        // public void subRaiz(int x, No i, No pai)
        // {

        //     if(i == null)
        //     {
        //     if(x < pai.elemento) 
        //     {
        //         pai.esquerda = new No(x);
        //     }else
        //     {
        //         pai.direita = new No(x);
        //     }
        //     }
        //     if(x < i.elemento)
        //     {
        //         Console.WriteLine(i.elemento+" Line 66");
        //         subRaiz(x, i.esquerda, i);
        //     }
        //     if(x > i.elemento)
        //     {
        //         Console.WriteLine(i.elemento+" Line 73");
        //         subRaiz(x, i.direita, i);
        //     }

       // }



        //Pesquisa

        public bool pesquisar(int x)
        {
            return pesquisarValor(x, raiz);
        }
        public bool pesquisarValor(int x, No i)
        {
            bool valor = true;
            
            
                if(i == null) 
                {
                    valor = false;
                }else if(x == i.elemento)
                {
                    valor = true;
                }else if(x < i.elemento)
                {
                    valor = pesquisarValor(x, i.esquerda);
                }else
                {
                    valor = pesquisarValor(x, i.direita);  
                }
                return valor;
        }



        //Remover

        public void remover(int x)
        {
            raiz = removerValor(x, raiz);
        }

        No removerValor(int x, No i)
        {
                if(i == null)
                {
                    Console.WriteLine("Arvore vazia");
                }else if (x < i.elemento)
                {
                    i.esquerda = removerValor(x, i.esquerda);
                }else if (x > i.elemento)
                {
                    i.direita = removerValor(x, i.direita);
                }else if(i.direita == null)
                {
                    i = i.esquerda;
                }else if (i.esquerda == null)
                {
                    i = i.direita;
                }else{
                    i. esquerda = maiorEsquerda(i, i.esquerda);
                }
                return i;
        }

        No maiorEsquerda(No i, No j)
        {
            if(j.direita == null)
            {
                i.elemento = j.elemento;
                j = j.esquerda;
            }else
            {
                j.direita = maiorEsquerda(i, j.direita);
            }
            return j;
        }


        //Imprimir em Ordem

        public void EmOrdem()
        {
            exibirOrdem(raiz);
        }
        public void exibirOrdem(No i)
        {
                if(i != null)
                {
                    exibirOrdem(i.esquerda);
                    Console.Write(" {0}",i.elemento);
                    exibirOrdem(i.direita);
                }
        }

        public void preOrdem()
        {
            exibirPreOrdem(raiz);
        }

        public void exibirPreOrdem(No i)
        {
                if(i != null)
                {
                    Console.Write(" {0}",i.elemento);
                    exibirOrdem(i.esquerda);
                    exibirOrdem(i.direita);
                }
        }

        public void posOrdem()
        {
            exibirPosOrdem(raiz);
        }

        public void exibirPosOrdem(No i)
        {
                if(i != null)
                {
                    exibirOrdem(i.esquerda);
                    exibirOrdem(i.direita);
                    Console.Write(" {0}",i.elemento);
                }
           
        }

        //Implemtenração ArvoreAVL

        No balancear(No r)
        {
            int fb = fatorDeBalanceamento(r);

            //Rotaçao esquerda
            if(fb < -1 && fatorDeBalanceamento(raiz.direita) <= 0)
                r = rotacaoEsquerda(r);
            
            //Rotaçao direita
            if(fb < -1 && fatorDeBalanceamento(raiz.esquerda) <= 0)
                r = rotacaoDireita(r);
            
            //Rotaçao dupla a esquerda
            if(fb < -1 && fatorDeBalanceamento(raiz.esquerda) <= 0)
                r = rotacaoEsquerdaDireita(r);
            
            //Rotaçao direita
            if(fb < -1 && fatorDeBalanceamento(raiz.direita) <= 0)
                r = rotacaoDiretaEsquerda(r);
            
            return r;
        }

        int maior(int a, int b)
        {
            return (a > b)? a:b;
        }
        int alturaNo(No i)
        {
            if(i == null)
            {
                return -1;
            }
            else
            {
                return i.altura;
            }
        }
        int fatorDeBalanceamento(No i)
        {
            if(i != null)
            {
                return (alturaNo(i.esquerda) - alturaNo(i.direita));
            }
            else
            {
                return 0;
            }
        }
        
        No rotacaoEsquerda(No r)
        {
            No aux, filho;

            aux = r.direita;
            filho = aux.esquerda;

            aux.esquerda = r;
            r.direita = filho;

            r.altura = maior(alturaNo(r.esquerda), alturaNo(r.direita)+1);
            aux.altura = maior(alturaNo(aux.esquerda), alturaNo(aux.direita)+1);

            return aux;
        }

        No rotacaoDireita(No r)
        {
            No aux, filho;

            aux = r.esquerda;
            filho = aux.direita;

            aux.direita = r;
            r.esquerda = filho;

            r.altura = maior(alturaNo(r.esquerda), alturaNo(r.direita)+1);
            aux.altura = maior(alturaNo(aux.esquerda), alturaNo(aux.direita)+1);

            return aux;
        }

        No rotacaoEsquerdaDireita (No r)
        {
            r.esquerda = rotacaoEsquerda(r.esquerda);
            return rotacaoDireita(r);
        }
        No rotacaoDiretaEsquerda (No r)
        {
            r.direita = rotacaoDireita(r.direita);
            return rotacaoEsquerda(r);
        }

    }
}