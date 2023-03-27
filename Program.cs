internal class Program
{
    private static void Main(string[] args)
    {
        string[] listaPalavras = { "boliche", "camelo", "abelha", "cosme", "damiao", "chiclete", "bala", 
            "corinthians", "palmeiras", "cobertor", "almofada", "churrasqueira", "borboleta", "caravela", "trabalho" };

        Random alt = new();

        string palavraAlt = listaPalavras[alt.Next(listaPalavras.Length)];

        List<string> tracejado = new();

        for (int i = 0; i < palavraAlt.Length; i++)
        {
            tracejado.Add("_");
        }

        Console.WriteLine($"---------------- JOGO DA FORCA ----------------\n");

        while (tracejado.Contains("_"))
        {
            Console.Write($"\nAdivinhe a palavra: {string.Join("", tracejado)}\n Insira a letra: ");
            string chute = Console.ReadLine().ToLower();
            if (palavraAlt.Contains(chute[0]) && chute.Length == 1)
            {
                for (int i = 0; i < palavraAlt.Length; i++)
                {
                    if (chute[0] == palavraAlt[i])
                    {
                        tracejado[i] = chute;
                    }
                }
            }
        }

        Console.WriteLine($"\nVocê venceu! A palavra é {palavraAlt}!");
    }
}

/*
 *  - Tentar adicionar lista com letras testadas 
 *  - Limpar console depois da tentativa 
 *  - Fazer recursividade 
 */