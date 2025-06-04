namespace UtilityApp.Models
{
    public class tunnelModel
    {
        public int portFrom { get; set; } = 22;
        public string hostFrom { get; set; } = "127.0.0.1";
        public int portTo { get; set; } = 22;
        public string hostTo { get; set; } = "root@127.0.0.1";
        public int hostPortSsh { get; set; } = 0;
        public bool isJustDNS { get; set; } = false;
    }
}
