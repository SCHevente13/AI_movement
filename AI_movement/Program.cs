namespace AI_movement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scenes.Allignment();
            ConsoleKey keyPress = Console.ReadKey(true).Key;
            bool control = true;
            int x = 14;
            int y = 5;
            int where = 1;
            while (control)
            {
                if (where == 1)
                {
                    Scenes.Map1(x, y);
                }
                else if (where == 2)
                {
                    Scenes.Map2(x, y);
                }
                keyPress = Console.ReadKey(true).Key;
                if (keyPress == ConsoleKey.UpArrow)
                {
                    if (y != 1 && where == 1)
                    {
                        y--;
                    }
                    else if (y != 1 && where == 2)
                    {
                        if (y == 6)
                        {
                            if ((x > 3 && x < 24) == false)
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
                    if (y != 9 && where == 1)
                    {
                        y++;
                    }
                    else if (y != 9 && where == 2)
                    {
                        if (y == 4)
                        {
                            if ((x > 3 && x < 24) == false)
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
                    if (x == 1 && y == 5 && where == 2)
                    {
                        where = 1;
                        x = 26;
                        y = 5;
                    }
                    else if (x != 1 && where == 1)
                    {
                        x--;
                    }
                    else if (x != 1 && where == 2)
                    {
                        if (x == 24)
                        {
                            if (y != 5)
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
                    if (x == 26 && y == 5 && where == 1)
                    {
                        where = 2;
                        x = 1;
                        y = 5;
                    }
                    else if (x != 26 && where == 1)
                    {
                        x++;
                    }
                    else if (x != 26 && where == 2)
                    {
                        if (x == 3)
                        {
                            if (y != 5)
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
