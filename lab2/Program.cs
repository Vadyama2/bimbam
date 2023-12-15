class Program
{
 void Main()
    {
        Console.WriteLine("введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        double x1 = x * 2;
        double x2 = x * 3;

        double y = Math.Sqrt((Math.Pow(x2, 2) + x1 / x2) / (16 * x1 * x2));
        Console.WriteLine($"X1 = {x1:E3}\tX2 = {x2:E3}\tY = {y:E3}");
    }
}









