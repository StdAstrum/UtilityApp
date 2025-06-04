namespace UtilityApp.Models
{
    public class passwordModel
    {
        public int length { get; set; } = 8;
        public bool specialCharacters { get; set; } = Data.defaultSpecialCharacters;
    }
}
