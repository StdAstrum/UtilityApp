using System.Text;
using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genName
    {
        public static string generate(nameModel model)
        {
            Random random = new Random();
            string chars = Data.charsUppercase + Data.chars;

            if (model.specialCharacters) chars += Data.specialChars;

            string name = string.Empty;
            if (model.isHumanized)
            {
                string vowels = "aeiouy";
                string consonants = "bcdfghjklmnpqrstvwxz";
                var sb = new StringBuilder();
                bool isVowel = random.Next(2) == 0;

                for (int i = 0; i < model.length; i++)
                {
                    sb.Append(isVowel ? vowels[random.Next(vowels.Length)] : consonants[random.Next(consonants.Length)]);
                    isVowel = !isVowel;
                }

                name = char.ToUpper(sb[0]) + sb.ToString().Substring(1);
            }
            else
                name = new string(Enumerable.Repeat(chars, model.length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());

            if (!string.IsNullOrEmpty(model.prefix))
                name = model.prefix + model.separatorPrefix + name;

            if (!string.IsNullOrEmpty(model.suffix))
                name += model.separatorSuffix + model.suffix;

            return name;
        }
    }
}
