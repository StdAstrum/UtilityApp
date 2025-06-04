namespace UtilityApp.Models
{
    public class apiModel
    {
        public int count { get; set; } = 4;
        public List<int> length { get; set; } = new List<int> { 6, 8, 4, 10 };
        public char separator { get; set; } = Data.defaultSeparator;
        public string prefix { get; set; } = string.Empty;
        public string suffix { get; set; } = string.Empty;
        public char separatorPrefix { get; set; } = Data.defaultSeparator;
        public char separatorSuffix { get; set; } = Data.defaultSeparator;
        public bool specialCharacters { get; set; } = Data.defaultSpecialCharacters;
        public bool uppercaseCharacters { get; set; } = false;
    }
}
