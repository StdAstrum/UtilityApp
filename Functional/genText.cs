using LoremNET;
using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genText
    {
        public static string generate(textModel model)
        {
            if (string.IsNullOrEmpty(model.type))
                throw new ArgumentNullException(nameof(model), "Model cannot be null");

            switch (model.type.ToLower())
            {
                case "paragraphs":
                    return Lorem.Paragraph(model.length, model.length);
                case "sentences":
                    return Lorem.Sentence(model.length);
                case "words":
                    return Lorem.Words(model.length);
                default:
                    throw new ArgumentException($"Unsupported text type: {model.type}");
            }

            return string.Empty;
        }
    }
}
