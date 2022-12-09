using System;

namespace ABB
{
    class ArvoreBinaria 
    {
        No raiz;
        ArvoreBinaria()
        {
            raiz = null;
        }
        
        public void inserir(int x)
        {
            raiz = inserir(x, raiz);
        }
        No inserir(int x, No i) // E recebe valor da raiz
        {
            try
            {
                if(i == null)
                {
                    i = new No(x);
                }
                if(x < i.elemento)
                {
                    i.esquerda = inserir(x, i.esquerda);
                }
                if(x > i.elemento)
                {
                    i.direita = inserir(x, i.direita);
                }
                return i;
            }catch(Exception e){
                Console.WriteLine("No Inserir"+e);
            }
        }

        public void inserirSubRaiz(int x)
        {
            try
            {
                if (raiz == null)
                {
                    raiz = new No(x);
                }
                if(x < raiz.elemento)
                {
                    subRaiz(x, raiz.esquerda, raiz);
                }
                if(x > raiz.elemento)
                {
                    subRaiz(x, raiz.direita, raiz);
                }
            }catch(Exception e){
                Console.WriteLine("inserirSubRaiz"+e);
            }
        }

        public void subRaiz(int x, No i, No pai)
        {
            try
            {
                if(i == null)
            {
                if(x < pai.elemento) 
                {
                    pai.esquerda = new No(x);
                }else
                {
                    pai.direita = new No(x);
                }
            }
            if(x < i.elemento)
            {
                subRaiz(x, i.esquerda, i);
            }
            if(x > i.elemento)
            {
                subRaiz(x, i.direita, i);
            }
            }catch(Exception e){
                Console.WriteLine("Function subRaiz"+e);
            }
        }



        //Pesquisa

        public bool pesquisar(int x)
        {
            return pesquisarValor(x, raiz);
        }
        public bool pesquisarValor(int x, No i)
        {
            bool valor = true;
            
            try
            {
                if(i == nul) 
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
            }catch(Exception e){
                Console.WriteLine("Function pesquisarValor"+e);
            }
        }



        //Remover

        public void remover(int x)
        {
            raiz = removerValor(x, raiz);
        }

        No removerValor(int x, No i)
        {
            try
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
                    i = direita;
                }else{
                    i. esquerda = mariorEquerda(i, i.esquerda);
                }
            }catch(Exception e){
                Console.WriteLine("No Remover"+e);
            }
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
        public void exibirOrdem(No i)
        {
            i = i.elemento;

            try
            {
                if(i != null)
                {
                    exibirOrdem(i.equerda);
                    Console.Write("{0}",i.elemento);
                    exibirOrdem(i.direita);
                }
            }catch (Exception e)
            {
                Console.WriteLine("Error EM ORDEM"+e);
            }
        }

        public void preOrdem(No i)
        {
            i = i.elemento;

            try
            {
                if(i != null)
                {
                    Console.Write("{0}",i.elemento);
                    exibirOrdem(i.equerda);
                    exibirOrdem(i.direita);
                }
            }catch (Exception e)
            {
                Console.WriteLine("Error PRE ORDEM"+e);
            }
        }

        public void posOrdem(No i)
        {
            i = i.elemento;

            try
            {
                if(i != null)
                {
                    exibirOrdem(i.equerda);
                    exibirOrdem(i.direita);
                    Console.Write("{0}",i.elemento);
                }
            }catch (Exception e)
            {
                Console.WriteLine("Error POS ORDEM"+e);
            }
        }

    }
}