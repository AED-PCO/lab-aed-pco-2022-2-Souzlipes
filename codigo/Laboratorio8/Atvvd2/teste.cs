static int[] InserirLista(int flag, int[] Vetor, int pos, int valor)
        {
            if (flag < 0)
            {
                Vetor = InserirFila(Vetor, pos, valor);
                return Vetor;
            }
            if (flag > pos)
                flag = pos;
            for(int i = pos; i > flag; i--)
                
            {
                Vetor[i] = Vetor[i - 1];
            }
            Vetor[flag] = valor;
            return Vetor;
        }

    static int[] InserirFila(int[] Vetor, int pos, int valor)
    {
        Vetor[pos] = valor;
        return Vetor;
    }

    static int[] TirarFila(int[] Vetor)
    {
        int aux = Vetor[0];
        for (int i = 1; i < Vetor.Length; i++)
        {
            Vetor[i - 1] = Vetor[i];
        }
        Console.WriteLine("Removendo da Lista o elemento: " + aux);

        return Vetor;

    }
    static int TirarPilha(int aux, int[] Vetor)
    {
            aux -= 1;
            Console.WriteLine("Removendo da pilha o elemento: " + Vetor[aux]);
            
            return aux;
    }
    static void Main(string[] args)
    {
        int Pos = 0, valor = 0, tam = 10;
        int[] Vetor = new int[tam];

        for (int j = 0; j < tam/2; j++)
        {
            valor = j * j;
            if (Pos < tam)
            {
                Console.WriteLine("Inserindo valor: " + valor);
                InserirFila(Vetor, Pos, valor);
                Pos += 1;
            }
            else
                Console.WriteLine("vetor não tem espaço livre! \n Retire elementos antes de tentar inserir");
        }

        valor = tam * tam;
        if (Pos < tam)
        {
            InserirFila(Vetor, Pos, valor);
            Pos += 1;
        }
        else
            Console.WriteLine("vetor não tem espaço livre! \n Retire elementos antes de tentar inserir");

            /*
            TirarFila(Vetor);
            Pos -= 1;

            Console.WriteLine("A posição de referência é: " + Pos);

            if (Pos > 0)
            {
                Console.WriteLine("Os valores na Fila são: ");
                int aux_retira = Pos;
                for (int k = 0; k < aux_retira; k++)
                {
                    TirarFila(Vetor);
                    Pos -= 1;
                }
            }
            else
                Console.WriteLine("A fila esta vazia");
            */

            Pos = TirarPilha(Pos, Vetor);
            TirarFila(Vetor);
            Pos -= 1;

            InserirLista(-1, Vetor, Pos, valor + 2);
            Pos += 1;
            InserirLista(3, Vetor, Pos, valor);
            Pos += 1;
            InserirLista(9, Vetor, Pos, valor * valor);
            Pos += 1;


            for (int i = 0; i < Pos; i++)
                Console.WriteLine("Os itens da lista são: " + Vetor[i] + "com indice i = " + i);
            Console.WriteLine("Cheguei no fim com pop igual: " + Pos);
        }