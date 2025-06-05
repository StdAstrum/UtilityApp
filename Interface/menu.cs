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

            var logoText = new FigletText("Astrum Utility")
                .Centered()
                .Color(Color.Yellow);

            var logoMarkup = new Markup(logo)
                .Centered();

            var combined = new Rows(new IRenderable[]
            {
                logoMarkup,
                logoText
            });

            var logoPanel = new Panel(combined)
                .Border(BoxBorder.Rounded)
                .Expand();

            AnsiConsole.Clear();
            AnsiConsole.Write(logoPanel);
        }

        public static void ShowMenu()
        {
            while (true)
            {
                // Показать анимацию загрузки
                AnsiConsole.Status()
                    .Spinner(Spinner.Known.Star)
                    .SpinnerStyle(Style.Parse("yellow bold"))
                    .Start("Loading menu...", ctx =>
                    {
                        System.Threading.Thread.Sleep(800); // Короткая пауза для плавного перехода
                    });

                // Создать таблицу для опций меню
                var table = new Table()
                    .Border(TableBorder.Rounded)
                    .BorderColor(Color.Green)
                    .AddColumn(new TableColumn("[bold yellow]Option[/]").Centered())
                    .AddColumn(new TableColumn("[bold yellow]Description[/]").Centered())
                    .Width(80); // Фиксированная ширина для центрирования

                // Добавить опции меню с иконками, цветами и описаниями, с чередующимся фоном
                table.AddRow(new Markup("[cyan on grey19]➤ 1. Name[/]"), new Markup("[grey on grey19]Create a username[/]"));
                table.AddRow(new Markup("[blue]★ 2. Password[/]"), new Markup("[grey]Create a secure password[/]"));
                table.AddRow(new Markup("[purple on grey19]✉ 3. Email[/]"), new Markup("[grey on grey19]Create an email address[/]"));
                table.AddRow(new Markup("[green]⚙ 4. Account[/]"), new Markup("[grey]Create an account profile[/]"));
                table.AddRow(new Markup("[yellow on grey19]🔑 5. Key[/]"), new Markup("[grey on grey19]Create encryption keys[/]"));
                table.AddRow(new Markup("[aqua]📞 6. Phone[/]"), new Markup("[grey]Create a phone number[/]"));
                table.AddRow(new Markup("[fuchsia on grey19]📝 7. Text[/]"), new Markup("[grey on grey19]Create random text[/]"));
                table.AddRow(new Markup("[lime]🔒 8. Hash[/]"), new Markup("[grey]Create a hash value[/]"));
                table.AddRow(new Markup("[teal on grey19]🌐 9. Tunnel[/]"), new Markup("[grey on grey19]Set up a network tunnel[/]"));
                table.AddRow(new Markup("[yellow]🔗 10. Api[/]"), new Markup("[grey]Create an API key[/]"));
                table.AddRow(new Markup("[red]🚪 11. Exit[/]"), new Markup("[grey]Quit the application[/]"));

                // Создать панель для таблицы с желтым заголовком
                var panel = new Panel(table)
                    .Header("[yellow bold]Menu Astrum Utility[/]")
                    .Border(BoxBorder.Double)
                    .BorderColor(Color.Yellow)
                    .Expand()
                    .Padding(2, 2, 2, 2); // Увеличенный отступ для баланса

                // Добавить нижний колонтитул
                var footer = new Markup("[grey italic]Astrum Utility v1.0 | Powered by Spectre.Console[/]")
                    .Centered();

                // Очистить консоль и отобразить меню
                AnsiConsole.Clear();
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new FigletText("Menu")
                    .Centered()
                    .Color(Color.Green));
                AnsiConsole.Write(panel);
                AnsiConsole.Write(footer);
                AnsiConsole.WriteLine();

                // Запрос выбора с поддержкой горячих клавиш
                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[grey]Use arrow keys or number keys (1-9, 0, q) and Enter for selection:[/]")
                        .PageSize(10)
                        .HighlightStyle(new Style(foreground: Color.White, background: Color.Blue))
                        .AddChoices(
                            "1. ​​Name", "2. Password", "3. Email", "4. Account",
                            "5. Key", "6. Phone", "7. Text", "8. Hash",
                            "9. Tunnel", "10. Api", "11. Exit"
                        )
                        .UseConverter(option => option switch
                        {
                            "1. Name" => "➤ 1. Name",
                            "2. Password" => "★ 2. Password",
                            "3. Email" => "✉ 3. Email",
                            "4. Account" => "⚙ 4. Account",
                            "5. Key" => "🔑 5. Key",
                            "6. Phone" => "📞 6. Phone",
                            "7. Text" => "📝 7. Text",
                            "8. Hash" => "🔒 8. Hash",
                            "9. Tunnel" => "🌐 9. Tunnel",
                            "10. Api" => "🔗 10. Api",
                            "11. Exit" => "🚪 11. Exit",
                            _ => option
                        })
                );

                // Обработка горячих клавиш
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    choice = key.KeyChar switch
                    {
                        '1' => "1. Name",
                        '2' => "2. Password",
                        '3' => "3. Email",
                        '4' => "4. Account",
                        '5' => "5. Key",
                        '6' => "6. Phone",
                        '7' => "7. Text",
                        '8' => "8. Hash",
                        '9' => "9. Tunnel",
                        '0' => "10. Api",
                        'q' => "11. Exit",
                        _ => choice
                    };
                    // Очистить оставшийся ввод
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                }

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
                    case "10. Api":
                        geApi.run();
                        break;
                    case "11. Exit":
                        AnsiConsole.MarkupLine("[yellow]Exit...[/]");
                        return;
                }

                AnsiConsole.MarkupLine("\n[grey]Press return to return to the menu...[/]");
                // Очистить буфер ввода перед чтением
                while (Console.KeyAvailable)
                {
                    Console.ReadKey(true);
                }
                Console.ReadLine();
            }
        }
    }
}