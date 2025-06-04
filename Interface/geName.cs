using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
class geName
{
    public static void run()
    {
        Console.Write("Enter the length of name: ");
        int length = int.Parse(Console.ReadLine() ?? "10");

        Console.Write("Enter prefix (Press return to skip): ");
        string prefix = Console.ReadLine() ?? "";

        Console.Write("Enter suffix (Press return to skip): ");
        string suffix = Console.ReadLine() ?? "";

        Console.Write("Do you want to add a special characters? (y/n): ");
        string specialInput = Console.ReadLine()?.Trim().ToLower();
        bool specialCharacters = specialInput == "y" || specialInput == "yes";

        nameModel model = new nameModel();
        model.length = length;
        model.prefix = prefix;
        model.suffix = suffix;
        model.separatorPrefix = '_';
        model.separatorSuffix = '>';
        model.specialCharacters = specialCharacters;

        Console.WriteLine($"Generated User Name: {genName.generate(model)}");
    }
}
}
