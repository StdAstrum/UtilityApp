using UtilityApp.Interface;
using UtilityApp.Models;
using UtilityApp.Functional;
using System.Text;

namespace UtilityApp
{
    public class Data
    {
        public static string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
        public static string charsUppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
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
            //Console.WriteLine(genName.generate(new nameModel
            //{
            //    length = 4,
            //    prefix = "user",
            //    separatorPrefix = '_',
            //    suffix = "example",
            //    separatorSuffix = '.',
            //    //specialCharacters = true,
            //    isHumanized = true
            //}));
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
            //Console.WriteLine(genApi.generate(new apiModel
            //{
            //    count = 4,
            //    length = new List<int> { 20, 8, 2, 12 },
            //    specialCharacters = false,
            //    uppercaseCharacters = false
            //}));



            menu.Animate();
            menu.ShowMenu();
        }
    }
}