using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Additional_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Printed_matter> printed_Matters = new List<Printed_matter>();
                bool flag = true;
                Write("Press the right key:\nM - to enter info about magazines\nN - to enter info about newspapers\nEsc - to close console");
                while (flag)
                {
                    ConsoleKeyInfo key = ReadKey(true);
                    WriteLine("\n");
                    switch (key.Key)
                    {
                        case ConsoleKey.M:
                            Magazine magazine = new Magazine();
                            printed_Matters.Add(Magazine.Input());
                            Write("\nPress M or N - to continue, S to stop and output information, Esc to close console\n");
                            break;
                        case ConsoleKey.N:
                            Newspaper newspaper = new Newspaper();
                            printed_Matters.Add(Newspaper.Input());
                            Write("\nPress:\nM or N - to continue, S - to stop and output information, Esc - to close console\n");
                            break;
                        case ConsoleKey.S:
                            WriteLine();
                            foreach (var elem in printed_Matters) { elem.Output(); WriteLine(); }
                            flag = false;
                            break;
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;
                        default:
                            Write("You pressed the wrong key. Try again!");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
