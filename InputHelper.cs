public static class InputHelper
{
    public static string GetValidString(string question)
    {
        string input;

        do
        {
            Console.WriteLine(question);
            input = Console.ReadLine()?.Trim() ?? "";

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Ungültige Eingabe, bitte versuche es erneut!");
            }
        } while (string.IsNullOrEmpty(input));

        return input;
    }

    public static bool AskYesNo(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt + " (j/n)");
            string input = (Console.ReadLine() ?? "").Trim().ToLower();

            if (input == "j")
                return true;
            else if (input == "n")
                return false;
            else
                Console.WriteLine("Ungültige Eingabe. Bitte 'j' für Ja oder 'n' für Nein eingeben.");
        }
    }
    public static int GetInt(string question, int choices)
    {
        string readResult;
        int result = 0;
        do
        {
            Console.WriteLine(question);
            readResult = Console.ReadLine() ?? "";
        } while (!int.TryParse(readResult, out result) || !(result >= 1 && result <= choices));

        return result;
    }

      public static int GetCoins(string question, int choices)
    {
        string readResult;
        int result = 0;
        do
        {
            Console.WriteLine(question);
            readResult = Console.ReadLine() ?? "";
        } while (!int.TryParse(readResult, out result) || !(result >= 0 && result <= choices));

        return result;
    }
}
