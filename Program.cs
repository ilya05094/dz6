// Задача 41: Пользователь вводит с клавиатуры M чисел в одну линию.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.



// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = arr.Count(x => x > 0);
// Console.WriteLine($"Количество элементов > 0: {count}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

// double pointX;
// double pointY;

// Console.Write("Прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2, Введите по очереди b1, k1, b2 и k2 одной строкой через пробел:");

// int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
// int a = arr[1];
// int b = arr[3];
// int c = arr[0];
// int d = arr[2];

// if (a == b)
// {
//     Console.WriteLine("Прямые с такими параметрами параллельны");
// }
// else
// {
//     pointX = (double)(d - c) / (a - b);
//     pointY = (double)a * (d - c) / (a - b) + c;
//     Console.WriteLine("Координаты точки пересечения двух прямых:");
//     Console.WriteLine($"Х: {pointX:0.00}");
//     Console.WriteLine($"Y: {pointY:0.00}");
// }