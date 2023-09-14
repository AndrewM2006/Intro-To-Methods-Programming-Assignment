using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_To_Methods_Programming_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuOption;
            Console.SetWindowSize(120, 60);
            Console.WriteLine("Press 1 for Star Wars, 2 for a computer, 3 for a computer mouse or 4 for a joke!");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out menuOption))
                {
                    if (menuOption == 1)
                    {
                        DrawSW();
                    }
                    else if (menuOption == 2)
                    {
                        DrawComputer();
                    }
                    else if (menuOption == 3)
                    {
                        DrawMouse(1, 1, false);
                    }
                    else if (menuOption == 4)
                    {
                        Joke();
                    }
                    else
                    {
                        Console.WriteLine("Press 1 for Star Wars, 2 for a computer, 3 for a computer mouse or 4 for a joke!");
                    }
                }
                else
                {
                    Console.WriteLine("Press 1 for Star Wars, 2 for a computer, 3 for a computer mouse or 4 for a joke!");
                }
            }
            Console.ReadLine();
        }
        public static void DrawSW()
        {
            Console.Write("               ________");
            Console.WriteLine("\t\t\t\t       ________________");
            Console.Write("          _,.-Y  |  |  Y-._");
            Console.WriteLine("\t\t\t     |'-.--._ _________:");
            Console.Write("      .-~' ||  |  |  |   '-.");
            Console.WriteLine("\t\t\t     |  /    |  __    __/");
            Console.Write("      I' ''=='|' !''! '|'[]''|     _____");
            Console.WriteLine("\t     | |  _  | [/_/= [/_/");
            Console.Write("      L__  [] |..------|:   _[----I'' .-{''-.");
            Console.WriteLine("\t     | |.' '. /.........|");
            Console.Write("     I___ |  ..| l______|l_ [__L]_[I_/r(=}=-P");
            Console.WriteLine("\t     | ( <)  ||:       :|");
            Console.Write("    [L______L_[________]______j~  '-=c_]/=-^");
            Console.WriteLine("\t      / '._.' | :.....: |_(o");
            Console.Write("     /_I_j.--./==I|I==_/.--L_]");
            Console.WriteLine("\t\t\t       '-//_   // .------./");
            Console.Write("       [_((==)[`-----'](==)j");
            Console.WriteLine("\t\t\t       _   /   ||.---.||  _");
            Console.Write("          I--I'~~'''~~'I--I");
            Console.WriteLine("\t\t\t      / /  '-._|//n~~/n' | /");
            Console.Write("          |[]|         |[]|");
            Console.WriteLine("\t\t\t     (| []=.--[===[()]===[) |");
            Console.Write("          l__j         l__j");
            Console.WriteLine("\t\t\t     </_/  /_______/ _.' /_/");
            Console.Write("          | !!|         |!!|");
            Console.WriteLine("\t\t\t     ///            (_/_/");
            Console.Write("          | ..|         |..|");
            Console.WriteLine("\t\t\t      |/            [/");
            Console.Write("          ([])         ([])");
            Console.WriteLine("\t\t\t     ||:|           | I|");
            Console.Write("          ]--[         ]--[");
            Console.WriteLine("\t\t\t     |::|           | I|");
            Console.Write("          [_L]         [_L]");
            Console.WriteLine("\t\t\t     ||:|           | I|");
            Console.Write("         /|..|/       /|..|/");
            Console.WriteLine("\t\t\t     ||:|           : /:");
            Console.Write("        `=}--{='     `=}--{='");
            Console.WriteLine("\t\t\t     |/:|            /I|");
            Console.Write("       .-^--r-^-.   .-^--r-^-.");
            Console.WriteLine("\t\t\t     ://:            ([])");
            Console.WriteLine("\t\t\t\t\t\t     ([])             [|");
            Console.WriteLine("\t\t\t\t\t\t      ||              |/_");
            Console.WriteLine("\t\t\t\t\t\t     _/_/_            [ -'-.__");
            Console.WriteLine("\t\t\t\t\t\t    <]   />            /_____.>");
            Console.WriteLine("\t\t\t\t\t\t      /__/");
        }
        public static void DrawComputer()
        {
            Console.WriteLine("         _______");
            Console.WriteLine("        |.-----.|");
            Console.WriteLine("        ||x . x||");
            Console.WriteLine("        ||_.-._||");
            Console.WriteLine("        `--)-(--`");
            Console.WriteLine("       __[=== o]___");
            Console.WriteLine("      |:::::::::::|/");
            Console.WriteLine("      `-=========-`()");
        }
        public static void DrawMouse(int xValue, int yValue, bool valid=false)
        {
            Console.WriteLine("Enter an X and Y value:");
            while (valid == false)
            {
                if (int.TryParse(Console.ReadLine(), out xValue)&& xValue>=0&&xValue<=114)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Enter a Valid Value");
                }
            }
            valid = false;
            while (valid == false)
            {
                if (int.TryParse(Console.ReadLine(), out yValue) && yValue >= 0 && yValue <= 60)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Enter a Valid Value");
                }
            }
            Console.SetCursorPosition(xValue, yValue);
            Console.WriteLine("   /");
            Console.SetCursorPosition(xValue, yValue+1);
            Console.WriteLine(" __|_");
            Console.SetCursorPosition(xValue, yValue+2);
            Console.WriteLine("|____|");
            Console.SetCursorPosition(xValue, yValue+3);
            Console.WriteLine("|    |");
            Console.SetCursorPosition(xValue, yValue+4);
            Console.WriteLine("|    |");
            Console.SetCursorPosition(xValue, yValue+5);
            Console.WriteLine("|____/");
        }
        public static void Joke()
        {
            Console.WriteLine("Why do Java Programmers always need glasses?");
            Console.ReadLine();
            Console.WriteLine("Because they don't C#");
        }
    }
}
