using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genEmail
    {
        public static string generate(emailModel model)
        {
            Random random = new Random();

            string name = new string(Enumerable.Repeat(Data.charsUppercase + Data.chars, model.length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            if (string.IsNullOrWhiteSpace(model.domain))
                model.domain = Data.defaultDomain;

            if (!string.IsNullOrEmpty(model.prefix))
                name = model.prefix + model.separatorPrefix + name;

            if (!string.IsNullOrEmpty(model.suffix))
                name += model.separatorSuffix + model.suffix;

            return $"{name}@{model.domain}";
        }
    }
}
