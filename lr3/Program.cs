﻿using System;
using static System.Math;  // Импортирование статических методов из System.Math

namespace lr3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Rad;
            int variant;

            Console.WriteLine("1. Прямоугольник");
            Console.WriteLine("2. Круг");
            //Console.WriteLine("3. Треугольник");
            //Console.WriteLine("4. Трапеция");
            //Console.WriteLine("5. Сектор");

            string temp = Console.ReadLine();
            try
            {
                variant = Convert.ToInt32(temp);    // преобразование в число
            }
            catch
            {
                variant = 0;
                Console.WriteLine("Ошибка: введено не число. Пожалуйста, введите корректное число.");
            }

            try
            {
                switch (variant)
                {
                    case 1:
                        Console.Write("Сторона А = ");
                        temp = Console.ReadLine();
                        a = Convert.ToDouble(temp);
                        Console.Write("Сторона B = ");
                        temp = Console.ReadLine();
                        b = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь прямоугольника = " + a * b);
                        break;

                    case 2:
                        Console.Write("Радиус R = ");
                        temp = Console.ReadLine();
                        Rad = Convert.ToDouble(temp);
                        Console.WriteLine("Площадь круга = " + Math.PI * Math.Pow(Rad, 2));
                        break;

                    default:
                        Console.WriteLine("Выбор неверен");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при вводе числа: " + ex.Message);
            }
        }
    }
}
