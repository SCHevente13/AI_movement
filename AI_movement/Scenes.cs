using System;
using System.Collections.Generic;
using System.Text;

namespace AI_movement
{
    internal class Scenes
    {
        //Console.WriteLine("█▓▒░");
        public static void Empty()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("]                                                                                                                      [");
            Console.WriteLine("O                                                                                                                      O");
            Console.WriteLine("]                                                                                                                      [");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
        }
        public static void Allignment()
        {
            Console.WriteLine("*--------------------------------------------------------=<O>=---------------------------------------------------------*");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine(":----------------------------------------------------------------------------------------------------------------------:");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|   Align the borders of the window to fit this box properly before going onwards.                                     |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|   Press any button to continue...                                                                                    |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("*--------------------------------------------------------=<O>=---------------------------------------------------------*");
        }
        public static void MapTemplate()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                           11111111111111111111111111111111111111112222222222222222222222222222       |");
            Console.WriteLine("|       11112222333344445555666677778888999900001111222233334444555566667777888899990000111122223333444455556666       |");
            Console.WriteLine("|      1░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      1░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      2░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      2░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      3░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      3░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("]      4░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       [");
            Console.WriteLine("O      4░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       O");
            Console.WriteLine("]      5░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       [");
            Console.WriteLine("|      5░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      6░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      6░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      7░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      7░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      8░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      8░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      9░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|      9░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|     10░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|     10░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░       |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
        }
        public static void Map1(int x, int y)
        {
            Console.SetCursorPosition(0, 0);
            string no_thing = "▒▒▒▒";
            string something = "████";
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|   Robot movement test                                                                                                |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|    - use arrow keys to move around                                                                                   |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine($"|       {(y == 1 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 1 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 2 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 2 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 3 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 3 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"]       {(y == 4 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 26 ? something : no_thing)}       [");
            Console.WriteLine($"O       {(y == 4 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 26 ? something : no_thing)}       O");
            Console.WriteLine($"]       {(y == 5 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 26 ? something : no_thing)}░░░░   [");
            Console.WriteLine($"|       {(y == 5 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 26 ? something : no_thing)}░░░░   |");
            Console.WriteLine($"|       {(y == 6 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 6 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 7 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 7 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 8 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 8 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 9 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 9 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
        }
        public static void Map2(int x, int y)
        {
            Console.SetCursorPosition(0, 0);
            string no_thing = "▒▒▒▒";
            string something = "████";
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|   Robot movement test                                                                                                |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|    - use arrow keys to move around                                                                                   |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine($"|       {(y == 1 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 1 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 1 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 2 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 2 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 2 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 3 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 3 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 3 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"]       {(y == 4 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 26 ? something : no_thing)}       [");
            Console.WriteLine($"O       {(y == 4 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 4 && x == 26 ? something : no_thing)}       O");
            Console.WriteLine($"]   ░░░░{(y == 5 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 3 ? something : no_thing)}" +
                                        $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓" +
                                        $"{(y == 5 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 26 ? something : no_thing)}       [");
            Console.WriteLine($"|   ░░░░{(y == 5 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 3 ? something : no_thing)}" +
                                        $"▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓" +
                                        $"{(y == 5 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 5 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 6 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 6 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 6 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 7 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 7 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 7 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 8 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 8 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 8 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 9 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine($"|       {(y == 9 && x == 1 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 2 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 3 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 4 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 5 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 6 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 7 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 8 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 9 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 10 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 11 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 12 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 13 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 14 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 15 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 16 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 17 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 18 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 19 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 20 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 21 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 22 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 23 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 24 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 25 ? something : no_thing)}" +
                                        $"{(y == 9 && x == 26 ? something : no_thing)}       |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("|                                                                                                                      |");
            Console.WriteLine("#--------------------------------------------------------=<O>=---------------------------------------------------------#");
        }
    }
}
