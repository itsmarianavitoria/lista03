using System;

class Program
{
    static void Main()
    {
        //pergunta ao jogador quantos tipos diferentes de itens ele deseja armazenar
        Console.Write("Quantos tipos diferentes de itens você deseja armazenar no inventário? ");
        int numeroTiposItens = int.Parse(Console.ReadLine());

        // inicializa o total de itens no inventário
        int totalItens = 0;

        //processa cada tipo de item
        for (int i = 0; i < numeroTiposItens; i++)
        {
            //pergunta o nome do item e a quantidade desse tipo
            Console.Write($"Digite o nome do item {i + 1}: ");
            string nomeItem = Console.ReadLine();

            Console.Write($"Quantos {nomeItem}s você possui? ");
            int quantidadeItem = int.Parse(Console.ReadLine());

            //atualiza o total de itens
            totalItens += quantidadeItem;
        }

        //pergunta ao jogador a capacidade máxima do inventário
        Console.Write("Qual é a capacidade máxima do inventário? ");
        int capacidadeMaxima = int.Parse(Console.ReadLine());

        //exibe o total de itens e verifica se está dentro da capacidade máxima
        Console.WriteLine($"Total: {totalItens} itens.");

        if (totalItens > capacidadeMaxima)
        {
            Console.WriteLine("Excede a capacidade.");
        }
        else
        {
            Console.WriteLine("Dentro da capacidade.");
        }
    }
}
