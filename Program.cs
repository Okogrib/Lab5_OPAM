using System;
namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Шахова дошка 8x8");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Введення даних для дошки");
            int width;
            Console.Write("Введіть ширину дошки: ");
            while (!int.TryParse(Console.ReadLine(), out width) || width <= 0)
            {
                Console.WriteLine("Помилка!");
                Console.Write("Спробуйте ще раз: ");
            }
            int height;
            Console.Write("Введіть висоту дошки: ");
            while (!int.TryParse(Console.ReadLine(), out height) || height <= 0)
            {
                Console.WriteLine("Помилка!");
                Console.Write("Спробуйте ще раз: ");
            }
            Console.WriteLine($"Результат: Дошка {width}x{height}");
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (row == 0 || row == height - 1 || col == 0 || col == width - 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Квадрат n x n");
            int n;
            Console.Write("Введіть розмір квадрата: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Помилка!");
                Console.Write("Спробуйте ще раз: ");
            }
            Console.WriteLine($"Результат: Квадрат {n}x{n}");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (row == 0 || row == n - 1 || col == 0 || col == n - 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}