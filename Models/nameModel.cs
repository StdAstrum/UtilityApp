namespace UtilityApp.Models
{
    public class nameModel
    {
        public int length { get; set; } = 6;
        public string prefix { get; set; } = string.Empty;
        public string suffix { get; set; } = string.Empty;
        public char separatorPrefix { get; set; } = Data.defaultSeparator;
        public char separatorSuffix { get; set; } = Data.defaultSeparator;
        public bool specialCharacters { get; set; } = Data.defaultSpecialCharacters;
        public bool isHumanized { get; set; } = false;
    }
}
