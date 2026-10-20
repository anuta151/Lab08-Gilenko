using System;

namespace Lab08_Gilenko
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            PrintLine();
            Console.WriteLine("Отчёт");
            PrintLine();
            PrintHeader("Результаты");
            PrintHeader("Итоги");

            // Задание 2.1
            Console.WriteLine(Max(3, 5));
            Console.WriteLine(Max(10, 2));
            Console.WriteLine(Max(-1, -7));

            // Задание 2.2
            Console.WriteLine(IsEven(4));
            Console.WriteLine(IsEven(7));
            Console.WriteLine(IsEven(0));

            // Задание 3
            int[] data = { 120, 45, 300, 80, 15, 210 };
            Console.WriteLine(Average(data));
            Console.WriteLine(CountGreater(data, 100));

            // Задание 4
            double c1 = 0;
            Console.WriteLine($"{c1} °C = {ToFahrenheit(c1)} °F");
            double c2 = 100;
            Console.WriteLine($"{c2} °C = {ToFahrenheit(c2)} °F");
            double c3 = 37;
            Console.WriteLine($"{c3} °C = {ToFahrenheit(c3)} °F");

            // Задание 5
            Console.WriteLine(Factorial(5));
            Console.Write("Простые числа от 2 до 50: ");
            for (int i = 2; i <= 50; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();

            // Задание 6
            int a = ReadPositive("Введите первое положительное число: ");
            int b = ReadPositive("Введите второе положительное число: ");
            Console.WriteLine($"Сумма: {a + b}");

            // Итоговая задача: Меню-калькулятор
            bool running = true;
            while (running)
            {
                Console.WriteLine("\n Меню");
                Console.WriteLine("1 — Сумма двух чисел");
                Console.WriteLine("2 — Максимум двух чисел");
                Console.WriteLine("3 — Факториал");
                Console.WriteLine("4 — Проверка на чётность");
                Console.WriteLine("0 — Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        int x1 = ReadPositive("Введите первое число: ");
                        int x2 = ReadPositive("Введите второе число: ");
                        Console.WriteLine($"Сумма: {x1 + x2}");
                        break;
                    case "2":
                        int m1 = ReadPositive("Введите первое число: ");
                        int m2 = ReadPositive("Введите второе число: ");
                        Console.WriteLine($"Максимум: {Max(m1, m2)}");
                        break;
                    case "3":
                        int f = ReadPositive("Введите n: ");
                        Console.WriteLine($"{f}! = {Factorial(f)}");
                        break;
                    case "4":
                        int e = ReadPositive("Введите число: ");
                        Console.WriteLine(IsEven(e) ? "Чётное" : "Нечётное");
                        break;
                    case "0":
                        Console.WriteLine("До свидания!");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта");
                        break;
                }
            }

            // Дополнительное задание
            Console.WriteLine($"Gcd(48, 18) = {Gcd(48, 18)}");
            Console.WriteLine($"Lcm(4, 6) = {Lcm(4, 6)}");
        }

        // ---- Методы ----

        // Задание 1
        static void PrintLine()
        {
            Console.WriteLine("^_^");
        }

        static void PrintHeader(string title)
        {
            PrintLine();
            Console.WriteLine(title);
            PrintLine();
        }

        // Задание 2.1
        static int Max(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        // Задание 2.2
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        // Задание 3
        static double Average(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            return (double)sum / arr.Length;
        }

        static int CountGreater(int[] arr, int limit)
        {
            int count = 0;
            foreach (int x in arr)
            {
                if (x > limit)
                {
                    count++;
                }
            }
            return count;
        }

        // Задание 4
        static double ToFahrenheit(double celsius)
        {
            return celsius * 9 / 5 + 32;
        }

        // Задание 5
        static long Factorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        // Задание 6
        static int ReadPositive(string message)
        {
            int value;
            do
            {
                Console.Write(message);
                int.TryParse(Console.ReadLine(), out value);
            } while (value <= 0);
            return value;
        }

        // Дополнительное задание
        static int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static int Lcm(int a, int b)
        {
            return a / Gcd(a, b) * b;
        }
    }
}