class Program
{
     static void Main()
    {

        StartOfCalculations:

        Console.WriteLine("введіть x1: ");
        string s = Console.ReadLine();
        double xa = double.Parse(s);

        Console.WriteLine("введіть x2: ");
        string sb = Console.ReadLine();
        double xb = double.Parse(sb);

        double y;

        y = (1 / (4 + xb)) * (Math.Sqrt(Math.Pow(Math.Cos(Math.Exp(xb / xa)), 2)));

        Console.WriteLine($"y = {y:f6}"); 

        Console.Write("Повторити розрахунок (y - так) ? ");
        ConsoleKeyInfo pressedKey = Console.ReadKey();
        Console.WriteLine();
        if (pressedKey.Key == ConsoleKey.Y)
        {
            Console.WriteLine();
            goto StartOfCalculations;   
        }
    }   
} 
       
    





