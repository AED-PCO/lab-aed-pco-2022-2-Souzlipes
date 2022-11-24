using System;

namespace Calculadora_Polonesa
{
    class Program
    {
        static void inParaPos(Filas fila, Pilhas pilha, string[] expressao, ref int erro)
        {
            for (int i = 0; i < expressao.Length; i++) // Enquanto tiver elementos no vetor
            {
                if (expressao[i] == "(")               // Se o elemento atual for "("
                {
                    pilha.adicionar(expressao[i]);     // Adiciona na pilha
                }
                else if (expressao[i] == ")")          // Se o elemento atual for ")", retira operadores até achar "("
                {
                    string c = pilha.remover();        // String "c" recebe o elemento do topo da pilha
                    if (c == "")                       // Se o elemento atual for "" quer dizer que chegou no fim na pilha e não encontrou o "(", então possui um erro
                    {
                        erro++;                        // Variáve erro recebe um acréscimo
                        break;                         // Sai do loop
                    }
                    while (c != "(")                   // Enquanto "c" não for "("
                    {
                        fila.adicionar(c);             // "c" é adicionado na fila
                        c = pilha.remover();           // "c" recebe o valor atualizado do topo da pilha
                        if (c == "")                   // Se o novo valor for "", quer dizer que chegou no fim na pilha e não encontrou o "(", então possui um erro
                        {
                            erro++;                    // Variável erro recebe um acréscimo
                            break;                     // Sai do loop
                        }
                    }
                }
                else if (expressao[i] == "*" || expressao[i] == "/")             // Se o elemento atual for "*" ou "/"
                {
                    if (pilha.verTopo() == "*" || pilha.verTopo() == "/")        // Se o elemento que estiver no topo da pilha possuir a mesma precedência
                    {
                        while (pilha.verTopo() == "*" || pilha.verTopo() == "/") // Enquanto o topo da pilha for "*" ou "/"
                        {
                            fila.adicionar(pilha.remover());                     // Remove da pilha e adiciona na fila
                        }
                        pilha.adicionar(expressao[i]);                           // Adiciona o elemento atual na pilha
                    }
                    else                                                         // Senão
                    {
                        pilha.adicionar(expressao[i]);                           // Adiciona o elemento atual na pilha
                    }
                    
                }
                else if (expressao[i] == "+" || expressao[i] == "-") // Se o elemento atual for "+" ou "-"
                {
                    if (pilha.verTopo() == "*" || pilha.verTopo() == "/" || pilha.verTopo() == "+" || pilha.verTopo() == "-") // Se o elemento que estiver no topo da pilha possuir a mesma precedência ou maior
                    {
                        while (pilha.verTopo() == "*" || pilha.verTopo() == "/" || pilha.verTopo() == "+" || pilha.verTopo() == "-") // Enquanto o topo da pilha possuir a mesma precedência ou maior
                        {
                            fila.adicionar(pilha.remover()); // Remove da pilha e adiciona na fila
                        }
                        pilha.adicionar(expressao[i]); // Adiciona o elemento atual na pilha
                    }
                    else // Senão
                    {
                        pilha.adicionar(expressao[i]); // Adiciona o elemento atual na pilha
                    }
                }
                else                              // Se o elemento atual não for nenhum dos acima (restando apenas os operandos)
                {
                    fila.adicionar(expressao[i]); // Adiciona o elemento atual na fila
                }
            }
            
            while (pilha.verTopo() != "=")       // Por fim, enquanto a pilha não estiver vazia ("=" usado como flag)
            {
                fila.adicionar(pilha.remover()); // Remove o topo da pilha e adiciona na fila
            }
        }
        static void calculo(Filas fila, Pilhas pilha)
        {
            while (!fila.vazia())                                 // Enquanto existir elementos na fila
            {
                string c = fila.remover();                        // Recebe o primeiro elemento da fila
                if (c == "*" || c == "/" || c == "+" || c == "-") // Se for um operador
                {
                    if (c == "*")                                 // Se for "*", realiza a multiplicação dos elementos antecessores
                    {
                        float n1 = float.Parse(pilha.remover());
                        float n2 = float.Parse(pilha.remover());
                        n1 = n1 * n2;
                        pilha.adicionar(n1.ToString());
                    }
                    else if (c == "/")                            // Se for "/", realiza a divisão dos elementos antecessores
                    {
                        float n1 = float.Parse(pilha.remover());
                        float n2 = float.Parse(pilha.remover());
                        n1 = n2 / n1;
                        pilha.adicionar(n1.ToString());
                    }
                    else if (c == "+")                            // Se for "+", realiza a soma dos elementos antecessores
                    {
                        float n1 = float.Parse(pilha.remover());
                        float n2 = float.Parse(pilha.remover());
                        n1 = n1 + n2;
                        pilha.adicionar(n1.ToString());
                    }
                    else                                          // Se for "-", realiza a subtração dos elementos antecessores
                    {
                        float n1 = float.Parse(pilha.remover());
                        float n2 = float.Parse(pilha.remover());
                        n1 = n2 - n1;
                        pilha.adicionar(n1.ToString());
                    }
                } 
                else                                              // Se for um operando
                {
                    pilha.adicionar(c);                           // Adiciona na pilha
                }
            }
            pilha.resultado();                                    // Imprimi o resultado
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Filas fila = new Filas();
            Pilhas pilha = new Pilhas();
            int erro = 0;
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("Calculadora Polonesa");
            Console.ResetColor();
            Console.Write("Digite a expressão: ");
            string formula = Console.ReadLine();
            string[] expressao = formula.Split(" ");     // Transforma a formula em um vetor de string

            inParaPos(fila, pilha, expressao, ref erro); // Função que transforma notação infixa para posfixa
            if (erro == 0)                               // Se tiver erro, não continua
                calculo(fila, pilha);                    // Função que calcula a posfixa
        }
    }
}