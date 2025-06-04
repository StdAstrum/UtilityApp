using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
    class geText 
    {
        public static void run()
        {
            Console.Write("Enter the text type (paragraphs/sentences/words): ");
            string type = Console.ReadLine()?.Trim().ToLower() ?? "";

            Console.Write("Enter the length (count of choosed element): ");
            bool parsed = int.TryParse(Console.ReadLine(), out int length);
            if (!parsed || length <= 0)
            {
                Console.WriteLine("Error: Value should be a num.");
                return;
            }

            var model = new textModel
            {
                type = type,
                length = length
            };

            try
            {
                string result = genText.generate(model);
                Console.WriteLine("\nGenerated text:");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}