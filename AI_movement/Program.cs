namespace AI_movement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scenes.Allignment();
            ConsoleKey keyPress = Console.ReadKey(true).Key;
            bool control = true;
            int x = 45;
            int y = 10;
            int where = 1;
            while (control)
            {
                if (where == 1) { Scenes.Map1(x, y); } // show current map and position
                else if (where == 2) { Scenes.Map2(x, y); }


                keyPress = Console.ReadKey(true).Key;
                if (keyPress == ConsoleKey.UpArrow)
                {
                    if (y != 1 && where == 1)
                    {
                        y--;
                    }
                    else if (y != 1 && where == 2)
                    {
                        if (y == 10)
                        {
                            if ((x > 6 && x < 49) == false)
                            {
                                y--;
                            }
                        }
                        else
                        {
                            y--;
                        }
                    }
                }
                else if (keyPress == ConsoleKey.DownArrow)
                {
                    if (y != 18 && where == 1)
                    {
                        y++;
                    }
                    else if (y != 18 && where == 2)
                    {
                        if (y == 8)
                        {
                            if ((x > 6 && x < 49) == false)
                            {
                                y++;
                            }
                        }
                        else
                        {
                            y++;
                        }
                    }
                }
                else if (keyPress == ConsoleKey.LeftArrow)
                {
                    if (x == 1 && y == 10 && where == 2)
                    {
                        where = 1;
                        x = 52;
                        y = 10;
                    }
                    else if (x != 1 && where == 1)
                    {
                        x--;
                    }
                    else if (x != 1 && where == 2)
                    {
                        if (x == 49)
                        {
                            if (y != 9)
                            {
                                x--;
                            }
                        }
                        else
                        {
                            x--;
                        }
                    }
                }
                else if (keyPress == ConsoleKey.RightArrow)
                {
                    if (x == 52 && y == 10 && where == 1)
                    {
                        where = 2;
                        x = 1;
                        y = 10;
                    }
                    else if (x != 52 && where == 1)
                    {
                        x++;
                    }
                    else if (x != 52 && where == 2)
                    {
                        if (x == 6)
                        {
                            if (y != 9)
                            {
                                x++;
                            }
                        }
                        else
                        {
                            x++;
                        }
                    }
                }
                else if (keyPress == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}