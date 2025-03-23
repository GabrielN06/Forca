string palavraSecreta;
char letra;
bool existeNaPalavra;

Console.WriteLine("--- Forca ---\n");

Console.Write("Qual a palavra secreta? ");
palavraSecreta = Console.ReadLine()!.Trim().ToLower();

Console.Write("Qual a letra? ");
letra = char.ToLower(Console.ReadKey().KeyChar);

Console.WriteLine("\n");

existeNaPalavra = palavraSecreta.Contains(letra);

Console.WriteLine($"A letra \"{letra}\" existe na palavra secreta => {existeNaPalavra}");