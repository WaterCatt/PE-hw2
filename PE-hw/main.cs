using System.Diagnostics;
using static System.Console;
namespace PE_hw
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
            while(true)
            {
                Write("Хочешь рофл? Введи y/n: ");
                string s = ReadLine();
                if (s.ToLower() == "y")
                {
                    Rofl();
                    WriteLine("Ну держи");
                    break;
                }
                else if (s.ToLower() == "n")
                {
                    WriteLine("Ну... ладно");
                    break;
                }
                Clear();
            }
            Rofl();
        }

        /// <summary>
        /// Вызывает рофл
        /// </summary>
        static void Rofl()
        {
            for (var i = 0; i < 3; i++)
                Process.Start(new ProcessStartInfo("https://www.youtube.com/watch?v=dQw4w9WgXcQ") { UseShellExecute = true });
            Process.Start(new ProcessStartInfo("https://kappa.lol/-j5Da") { UseShellExecute = true });
            Process.Start(new ProcessStartInfo("https://kappa.lol/OdB0f") { UseShellExecute = true });
        }
    }
}
