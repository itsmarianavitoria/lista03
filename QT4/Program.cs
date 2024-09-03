using System;

class Program
{
    static void Main()
    {
        //vida inicial do herói
        const int vidaInicial = 100;

        //pergunta ao jogador quantas fases ele deseja jogar
        Console.Write("Quantas fases você deseja jogar? ");
        int numeroFases = int.Parse(Console.ReadLine());

        //inicializa a vida total do herói com o valor inicial
        int vidaTotal = vidaInicial;

        //processa cada fase
        for (int i = 0; i < numeroFases; i++)
        {
            //pergunta o ganho ou perda de pontos de vida para a fase atual
            Console.Write($"Quantos pontos de vida o herói ganhou ou perdeu na fase {i + 1}? ");
            int pontosFase = int.Parse(Console.ReadLine());

            //pergunta se o herói usou um item de cura
            Console.Write("O herói usou um item de cura nesta fase? (Sim/Não) ");
            string usouItemCura = Console.ReadLine().Trim().ToLower();

            //atualiza a vida total com base no ganho ou perda de pontos de vida
            vidaTotal += pontosFase;

            //se o herói usou um item de cura, pergunta a quantidade de pontos de cura
            if (usouItemCura == "sim")
            {
                Console.Write("Quantos pontos de cura foram usados? ");
                int pontosCura = int.Parse(Console.ReadLine());
                vidaTotal += pontosCura;
            }
        }

        //exibe a vida total do herói ao final da jornada
        Console.WriteLine($"Vida Final: {vidaTotal} pontos");
    }
}
