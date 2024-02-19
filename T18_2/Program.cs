using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T18_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool flag = true;
                Write("Press the right key:\nX - to show info about XML\nT - to show info about TXT\nD - to show info about DOC\nEsc - to close console");
                while (flag)
                {
                    ConsoleKeyInfo key = ReadKey(true);
                    WriteLine("\n");
                    if (key.Key == ConsoleKey.X)
                    {
                        AbstractHandler handler = new XMLHandler();
                        handler.Open(); handler.Create(); handler.Change(); handler.Save();
                        WriteLine();
                    }
                    else if (key.Key == ConsoleKey.T)
                    {
                        AbstractHandler handler = new TXTHandler();
                        handler.Open(); handler.Create(); handler.Change(); handler.Save();
                        WriteLine();
                    }
                    else if (key.Key == ConsoleKey.D)
                    {
                        AbstractHandler handler = new DOCHandler();
                        handler.Open(); handler.Create(); handler.Change(); handler.Save();
                        WriteLine();
                    }
                    else if (key.Key == ConsoleKey.Escape) { Environment.Exit(0); }
                    else { WriteLine("You pressed the wrong key. Try again!"); }
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
