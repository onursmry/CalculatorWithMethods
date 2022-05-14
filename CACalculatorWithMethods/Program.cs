using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACalculatorWithMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            double myNumber1, myNumber2;
            GreetUser();
            InformUser();

            while (flag == true)
            {
                byte mathOperator = AskOperator();
                CheckOperator(mathOperator);
                myNumber1 = GetNumber();
                myNumber2 = GetNumber();
                CheckDivide(mathOperator, myNumber2);
                double result = Calculate(myNumber1, myNumber2, mathOperator);
                ShowParameters(myNumber1, myNumber2, mathOperator, result);
                flag = Restart(flag);
            }

            Console.ReadLine();
        }

        static void GreetUser()
        {
            Console.WriteLine("Merhaba");
        }

        static void InformUser()
        {
            Console.WriteLine("Bu bir hesap makinesidir.");
        }

        private static double GetNumber()
        {
            double result = 0;
            Console.WriteLine("Sayı giriniz:");
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Lütfen sadece sayısal bir değer giriniz.");
            }
            return result;
        }

        private static byte AskOperator()
        {
            byte result = 0;
            Console.WriteLine("Bir matematik işlemi seçiniz:");
            Console.WriteLine("1.Toplama\n2.Çıkartma\n3.Bölme\n4.Çarpma");

            while (!byte.TryParse(Console.ReadLine(), out result))
            {
                switch (result)
                {
                    case 1:
                        result = 1;
                        break;
                    case 2:
                        result = 2;
                        break;
                    case 3:
                        result = 3;
                        break;
                    case 4:
                        result = 4;
                        break;
                }
                Console.WriteLine("Lütfen sadece sayısal bir değer giriniz.");
            }
            return result;
        }
        private static void CheckOperator(byte mathOperator)
        {
            while (mathOperator <= 0 || mathOperator >= 5)
            {
                mathOperator = AskOperator();
            }
        }
        private static double CheckDivide(byte mathOperator, double myNumber2)
        {
            if (mathOperator == 3)
            {
                while (myNumber2 == 0)
                {
                    Console.WriteLine("Sayı 0'a bölünemez!!!");
                    Console.WriteLine("Yeni sayı giriniz:");
                    myNumber2 = GetNumber();
                }
            }

            return myNumber2;
        }

        private static double Calculate(double myNumber1, double myNumber2, byte mathOperator)
        {
            double result = 0;

            if (mathOperator == 1)
            {
                result = Addition(myNumber1, myNumber2);
            }
            else if (mathOperator == 2)
            {
                result = Extract(myNumber1, myNumber2);
            }
            else if (mathOperator == 3)
            {
                result = Divide(myNumber1, myNumber2);
            }
            else if (mathOperator == 4)
            {
                result = Multiply(myNumber1, myNumber2);
            }

            return result;
        }

        private static void ShowParameters(double myNumber1, double myNumber2, byte mathOperator, double result)
        {
            if (mathOperator == 1)
            {
                Console.WriteLine($"{myNumber1} + {myNumber2} = {result}");
            }
            else if (mathOperator == 2)
            {
                Console.WriteLine($"{myNumber1} - {myNumber2} = {result}");
            }
            else if (mathOperator == 3)
            {
                Console.WriteLine($"{myNumber1} / {myNumber2} = {result}");
            }
            else if (mathOperator == 4)
            {
                Console.WriteLine($"{myNumber1} * {myNumber2} = {result}");
            }
        }
        private static double Addition(double myNumber1, double myNumber2)
        {
            double result = 0;
            result = myNumber1 + myNumber2;
            return result;
        }
        private static double Extract(double myNumber1, double myNumber2)
        {
            double result = 0;
            result = myNumber1 - myNumber2;
            return result;
        }
        private static double Divide(double myNumber1, double myNumber2)
        {
            double result = 0;
            result = myNumber1 / myNumber2;
            return result;
        }
        private static double Multiply(double myNumber1, double myNumber2)
        {
            double result = 0;
            result = myNumber1 * myNumber2;
            return result;
        }

        private static bool Restart(bool flag)
        {
            Console.WriteLine("Yeni bir giriş yapmak istiyor musunuz? E/H");
            string ans = Console.ReadLine()?.ToUpperInvariant();

            if (ans == "E")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Peki, hoşçakal...");
                Environment.Exit(1);
                return false;
            }
        }
    }
}
