using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface 
{
    class geTunnel 
    {
        public static void run()
        {
            Console.Write("Enter the port from local machine (portFrom): ");
            int portFrom = int.Parse(Console.ReadLine() ?? "2222");

            Console.Write("Enter the local machine host (hostFrom): ");
            string hostFrom = Console.ReadLine() ?? "localhost";

            Console.Write("Enter the destination port (portTo): ");
            int portTo = int.Parse(Console.ReadLine() ?? "22");
            
            Console.Write("DNS mode? (y/n): ");
            string dnsModeInput = Console.ReadLine()?.Trim().ToLower();
            bool isJustDNS = dnsModeInput == "y" || dnsModeInput == "yes";

            Console.Write("Enter SSH host (hostTo): ");
            string hostTo = Console.ReadLine() ?? "root@127.0.0.1";

            int sshPort = 0;
            if (!isJustDNS)
            {
                Console.Write("Enter SSH port (Press return to skip, Default is 22): ");
                string sshPortInput = Console.ReadLine();
                sshPort = string.IsNullOrWhiteSpace(sshPortInput) ? 22 : int.Parse(sshPortInput);
            }

            tunnelModel model = new tunnelModel
            {
                portFrom = portFrom,
                hostFrom = hostFrom,
                portTo = portTo,
                hostTo = hostTo,
                hostPortSsh = sshPort,
                isJustDNS = isJustDNS
            };

            Console.WriteLine($"\nGenetated tunnel command: {genTunnel.generate(model)}");
        }
    }
}