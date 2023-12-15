using System;

namespace lab5
{
    class Program
    {
        static void Main()
        {
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

            TV MyTV = new TV();
            MyTV.Model = sModel;
            MyTV.Matrix = sMatrix;
            MyTV.Screen = sScreen;
            MyTV.Hz = int.Parse(sHz);
            MyTV.WiFi = keyWiFi.Key == ConsoleKey.Y;
            MyTV.HDMI = keyHDMI.Key == ConsoleKey.Y;
            MyTV.BimBam = keyBimBam.Key == ConsoleKey.Y;

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Данi про TV: ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Модель: " + MyTV.Model);
            Console.WriteLine("Матриця: " + MyTV.Matrix);
            Console.WriteLine("Покриття екрану: " + MyTV.Screen);
            Console.WriteLine("Кiлькiсть населення: " + MyTV.Hz.ToString() + " Hz");
            Console.WriteLine(MyTV.WiFi ? "У TV є WiFi" : "У TV немає WiFi");
            Console.WriteLine(MyTV.HDMI ? "У TV є HDMI" : "У TV немає HDMI");
            Console.WriteLine(MyTV.BimBam ? "У TV є сабвуфер" : "У TV немає сабвуферу");

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
