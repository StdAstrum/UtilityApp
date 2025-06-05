using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface
{
    class geName
    {
        public static void run()
        {
            Console.Write("Do you want a humanized name?? (y/n): ");
            string humanizedInput = Console.ReadLine()?.Trim().ToLower();
            bool isHumanized = humanizedInput == "y" || humanizedInput == "да" || humanizedInput == "д" || humanizedInput == "yes";
            
            Console.Write("Enter name length: ");
            int length = int.Parse(Console.ReadLine() ?? "10");

            Console.Write("Enter prefix (press return to skip): ");
            string prefix = Console.ReadLine() ?? "";

            Console.Write("Enter suffix (press return to skip): ");
            string suffix = Console.ReadLine() ?? "";

            bool specialCharacters = false;
            if (!isHumanized)
            {
                Console.Write("Want to add special characters? (y/n): ");
                string specialInput = Console.ReadLine()?.Trim().ToLower();
                specialCharacters = specialInput == "д" || specialInput == "да" || specialInput == "y" || specialInput == "yes";
            }

            nameModel model = new nameModel
            {
                length = length,
                prefix = prefix,
                suffix = suffix,
                separatorPrefix = '_',
                separatorSuffix = '>',
                specialCharacters = specialCharacters,
                isHumanized = isHumanized
            };

            Console.WriteLine($"Generated username: {genName.generate(model)}");
        }
    }
}
