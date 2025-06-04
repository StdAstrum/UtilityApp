using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
    class geAccount 
    {
        public static void run()
        {
            Console.WriteLine($"\n=-=-=-=-=-=-Account generation=-=-=-=-=-=-\n");
            
            // Имя
            Console.WriteLine($"Name generation...\n");
            
            Console.Write("Enter the length of name: ");
            int nameLength = int.Parse(Console.ReadLine() ?? "10");

            Console.Write("Enter prefix (Press return to skip): ");
            string prefix = Console.ReadLine() ?? "";

            Console.Write("Enter suffix (Press return to skip): ");
            string suffix = Console.ReadLine() ?? "";

            Console.Write("Do you want to add a special characters? (y/n): ");
            bool nameSpecial = (Console.ReadLine()?.Trim().ToLower() ?? "") switch
            {
                "y" or "yes" => true,
                _ => false
            };

            nameModel nameModel = new nameModel
            {
                length = nameLength,
                prefix = prefix,
                suffix = suffix,
                separatorPrefix = '_',
                separatorSuffix = '>',
                specialCharacters = nameSpecial
            };

            // Телефон
            Console.WriteLine($"\nPhone generation...\n");
            Console.Write($"Enter region (Default is {Data.defaultRegion}): ");
            string region = Console.ReadLine();
            phoneModel phoneModel = new phoneModel
            {
                region = string.IsNullOrWhiteSpace(region) ? Data.defaultRegion : region
            };

            // Email
            Console.WriteLine($"\nEmail generation...\n");
            Console.Write("Enter the length of email login: ");
            int emailLength = int.Parse(Console.ReadLine() ?? "10");

            Console.Write($"Enter domain (Default is {Data.defaultDomain}): ");
            string domain = Console.ReadLine();
            emailModel emailModel = new emailModel
            {
                length = emailLength,
                domain = string.IsNullOrWhiteSpace(domain) ? Data.defaultDomain : domain
            };

            // Пароль
            Console.WriteLine($"\nPassword generation...\n");
            Console.Write("Enter the length of password: ");
            int passwordLength = int.Parse(Console.ReadLine() ?? "10");

            Console.Write("Do you want to add a special characters? (y/n): ");
            bool passwordSpecial = (Console.ReadLine()?.Trim().ToLower() ?? "") switch
            {
                "y" or "yes" => true,
                _ => false
            };

            passwordModel passwordModel = new passwordModel
            {
                length = passwordLength,
                specialCharacters = passwordSpecial
            };

            List<string> accountDetails = genAccount.generate(nameModel, phoneModel, emailModel, passwordModel);

            Console.WriteLine("\nGenerated account data:\n");
            Console.WriteLine($"Name: {accountDetails[0]}");
            Console.WriteLine($"Phone: {accountDetails[1]}");
            Console.WriteLine($"Email: {accountDetails[2]}");
            Console.WriteLine($"Password: {accountDetails[3]}");
            Console.WriteLine("\n=-=-=-=-=-=-=End of generation=-=-=-=-=-=-=\n");
            
        }
    }
}