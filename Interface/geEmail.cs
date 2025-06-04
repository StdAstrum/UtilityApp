using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
    class geEmail 
    {
        public static void run()
        {
            Console.Write("Enter the length of email login: ");
            int length = int.Parse(Console.ReadLine() ?? "10");

            Console.Write($"Enter domain (Default is {Data.defaultDomain}): ");
            string domain = Console.ReadLine() ?? Data.defaultDomain;

            emailModel model = new emailModel();
            model.length = length;
            model.domain = domain;

            Console.WriteLine($"Generated Email: {genEmail.generate(model)}");
        }
    }
}

