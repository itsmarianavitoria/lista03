using System;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        //pergunta ao jogador quantos baús deseja abrir
        Console.Write("Quantos baús você deseja abrir? ");
        int totalBaús = int.Parse(Console.ReadLine());

        //pergunta ao jogador quantos tipos diferentes de baús existem no jogo
        Console.Write("Quantos tipos diferentes de baús existem no jogo? ");
        int tiposDeBaús = int.Parse(Console.ReadLine());

        //cria um array para armazenar a quantidade de baús de cada tipo
        int[] baúsPorTipo = new int[tiposDeBaús];
        int totalItensRaros = 0;

        for (int i = 0; i < tiposDeBaús; i++)
        {
            //pergunta ao jogador quantos baús de cada tipo ele deseja abrir
            Console.Write($"Quantos baús do Tipo { (char)('A' + i) } você deseja abrir? ");
            baúsPorTipo[i] = int.Parse(Console.ReadLine());
        }

        //verifica se a soma dos baús por tipo é igual ao total de baús desejados
        int somaBaús = 0;
        foreach (int baús in baúsPorTipo)
        {
            somaBaús += baús;
        }

        if (somaBaús != totalBaús)
        {
            Console.WriteLine("A soma dos baús por tipo não corresponde ao total de baús desejados.");
            return;
        }

        //simula a abertura dos baús e a coleta de itens raros
        for (int i = 0; i < tiposDeBaús; i++)
        {
            int baúsDoTipo = baúsPorTipo[i];
            char tipo = (char)('A' + i);

            for (int j = 0; j < baúsDoTipo; j++)
            {
                int itensRaros = 0;

                switch (tipo)
                {
                    case 'A':
                        itensRaros = rand.Next(0, 4); // 0 a 3 itens
                        break;
                    case 'B':
                        itensRaros = rand.Next(1, 6); // 1 a 5 itens
                        break;
                    case 'C':
                        itensRaros = rand.Next(2, 7); // 2 a 6 itens
                        break;
                    default:
                        Console.WriteLine("Tipo de baú desconhecido.");
                        return;
                }

                totalItensRaros += itensRaros;
            }
        }

        //exibe o total de itens raros obtidos
        Console.WriteLine($"Total de itens raros obtidos: {totalItensRaros}");
    }
}
