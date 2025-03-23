using System;

public class Forca
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Forca ---");

        Console.Write("Qual a palavra secreta? ");
        string? palavraSecreta = Console.ReadLine(); 

        Console.Write("Qual a letra? ");
        char letra = Console.ReadKey().KeyChar;
        Console.WriteLine();

       string resultado = (palavraSecreta ?? "").Contains(letra) 
            ? $"A letra \"{letra}\" existe na palavra secreta => True" 
            : $"A letra \"{letra}\" não existe na palavra secreta => False"; 

        Console.WriteLine(resultado);
    }
}



