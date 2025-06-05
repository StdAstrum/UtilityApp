using Spectre.Console;
using Spectre.Console.Rendering;

namespace UtilityApp.Interface
{
    class Message
    {
        public static void ShowMessage()
        {
            Console.Clear();
            var welcomeText = new FigletText("Welcome")
                .Centered()
                .Color(Color.Yellow);
            var appText = new FigletText("Astrum utility app")
                .Centered()
                .Color(Color.Blue);

            var combinedText = new Rows(new IRenderable[]
            {
                welcomeText,
                appText
            });

            var panel = new Panel(combinedText)
            {
                Border = BoxBorder.Double,
                Header = new PanelHeader("[green bold]Startup[/]"),
                Padding = new Padding(1, 1, 1, 1)
            };

            AnsiConsole.Write(panel);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}