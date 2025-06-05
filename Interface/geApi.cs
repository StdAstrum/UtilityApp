using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface
{
    public class geApi
    {
        public static void run()
        {
            Console.Write("Введите количество частей API ключа: ");
            int count = int.TryParse(Console.ReadLine(), out int c) ? c : 4;

            List<int> lengths = new();
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Введите длину части {i + 1}: ");
                int len = int.TryParse(Console.ReadLine(), out int l) ? l : 6;
                lengths.Add(len);
            }

            Console.Write("Введите разделитель между частями (по умолчанию '-'): ");
            string? sepInput = Console.ReadLine();
            char separator = string.IsNullOrEmpty(sepInput) ? '-' : sepInput[0];

            Console.Write("Введите префикс (если не нужен — нажмите Enter): ");
            string prefix = Console.ReadLine() ?? "";

            char separatorPrefix = '-';
            if (!string.IsNullOrEmpty(prefix))
            {
                Console.Write("Введите разделитель перед префиксом (по умолчанию '-'): ");
                string? sepPref = Console.ReadLine();
                if (!string.IsNullOrEmpty(sepPref)) separatorPrefix = sepPref[0];
            }

            Console.Write("Введите суффикс (если не нужен — нажмите Enter): ");
            string suffix = Console.ReadLine() ?? "";

            char separatorSuffix = '-';
            if (!string.IsNullOrEmpty(suffix))
            {
                Console.Write("Введите разделитель перед суффиксом (по умолчанию '-'): ");
                string? sepSuf = Console.ReadLine();
                if (!string.IsNullOrEmpty(sepSuf)) separatorSuffix = sepSuf[0];
            }

            Console.Write("Включать заглавные буквы? (y/n): ");
            bool upper = Console.ReadLine()?.Trim().ToLower() == "y";

            Console.Write("Включать спецсимволы? (y/n): ");
            bool special = Console.ReadLine()?.Trim().ToLower() == "y";

            var model = new apiModel
            {
                count = count,
                length = lengths,
                separator = separator,
                prefix = prefix,
                separatorPrefix = separatorPrefix,
                suffix = suffix,
                separatorSuffix = separatorSuffix,
                uppercaseCharacters = upper,
                specialCharacters = special
            };

            string result = genApi.generate(model);

            Console.WriteLine($"\nСгенерированный API ключ:\n{result}");
        }
    }
}
