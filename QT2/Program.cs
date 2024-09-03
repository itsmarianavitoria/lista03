using System;

class Program
{
    static void Main()
    {
        //pontuações por nível de dificuldade
        const int pontosFacil = 50;
        const int pontosMedio = 100;
        const int pontosDificil = 150;

        //pergunta ao jogador quantas missões ele completou
        Console.Write("Quantas missões você completou? ");
        int numeroMissões = int.Parse(Console.ReadLine());

        //inicializa a pontuação total
        int pontuacaoTotal = 0;

        //Processa cada missão
        for (int i = 0; i < numeroMissões; i++)
        {
            //pergunta ao jogador o nível de dificuldade da missão
            Console.Write($"Qual o nível de dificuldade da missão {i + 1} (Fácil, Médio, Difícil)? ");
            string dificuldade = Console.ReadLine().Trim().ToLower();

            //pergunta ao jogador quantos inimigos ele derrotou
            Console.Write($"Quantos inimigos você derrotou na missão {i + 1}? ");
            int inimigosDerrotados = int.Parse(Console.ReadLine());

            //calcula a pontuação da missão com base no nível de dificuldade
            int pontosPorInimigo = 0;
            switch (dificuldade)
            {
                case "fácil":
                    pontosPorInimigo = pontosFacil;
                    break;
                case "médio":
                    pontosPorInimigo = pontosMedio;
                    break;
                case "difícil":
                    pontosPorInimigo = pontosDificil;
                    break;
                default:
                    Console.WriteLine("Nível de dificuldade inválido. Pontuação para esta missão será 0.");
                    pontosPorInimigo = 0;
                    break;
            }

            //atualiza a pontuação total
            pontuacaoTotal += pontosPorInimigo * inimigosDerrotados;
        }

        //exibe a pontuação total acumulada
        Console.WriteLine($"Pontuação total acumulada: {pontuacaoTotal} pontos");
    }
}
