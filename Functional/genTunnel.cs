using UtilityApp.Models;

namespace UtilityApp.Functional
{
    public class genTunnel
    {
        public static string generate(tunnelModel model)
        {
            string tunnel = $"ssh -R {model.portFrom}:{model.hostFrom}:{model.portTo} {model.hostTo}";
            
            if (model.hostPortSsh > 0) tunnel += $" -p {model.hostPortSsh}";

            if (model.isJustDNS)
                tunnel = $"ssh -R {model.portFrom}:{model.hostFrom}:{model.portTo} {model.hostTo}";

            return tunnel;
        }
    }
}
