class ConsolePrint
{
    public static void printError(string rawText, params string[] args) {
        string[] textParts = rawText.Split("%s");
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write("Error: ");
        for (int i = 0; i < textParts.Length; i++)
        {
            if (i < args.Length) { 
                Console.Write(textParts[i] + args[i]); 
            }
            else
            {
                Console.Write(textParts[i]);
            }
            
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }

    public static void printSuccess(string rawText, params string[] args)
    {
        string[] textParts = rawText.Split("%s");
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Black;
        for (int i = 0; i < textParts.Length; i++)
        {
            if (i < args.Length)
            {
                Console.Write(textParts[i] + args[i]);
            }
            else
            {
                Console.Write(textParts[i]);
            }

        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }

    public static void printCaution(string rawText, params string[] args)
    {
        string[] textParts = rawText.Split("%s");
        Console.BackgroundColor = ConsoleColor.Yellow;
        Console.ForegroundColor = ConsoleColor.Black;
        for (int i = 0; i < textParts.Length; i++)
        {
            if (i < args.Length)
            {
                Console.Write(textParts[i] + args[i]);
            }
            else
            {
                Console.Write(textParts[i]);
            }

        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }

}