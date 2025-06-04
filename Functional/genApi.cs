using System;
using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genApi
    {
        public static string generate(apiModel model)
        {
            Random random = new Random();
            string chars = Data.chars;
            List<string> api = new List<string>();

            if (model.uppercaseCharacters) chars = Data.charsUppercase + Data.chars;
            if (model.specialCharacters) chars += Data.specialChars;

            for (int i = 0; i < model.count; i++)
            {
                int length = model.length[i % model.length.Count];
                string element = new string(Enumerable.Repeat(chars, length)
                    .Select(s => s[random.Next(s.Length)]).ToArray());
                api.Add(element);
            }

            string apiKey = string.Join(model.separator, api);

            if (!string.IsNullOrEmpty(model.prefix))
                apiKey = model.prefix + model.separatorPrefix + apiKey;

            if (!string.IsNullOrEmpty(model.suffix))
                apiKey += model.separatorSuffix + model.suffix;

            return apiKey;
        }
    }
}
