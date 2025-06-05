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
                    .Start("Загрузка меню...", ctx =>
                    {
                        System.Threading.Thread.Sleep(800); // Короткая пауза для плавного перехода
                    });

                // Создать таблицу для опций меню
                var table = new Table()
                    .Border(TableBorder.Rounded)
                    .BorderColor(Color.Green)
                    .AddColumn(new TableColumn("[bold yellow]Опция[/]").Centered())
                    .AddColumn(new TableColumn("[bold yellow]Описание[/]").Centered())
                    .Width(80); // Фиксированная ширина для центрирования

                // Добавить опции меню с иконками, цветами и описаниями, с чередующимся фоном
                table.AddRow(new Markup("[cyan on grey19]➤ 1. Имя[/]"), new Markup("[grey on grey19]Создать имя пользователя[/]"));
                table.AddRow(new Markup("[blue]★ 2. Пароль[/]"), new Markup("[grey]Создать безопасный пароль[/]"));
                table.AddRow(new Markup("[purple on grey19]✉ 3. Email[/]"), new Markup("[grey on grey19]Создать адрес электронной почты[/]"));
                table.AddRow(new Markup("[green]⚙ 4. Аккаунт[/]"), new Markup("[grey]Создать профиль аккаунта[/]"));
                table.AddRow(new Markup("[yellow on grey19]🔑 5. Ключ[/]"), new Markup("[grey on grey19]Создать ключи шифрования[/]"));
                table.AddRow(new Markup("[aqua]📞 6. Телефон[/]"), new Markup("[grey]Создать номер телефона[/]"));
                table.AddRow(new Markup("[fuchsia on grey19]📝 7. Текст[/]"), new Markup("[grey on grey19]Создать случайный текст[/]"));
                table.AddRow(new Markup("[lime]🔒 8. Хэш[/]"), new Markup("[grey]Создать хэш-значение[/]"));
                table.AddRow(new Markup("[teal on grey19]🌐 9. Туннель[/]"), new Markup("[grey on grey19]Настроить сетевой туннель[/]"));
                table.AddRow(new Markup("[red]🚪 10. Выход[/]"), new Markup("[grey]Выйти из приложения[/]"));

                // Создать панель для таблицы с желтым заголовком
                var panel = new Panel(table)
                    .Header("[yellow bold]Меню Astrum Utility[/]")
                    .Border(BoxBorder.Double)
                    .BorderColor(Color.Yellow)
                    .Expand()
                    .Padding(2, 2, 2, 2); // Увеличенный отступ для баланса

                // Добавить нижний колонтитул
                var footer = new Markup("[grey italic]Astrum Utility v1.0 | Работает на Spectre.Console[/]")
                    .Centered();

                // Очистить консоль и отобразить меню
                AnsiConsole.Clear();
                AnsiConsole.WriteLine();
                AnsiConsole.Write(new FigletText("Меню")
                    .Centered()
                    .Color(Color.Green));
                AnsiConsole.Write(panel);
                AnsiConsole.Write(footer);
                AnsiConsole.WriteLine();

                // Запрос выбора с поддержкой горячих клавиш
                var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("[grey]Используйте стрелки или цифровые клавиши (1-10) и Enter для выбора:[/]")
                        .PageSize(10)
                        .HighlightStyle(new Style(foreground: Color.White, background: Color.Blue))
                        .AddChoices(
                            "1. Имя", "2. Пароль", "3. Email", "4. Аккаунт",
                            "5. Ключ", "6. Телефон", "7. Текст", "8. Хэш",
                            "9. Туннель", "10. Выход"
                        )
                        .UseConverter(option => option switch
                        {
                            "1. Имя" => "➤ 1. Имя",
                            "2. Пароль" => "★ 2. Пароль",
                            "3. Email" => "✉ 3. Email",
                            "4. Аккаунт" => "⚙ 4. Аккаунт",
                            "5. Ключ" => "🔑 5. Ключ",
                            "6. Телефон" => "📞 6. Телефон",
                            "7. Текст" => "📝 7. Текст",
                            "8. Хэш" => "🔒 8. Хэш",
                            "9. Туннель" => "🌐 9. Туннель",
                            "10. Выход" => "🚪 10. Выход",
                            _ => option
                        })
                );

                // Обработка горячих клавиш
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true);
                    choice = key.KeyChar switch
                    {
                        '1' => "1. Имя",
                        '2' => "2. Пароль",
                        '3' => "3. Email",
                        '4' => "4. Аккаунт",
                        '5' => "5. Ключ",
                        '6' => "6. Телефон",
                        '7' => "7. Текст",
                        '8' => "8. Хэш",
                        '9' => "9. Туннель",
                        '0' => "10. Выход",
                        _ => choice // Возврат к выбору через prompt
                    };
                    // Очистить оставшийся ввод
                    while (Console.KeyAvailable)
                    {
                        Console.ReadKey(true);
                    }
                }

                switch (choice)
                {
                    case "1. Имя":
                        geName.run();
                        break;
                    case "2. Пароль":
                        gePassword.run();
                        break;
                    case "3. Email":
                        geEmail.run();
                        break;
                    case "4. Аккаунт":
                        geAccount.run();
                        break;
                    case "5. Ключ":
                        geKey.run();
                        break;
                    case "6. Телефон":
                        gePhone.run();
                        break;
                    case "7. Текст":
                        geText.run();
                        break;
                    case "8. Хэш":
                        geHash.run();
                        break;
                    case "9. Туннель":
                        geTunnel.run();
                        break;
                    case "10. Выход":
                        AnsiConsole.MarkupLine("[yellow]Выход...[/]");
                        return;
                }

                AnsiConsole.MarkupLine("\n[grey]Нажми Enter для возврата в меню...[/]");
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
