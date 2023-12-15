namespace LB1
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Console.Write("Введіь значення X: ");
            string sx = Console.ReadLine();
            double x = Double.Parse(sx);

            double x1 = x;
            double x2 = 3 * x;

            double y = Math.Cos(Math.Sqrt(x2) + 34 * x1) - 4 * Math.Sin(x2);
            Console.WriteLine("X1 = " + Math.Round(x1, 4) + "\t" + "x2 = " + Math.Round(x2, 4) + "\t" + "Y = " + Math.Round(y, 4));
        }
    }
}