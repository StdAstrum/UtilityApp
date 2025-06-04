using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface
{
    public class gePassword
    {
        public static void run()
            {
                Console.Write("Enter the length of password: ");
                int length = int.Parse(Console.ReadLine() ?? "10");

                Console.Write("Do you want to add a special characters? (y/n): ");
                string specialInput = Console.ReadLine()?.Trim().ToLower();
                bool specialCharacters = specialInput == "y" || specialInput == "yes";

                passwordModel model = new passwordModel();
                model.length = length;
                model.specialCharacters = specialCharacters;

                Console.WriteLine($"Generated Password: {genPassword.generate(model)}");
            }
    }
}
