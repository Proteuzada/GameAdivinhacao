using System;

class JogoAdivinhacao
{
    static void Main()
    {
        bool jogarNovamente = true;

        while (jogarNovamente)
        {
            Jogar();

            Console.Write("Você quer jogar novamente? (s/n): ");
            string resposta = Console.ReadLine();
            if (resposta.ToLower() != "s")
            {
                jogarNovamente = false;
            }
        }

        Console.WriteLine("Obrigado por jogar! Pressione Enter para sair.");
        Console.ReadLine();
    }

    static void Jogar()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int tentativas = 0;
        bool acertou = false;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

        while (!acertou)
        {
            try
            {
                Console.Write("Digite seu palpite: ");
                int palpite = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (palpite < numeroAleatorio)
                {
                    Console.WriteLine("Muito baixo! Tente novamente.");
                }
                if (palpite > numeroAleatorio)
                {
                    Console.WriteLine("Muito alto! Tente novamente.");
                }
                if (palpite == numeroAleatorio)
                {
                    Console.WriteLine("\n**************************************");
                    Console.WriteLine("PARABÉNS!!!");
                    Console.WriteLine($"Você acertou o número {numeroAleatorio}!");
                    Console.WriteLine($"Número de tentativas: {tentativas}");
                    Console.WriteLine("Você demonstrou grandes habilidades de adivinhação!");
                    Console.WriteLine("Obrigado por jogar o nosso jogo de adivinhação.");
                    Console.WriteLine("**************************************\n");
                    acertou = true;
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Entrada inválida! Por favor, insira um número válido.");
            }
        }
    }
}
