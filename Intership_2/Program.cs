using System;
using System.Collections.Generic;

namespace Intership_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x1, y1, x2, y2; // Число прямоугольников, координаты точек
            List<string> points = new List<string>();
            string str; // Строчка с координатами точки

            do
            {
                N = checkInt("Введите число N: ");
                if ((N < 1) || (N > 100)) Console.WriteLine("Ошибка! N должно быть от 1 до 100!");
            } while ((N < 1) || (N > 100));

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Ввод {0} точки:", i+1);

                x1 = checkInt("Введите координату Х1: ");
                y1 = checkInt("Введите координату Y1: ");
                x2 = checkInt("Введите координату Х2: ");
                y2 = checkInt("Введите координату Y2: ");

                for (int j = x1; j < x2; j++)
                {
                    for (int k = y1; k < y2; k++)
                    {
                        str = j + "," + k; // Формируем строку для записи

                        if (!points.Contains(str)) points.Add(str);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Площадь объединённых прямоугольников = {0}", points.Count);

        }

        static int checkInt(string message)
        {
            int result; // result - проверенная переменная
            bool ok; // Проверка ввода

            do
            {
                Console.Write(message);
                ok = int.TryParse(Console.ReadLine(), out result);
                if (!ok) Console.WriteLine("Ошибка! Введите целое число!");
            } while (!ok);

            return result;
        }
    }
}
