using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genName
    {
        public static string generate(nameModel model)
        {
            Random random = new Random();
            string chars = Data.chars;

            if (model.specialCharacters) chars += Data.specialChars;

            string name = new string(Enumerable.Repeat(chars, model.length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            if (!string.IsNullOrEmpty(model.prefix))
                name = model.prefix + model.separatorPrefix + name;

            if (!string.IsNullOrEmpty(model.suffix))
                name += model.separatorSuffix + model.suffix;

            return name;
        }
    }
}
