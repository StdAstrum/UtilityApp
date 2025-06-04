namespace UtilityApp.Models
{
    public class emailModel
    {
        public int length { get; set; } = 6;
        public string domain { get; set; } = Data.defaultDomain;
        public string prefix { get; set; } = string.Empty;
        public string suffix { get; set; } = string.Empty;
        public char separatorPrefix { get; set; } = Data.defaultSeparator;
        public char separatorSuffix { get; set; } = Data.defaultSeparator;
    }
}
