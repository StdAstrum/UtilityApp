using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface
{
    public class geApi
    {
        public static void run()
        {
            Console.Write("Enter the number of parts of the API key: ");
            int count = int.TryParse(Console.ReadLine(), out int c) ? c : 4;

            List<int> lengths = new();
            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter part length {i + 1}: ");
                int len = int.TryParse(Console.ReadLine(), out int l) ? l : 6;
                lengths.Add(len);
            }

            Console.Write($"Enter a separator between parts (default is '{Data.defaultSeparator}'): ");
            string? sepInput = Console.ReadLine();
            char separator = string.IsNullOrEmpty(sepInput) ? '-' : sepInput[0];

            Console.Write("Enter a prefix (if not needed, press return)): ");
            string prefix = Console.ReadLine() ?? "";

            char separatorPrefix = '-';
            if (!string.IsNullOrEmpty(prefix))
            {
                Console.Write($"Enter a separator before the prefix (default is '{Data.defaultSeparator}'): ");
                string? sepPref = Console.ReadLine();
                if (!string.IsNullOrEmpty(sepPref)) separatorPrefix = sepPref[0];
            }

            Console.Write("Enter the suffix (if not needed, press return): ");
            string suffix = Console.ReadLine() ?? "";

            char separatorSuffix = '-';
            if (!string.IsNullOrEmpty(suffix))
            {
                Console.Write($"Enter a separator before the suffix (default is '{Data.defaultSeparator}'): ");
                string? sepSuf = Console.ReadLine();
                if (!string.IsNullOrEmpty(sepSuf)) separatorSuffix = sepSuf[0];
            }

            Console.Write("Include capital letters? (y/n): ");
            bool upper = Console.ReadLine()?.Trim().ToLower() == "y";

            Console.Write("Include special characters? (y/n): ");
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

            Console.WriteLine($"\nGenerated API key:\n{result}");
        }
    }
}
