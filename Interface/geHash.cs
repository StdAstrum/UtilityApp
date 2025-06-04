using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
    class geHash
    {
        public static void run()
        {
            Console.Write("Enter the data for hashing: ");
            string data = Console.ReadLine() ?? "";

            Console.Write("Enter salt (Press return to skip): ");
            string salt = Console.ReadLine() ?? "";

            Console.Write($"Chooze algorithm (SHA256 / SHA1 / MD5. Default is {Data.defaultDomain}): ");
            string algorithm = Console.ReadLine() ?? "";

            hashModel model = new hashModel
            {
                data = data,
                salt = salt,
                algorithm = algorithm
            };

            try
            {
                List<string> result = genHash.generate(model);
                Console.WriteLine("\nHash result:");
                Console.WriteLine($"Data: {result[0]}");
                if (!string.IsNullOrEmpty(salt)) Console.WriteLine($"Salt: {result[1]}");
                Console.WriteLine($"Algorithm: {result[^2]}");
                Console.WriteLine($"Hash: {result[^1]}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}