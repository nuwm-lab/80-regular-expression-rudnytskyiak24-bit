using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "Сьогодні 07/10/2025, а завтра буде 08-10-2025. Невірна дата 32/13/2022 не повинна враховуватись.";

        // Регулярний вираз для дат у форматі dd/mm/yyyy або dd-mm-yyyy
        string pattern = @"\b(0[1-9]|[12][0-9]|3[01])[/-](0[1-9]|1[0-2])[/-](\d{4})\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        Console.WriteLine("Знайдені дати:");
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
