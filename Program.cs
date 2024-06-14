using System;

Console.Clear();

Console.WriteLine("Welcome to our Running Star program");

int axisX = 1;
int axisY = 1;

Console.SetCursorPosition(axisX, axisY);
Console.Write('*');

try
{
    while (true)
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo keyInput = Console.ReadKey();

            Console.SetCursorPosition(axisX, axisY);
            Console.Write(' ');

            switch (keyInput.Key)
            {
                case ConsoleKey.RightArrow:
                    axisX++;
                    break;
                case ConsoleKey.LeftArrow:
                    axisX--;
                    break;
                case ConsoleKey.UpArrow:
                    axisY--;
                    break;
                case ConsoleKey.DownArrow:
                    axisY++;
                    break;
                default:
                    Console.WriteLine("You pressed the wrong key");
                    break;
            }

            Console.SetCursorPosition(axisX, axisY);
            Console.Write('*');
        }
    }

}catch (Exception exception)

{
    GetExceptionMessage();
}

static void GetExceptionMessage()
{
    int axisXTwo = 0;
    int axisYTwo = 0;
    
    Console.SetCursorPosition(axisXTwo,axisYTwo)
    
    Console.WriteLine("You are out of console !!!");
    Console.WriteLine("Please start the program again !!!");
}




























