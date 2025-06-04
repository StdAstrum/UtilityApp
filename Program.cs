using UtilityApp.Interface;
using UtilityApp.Models;
using UtilityApp.Functional;

namespace UtilityApp
{
    public class Data
    {
        public static string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        public static string specialChars = "!@#$%^&*()_+[]{}|;:,.<>?";

        // Default values for generation
        public static string defaultRegion = "UA";
        public static string defaultKeyType = "ED25519";
        public static string defaultHashAlgorithm = "SHA256";
        public static string defaultTextType = "paragraphs";
        public static string defaultDomain = "ast-rum.tech";
        public static char defaultSeparator = '-';
        public static bool defaultSpecialCharacters = false;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(genEmail.generate(new emailModel
            // {
            //     length = 10,
            //     domain = "example.com"
            // }));
            // Console.WriteLine(genName.generate(new nameModel
            // {
            //     length = 10,
            //     prefix = "user",
            //     separatorPrefix = '_',
            //     suffix = "example",
            //     separatorSuffix = '.',
            //     specialCharacters = true
            // }));
            // Console.WriteLine(genPhone.generate(new phoneModel
            // {
            //     region = "BG"
            // }));
            // var a = genKey.generate(new keyModel
            // {
            //     keyType = "ED25519",
            //     keyPassphrase = "12345678"
            // });
            // foreach (var item in a)
            //     Console.WriteLine(item);



            menu.Animate();
            menu.ShowMenu();
        }
    }
}