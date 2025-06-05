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
            try
            {
                Message.ShowMessage();
                menu.Animate();
                menu.ShowMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}