using System;
using System.Threading;

class AnimatedRainbowTextCMD
{
    static void Main(string[] args)
    {
        string[] lines = {
            "To do the bug you need 2 Devices 1 Mobile 1 Computer.",
            "You go to your world and add a prize box",
            "Add an item like a hacked message in a bottle in the prize box",
            "Using your Mobile stand in the gift box that you can see that you can claim the item",
            "Trade your Computer Account and put a normal message in a bottle and accept it \"Don't accept the trade in your Mobile\"",
            "In your Mobile make sure to be quick enough to claim the item from the prize box and accept the trade",
            "You might have issues at first that you aren't fast enough but don't worry the bug is fully working now a days",
            "",
            "This bug can be abused in",
            "Stacking more than 999 Blocks in your inventory",
            "Cloning hacked items",
            "Cloning Pet Levels",
            "Unnaming pets",
            "",
            "Make sure you have the hacked/Item you want to clone in the prize box",
            "",
            "Join our Discord server",
            "https://discord.gg/gtxawp397B"
        };

        ConsoleColor[] rainbowColors = {
            ConsoleColor.Red,
            ConsoleColor.Yellow,
            ConsoleColor.Green,
            ConsoleColor.Cyan,
            ConsoleColor.Blue,
            ConsoleColor.Magenta
        };

        int colorIndex = 0;
        int gradientSteps = 40;
        int delayMilliseconds = 100;

        while (!Console.KeyAvailable)
        {
            Console.Clear();

            foreach (string line in lines)
            {
                int wordIndex = 0;
                string[] words = line.Split(' ');

                foreach (string word in words)
                {
                    foreach (char c in word)
                    {
                        Console.ForegroundColor = rainbowColors[colorIndex];
                        Console.Write(c);
                        colorIndex = (colorIndex + 1) % rainbowColors.Length;
                    }

                    if (wordIndex < words.Length - 1)
                    {
                        Console.Write(' ');
                    }

                    wordIndex++;
                }

                Console.WriteLine();
            }

            Thread.Sleep(delayMilliseconds);

            colorIndex = (colorIndex + 1) % rainbowColors.Length;
            gradientSteps--;

            if (gradientSteps <= 0)
            {
                gradientSteps = 40;
                delayMilliseconds -= 10;

                if (delayMilliseconds < 20)
                {
                    delayMilliseconds = 20;
                }
            }
        }

        Console.ResetColor();
    }
}
