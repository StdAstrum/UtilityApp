using Spectre.Console;
using Spectre.Console.Rendering;

namespace UtilityApp.Interface
{
    public class menu
    {
        public static void Animate()
        {
            var logo = @"
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
MMMMMMMMMMMMNOc;xWMMMMMMMWKd0WMMMMMMMMMM
";

            string logoText = @"
             _                         _   _ _   _ _ _ _
   / \   ___| |_ _ __ _   _ _ __ ___  | | | | |_(_) (_) |_ _   _
  / _ \ / __| __| '__| | | | '_ ` _ \ | | | | __| | | | __| | | |
 / ___ \\__ \ |_| |  | |_| | | | | | || |_| | |_| | | | |_| |_| |
/_// \\_\___/\__|_|   \__,_|_| |_| |_| \___/ \__|_|_|_|\__|\__, |
  / _ \ | '_ \| '_ \                                        |___/
 / ___ \| |_) | |_) |
/_/   \_\ .__/| .__/
        |_|   |_|
";

            var logoMarkup = new Markup(logo);
            var logoTextMarkup = new Markup(logoText);

            var grid = new Grid();
            grid.AddColumn(); // For the logo
            grid.AddColumn(); // For the logo text
            grid.AddRow(logoMarkup, logoTextMarkup);

            var logoPanel = new Panel(grid)
                .Border(BoxBorder.Rounded)
                .Expand();

            AnsiConsole.Clear();
            AnsiConsole.Write(logoPanel);
        }

        public static void ShowMenu()
        {
            while (true)
            {
                Animate();

                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[bold yellow]Выберите действие:[/]")
                        .PageSize(10)
                        .AddChoices(
                            "1. Name", "2. Password", "3. Email", "4. Account",
                            "5. Key", "6. Phone", "7. Text", "8. Hash",
                            "9. Tunnel", "Exit"
                        )
                );

                switch (choice)
                {
                    case "1. Name":
                        geName.run();
                        break;
                    case "2. Password":
                        gePassword.run();
                        break;
                    case "3. Email":
                        geEmail.run();
                        break;
                    case "4. Account":
                        geAccount.run();
                        break;
                    case "5. Key":
                        geKey.run();
                        break;
                    case "6. Phone":
                        gePhone.run();
                        break;
                    case "7. Text":
                        geText.run();
                        break;
                    case "8. Hash":
                        geHash.run();
                        break;
                    case "9. Tunnel":
                        geTunnel.run();
                        break;
                    case "   Exit":
                        AnsiConsole.MarkupLine("[yellow]Выход...[/]");
                        return;
                }

                AnsiConsole.MarkupLine("\n[grey]Нажми Enter для возврата в меню...[/]");
                Console.ReadLine();
            }
        }
    }
}
