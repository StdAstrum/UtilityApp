namespace UtilityApp.Models
{
    public class hashModel
    {
        public string data { get; set; } = string.Empty;
        public string salt { get; set; } = string.Empty;
        public string algorithm { get; set; } = Data.defaultHashAlgorithm;
    }
}
