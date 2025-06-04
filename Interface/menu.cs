using UtilityApp.Functional;
using UtilityApp.Models;

namespace UtilityApp.Interface
{
    public class menu
    {
        public static void Animate()
        {
            string animation = @"
             _                          _   _ _   _ _ _ _          
   / \   ___| |_ _ __ _   _ _ __ ___   | | | | |_(_) (_) |_ _   _ 
  / _ \ / __| __| '__| | | | '_ ` _ \  | | | | __| | | | __| | | |
 / ___ \\__ \ |_| |  | |_| | | | | | | | |_| | |_| | | | |_| |_| |
/_// \\_\___/\__|_|   \__,_|_| |_| |_|  \___/ \__|_|_|_|\__|\__, |
  / _ \ | '_ \| '_ \                                        |___/ 
 / ___ \| |_) | |_) |                                             
/_/   \_\ .__/| .__/                                              
        |_|   |_|         
            ";

            string logo = @"
MMMMMMMMN0dc'.,lkKWMMMMWk;.':d0NWMMMMMMM
MMMMMNOo;..'::,..'cdk0NWNOd:'..;oONMMMMM
MMMMMO,.,cx0NWXOo:'..';oOXWNKx:..,OMMMMM
MMMMMKxkXWWKOOKWMN0xoc,..,l0WM0;.,OMMMMM
MMMMMMMN0dc'..'cx0NMMWKx;..oNMK:.,OMMMMM
MMMWXOo;..':ll:'..:dOXMWd..lNMK:.,OMMMMM
WKxl,..,cx0NMMN0xc'';xWWd..lNMK:.'OMWXKN
c'..;lkXWMN0xdkXWWK0OXMWd..oNMK:.'OMXl':
..,kNWWXOo:'.'cOWMMMMMMWOldKWW0;.'OMXc..
..cXMXd,..'cd0NMMMMMMMMMMWWXOo;..;0MXc..
..cXMO,.'dKWWXOXMMMMMMMMXkl,..,cxKWMK:..
..cXMO,.:KMWk,'dWMWWWMMW0c,;okXWMN0x:..'
OokNMO,.:KMNo..dWWOccokXWWXNWWXOo:'.':oO
MMMMMO,.:KMNo..dWWO;...,lx00kl,..,cx0NMM
MMMMMO,.:KMNo..lXMWX0ko;......;lkKWMMMMM
MMMMMO,.:KMWx'..;oOXWWWN0dccoOXWNXNMMMMM
MMMMMO,.'xXWWKxc,..,:lxKWMWWWXOo:;OMMMMM
MMMMMXo,..;lkKWWKkl;'..'cdkxl;..'lKMMMMM
MMMMMMWKkl;..'cOWMWNKOd:'....;lkKWMMMMMM
MMMMMMMMMWKd;';kWMMMMMMNk:';dKWMMMMMMMMM
";

            string[] logoLines = logo.Split('\n', StringSplitOptions.RemoveEmptyEntries);
            string[] animationLines = animation.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            int logoHeight = logoLines.Length;
            int animationHeight = animationLines.Length;

            int topPadding = (logoHeight - animationHeight) / 2;
            if (topPadding < 0) topPadding = 0;

            int logoWidth = 0;
            foreach (var line in logoLines)
                if (line.Length > logoWidth) logoWidth = line.Length;

            int maxLines = Math.Max(logoHeight, animationHeight + topPadding);

            for (int i = 0; i < maxLines; i++)
            {
                string logoLine = i < logoHeight ? logoLines[i].TrimEnd('\r') : new string(' ', logoWidth);

                string animationLine = "";
                if (i >= topPadding && i < topPadding + animationHeight)
                {
                    animationLine = animationLines[i - topPadding].TrimEnd('\r');
                }

                Console.WriteLine(logoLine.PadRight(logoWidth + 4) + animationLine);
                Thread.Sleep(150);
            }
            Console.WriteLine($"");
        }

        public static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine();
                string menu = @"
1. gen. Name     2. gen. Password   3. gen. Email   4. gen. Account
5. gen. Key      6. gen. Phone      7. gen. Text    8. gen. Hash
9. gen. Tunnel   10. Exit
                ";

                string[] menuLines = menu.Split('\n', StringSplitOptions.RemoveEmptyEntries);

                foreach (var line in menuLines)
                {
                    string trimmedLine = line.TrimEnd('\r').Trim();
                    if (trimmedLine.Length == 0) continue;

                    foreach (char c in line)
                    {
                        Console.Write(c);
                        Thread.Sleep(15);
                    }
                    Console.WriteLine();
                    Thread.Sleep(150);
                }

                Console.Write("Select menu item (1-9): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        geName.run();
                        awaitUserInput();
                        break;
                    case "2":
                        gePassword.run();
                        awaitUserInput();
                        break;
                    case "3":
                        geEmail.run();
                        awaitUserInput();
                        break;
                    case "4":
                        geAccount.run();
                        awaitUserInput();
                        break;
                    case "5":
                        geKey.run();
                        awaitUserInput();
                        break;
                    case "6":
                        gePhone.run();
                        awaitUserInput();
                        break;
                    case "7":
                        geText.run();
                        awaitUserInput();
                        break;
                    case "8":
                        geHash.run();
                        awaitUserInput();
                        break;
                    case "9":
                        geTunnel.run();
                        awaitUserInput();
                        break;
                    case "10":
                        return;
                    default:
                        Console.WriteLine("This item is not avaliable now.");
                        break;
                }
                Console.Clear();
            }
        }

        public static void awaitUserInput()
        {
            Console.WriteLine("Press return to continue...");
            Console.Read();
        }
    }
}
