using System;

namespace lab4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter array size:");
            int ArrSize = int.Parse(Console.ReadLine());

            double[] arr = new double[ArrSize];
            double x;

            for (int i = 0; i < ArrSize; i++)
            {
                if (i % 2 == 0)
                {
                    x = i + 0.5;
                }
                else
                {
                    x = i;
                }
                arr[i] = fx(x);
            }

            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("Sorted and reversed array:");

            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                Console.WriteLine("arr[{0:00}] = {1:0.0000}", i, arr[i]);
            }

            double aAvg = 0;
            for (int i = arr.GetLowerBound(0); i <= arr.GetUpperBound(0); i++)
            {
                aAvg += arr[i];
            }
            aAvg = aAvg / arr.GetLength(0);


            Console.WriteLine("Мінімальне значення масиву:" + arr[arr.GetUpperBound(0)]);
            Console.WriteLine("Максимальне значення масиву:" + arr[arr.GetLowerBound(0)]);
            Console.WriteLine("Середнє значення масиву:" + aAvg);


            double x1 = 2.76;
            double x2 = 0.5;
            double result = Math.Sqrt((Math.Pow(x2, 2) + (x1 / x2)) / (16 * x1 * x2));

            Console.WriteLine("Завдання №2\n" + "1)\t" + result);
        }

        static double fx(double x)
        {
            return x * x + 2 * x + 1;
        }
    }
}

