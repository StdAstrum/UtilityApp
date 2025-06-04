using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genAccount
    {
        public static List<string> generate(nameModel nameModel, phoneModel phoneModel,
                                            emailModel emailModel, passwordModel passwordModel)
        {
            List<string> elements = new List<string>();
            elements.Add(genName.generate(nameModel));
            elements.Add(genPhone.generate(phoneModel));
            elements.Add(genEmail.generate(emailModel));
            elements.Add(genPassword.generate(passwordModel));

            return elements;
        }
    }
}
