using PhoneNumbers;
using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genPhone
    {
        public static string generate(phoneModel model)
        {
            var phoneUtil = PhoneNumberUtil.GetInstance();

            if (string.IsNullOrWhiteSpace(model.region))
                model.region = Data.defaultRegion;
                
            return phoneUtil.Format(phoneUtil.GetExampleNumber(model.region),
                                    PhoneNumberFormat.E164);
        }
    }
}
