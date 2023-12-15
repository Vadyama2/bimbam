using System;

namespace lab6
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введiть кількість телевізорів:");
            string items = Console.ReadLine();
            TV[] tvArray = new TV[int.Parse(items)];

            for (int i = 0; i < tvArray.Length; i++)
            {
                Console.WriteLine($"Введiть данi для телевізора #{i + 1}:");
                Console.Write("Введiть назву моделі: ");
                string sModel = Console.ReadLine();
                Console.Write("Введiть матрицю: ");
                string sMatrix = Console.ReadLine();
                Console.Write("Введiть покриття екрану: ");
                string sScreen = Console.ReadLine();
                Console.Write("Введiть частоту герцовки: ");
                string sHz = Console.ReadLine();
                Console.Write("Чи є телевізора WiFi? (y-так, n-нi): ");
                ConsoleKeyInfo keyWiFi = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Чи є у нього HDMI вихід? (y-так, n-нi): ");
                ConsoleKeyInfo keyHDMI = Console.ReadKey();
                Console.WriteLine();
                Console.Write("Чи є у нього сабвуфер? (y-так, n-нi): ");
                ConsoleKeyInfo keyBimBam = Console.ReadKey();
                Console.WriteLine();

                TV newTV = new TV();
                newTV.Model = sModel;
                newTV.Matrix = sMatrix;
                newTV.Screen = sScreen;
                newTV.Hz = int.Parse(sHz);
                newTV.WiFi = keyWiFi.Key == ConsoleKey.Y;
                newTV.HDMI = keyHDMI.Key == ConsoleKey.Y;
                newTV.BimBam = keyBimBam.Key == ConsoleKey.Y;

                tvArray[i] = newTV;
            }

            for (int i = 0; i < tvArray.Length; i++)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Данi про TV #{i + 1}: ");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Модель: " + tvArray[i].Model);
                Console.WriteLine("Матриця: " + tvArray[i].Matrix);
                Console.WriteLine("Покриття екрану: " + tvArray[i].Screen);
                Console.WriteLine($"Кiлькiсть населення: {tvArray[i].Hz} Hz");
                Console.WriteLine(tvArray[i].WiFi ? "У TV є WiFi" : "У TV немає WiFi");
                Console.WriteLine(tvArray[i].HDMI ? "У TV є HDMI" : "У TV немає HDMI");
                Console.WriteLine(tvArray[i].BimBam ? "У TV є сабвуфер" : "У TV немає сабвуферу");
                Console.WriteLine("------------------------------------------------");
            }

            Console.ReadKey();
        }
    }

    class TV
    {
        public string Model;
        public string Matrix;
        public string Screen;
        public int Hz;
        public bool WiFi;
        public bool HDMI;
        public bool BimBam;
    }
}
