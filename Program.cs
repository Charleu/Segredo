using System;

class Program
{
    static void Main(string[] args)
    {
        string sep = new string('-', 40);
        string palavraSecreta = "banana";
        string descricaoSegredo = "Uma fruta amarela e deliciosa.";

        Console.Clear();

        Console.WriteLine("\nDescrição do Segredo:");
        Console.WriteLine(descricaoSegredo);

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(sep);
            Console.WriteLine("\nTentativa {0}/5. Adivinhe a palavra secreta: ", i + 1);
         
            string tentativa = Console.ReadLine().ToLower();

            if (tentativa == palavraSecreta)
            {
                Console.WriteLine(sep);
                Console.WriteLine("Parabéns! Você descobriu o segredo.");
                Console.WriteLine(sep);
                return; 
            }
            else
            {
                Console.WriteLine(sep);
                Console.WriteLine("\nTentativa incorreta. Tente novamente.");
                Console.WriteLine(sep);
            }
        }
        Console.WriteLine(sep);
        Console.WriteLine("As tentativas acabaram. O jogo acabou.");
        Console.WriteLine(sep);
    }
}
