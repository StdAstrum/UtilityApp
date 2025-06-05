using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface
{
    class geName
    {
        public static void run()
        {
            Console.Write("Хотите гуманизированное имя? (д/н): ");
            string humanizedInput = Console.ReadLine()?.Trim().ToLower();
            bool isHumanized = humanizedInput == "y" || humanizedInput == "да" || humanizedInput == "д" || humanizedInput == "yes";
            
            Console.Write("Введите длину имени: ");
            int length = int.Parse(Console.ReadLine() ?? "10");

            Console.Write("Введите префикс (нажмите Enter, чтобы пропустить): ");
            string prefix = Console.ReadLine() ?? "";

            Console.Write("Введите суффикс (нажмите Enter, чтобы пропустить): ");
            string suffix = Console.ReadLine() ?? "";

            bool specialCharacters = false;
            if (!isHumanized)
            {
                Console.Write("Хотите добавить специальные символы? (д/н): ");
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

            Console.WriteLine($"Сгенерированное имя пользователя: {genName.generate(model)}");
        }
    }
}
