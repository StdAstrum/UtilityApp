using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
    class gePhone 
    {
        public static void run()
        {
            Console.Write($"Enter region (Default is {Data.defaultRegion}): ");
            string region = Console.ReadLine() ?? Data.defaultRegion;
            if (string.IsNullOrWhiteSpace(region))
                region = Data.defaultRegion;

            phoneModel model = new phoneModel();
            model.region = region;

            Console.WriteLine($"Generated Phone: {genPhone.generate(model)}");
        }
    }
}