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
}
