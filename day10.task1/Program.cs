int x = 0;
Console.WindowWidth = 50;
while (true)
{
    Console.Clear();
    Console.SetCursorPosition(x, 0);
    Console.WriteLine("   ___");
    Console.SetCursorPosition(x, 1);
    Console.WriteLine(" //   \\\\");
    Console.SetCursorPosition(x, 2);
    Console.WriteLine("( o   o )");
    Console.SetCursorPosition(x, 3);
    Console.WriteLine(" \\~(*)~/");
    Console.SetCursorPosition(x, 4);
    Console.WriteLine("  ~~~~~~");
    x++;
    if (x > Console.WindowWidth - 10)
    {
        x = 0;
    }
    Thread.Sleep(50);
}