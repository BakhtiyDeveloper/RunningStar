using System;


while (true)
{
    string star = "*";
    Console.WriteLine(star);
    
    ConsoleKeyInfo infoKey = Console.ReadKey(true);
      
    switch (infoKey.Key)
    {
        case ConsoleKey.RightArrow:
            for (int i = 0; i < 1; i++)
            {
                Console.Write("\t");
            }
            break;
        case ConsoleKey.LeftArrow:
            for (int i = 0; i < 1; i++)
            {
                Console.Write("\b");
            }
            break;
        case ConsoleKey.DownArrow:
            for (int i = 0; i < 1; i++)
            {
                Console.Write(star);
            }
            break;
        case ConsoleKey.UpArrow:
            Console.Clear();
            break;        
        default:
            Console.Write(infoKey.KeyChar);
            break;
    }
}
