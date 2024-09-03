using System;

class Program
{
    static void Main()
    {
        //pergunta ao jogador por quantos dias consecutivos ele logou no jogo
        Console.Write("Quantos dias consecutivos você logou no jogo? ");
        int diasConsecutivos = int.Parse(Console.ReadLine());

        //pergunta qual é a recompensa inicial no primeiro dia
        Console.Write("Qual é a recompensa inicial em moedas no primeiro dia? ");
        int recompensaInicial = int.Parse(Console.ReadLine());

        //pergunta qual é o incremento da recompensa a cada dia consecutivo
        Console.Write("Qual é o incremento da recompensa a cada dia consecutivo? ");
        int incrementoDiario = int.Parse(Console.ReadLine());

        //pergunta se o jogador deseja considerar bônus por marcos de dias
        Console.Write("Você deseja considerar bônus por marcos de dias? (Sim/Não) ");
        string considerarBonus = Console.ReadLine().Trim().ToLower();

        //inicializa a soma das recompensas e o total de bônus
        int totalRecompensas = 0;
        int totalBonus = 0;

        //processa cada dia
        for (int i = 0; i < diasConsecutivos; i++)
        {
            //calcula a recompensa do dia atual
            int recompensaDoDia = recompensaInicial + i * incrementoDiario;
            totalRecompensas += recompensaDoDia;

            //verifica se há bônus a cada marco de dias
            if (considerarBonus == "sim")
            {
                //pergunta a cada quantos dias há um bônus e qual o valor do bônus
                Console.Write("A cada quantos dias consecutivos há um bônus? ");
                int marcoDias = int.Parse(Console.ReadLine());

                Console.Write("Qual é o valor do bônus? ");
                int valorBonus = int.Parse(Console.ReadLine());

                //adiciona o bônus se o dia atual for um marco
                if ((i + 1) % marcoDias == 0)
                {
                    totalBonus += valorBonus;
                }
            }
        }

        //exibe o total de moedas acumuladas
        int totalMoedas = totalRecompensas + totalBonus;
        Console.WriteLine($"Total de moedas acumuladas: {totalMoedas} moedas");
    }
}
