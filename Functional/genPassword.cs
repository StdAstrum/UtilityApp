using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genPassword
    {
        public static string generate(passwordModel model)
        {
            Random random = new Random();
            string chars = Data.chars;

            if (model.specialCharacters) chars += Data.specialChars;

            string password = new string(Enumerable.Repeat(chars, model.length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return password;
        }
    }
}
