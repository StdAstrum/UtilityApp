using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
    class geKey 
    {
        public static void run()
        {
            Console.Write("Enter the type of key (RSA / ECDSA / ED25519): ");
            string keyType = Console.ReadLine()?.Trim().ToUpper();

            if (keyType != "RSA" && keyType != "ECDSA" && keyType != "ED25519")
            {
                Console.WriteLine("Unsupported key type.");
                return;
            }

            Console.Write("Enter passphrase (Press return to skip): ");
            string passphrase = Console.ReadLine();

            keyModel model = new keyModel
            {
                keyType = keyType,
                keyPassphrase = passphrase
            };

            try
            {
                List<string> keys = genKey.generate(model);

                Console.WriteLine($"\nPassphrase: {keys[0]}\n");
                Console.WriteLine($"Public key:\n{keys[1]}\n");
                Console.WriteLine($"Private key:\n{keys[2]}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}