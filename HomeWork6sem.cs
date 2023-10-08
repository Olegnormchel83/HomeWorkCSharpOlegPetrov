// ДОМАШНЕЕ ЗАДАНИЕ (6 СЕМИНАР)

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// System.Console.WriteLine("Сейчас вы будете вводить числа по одному. Сколько чисел желаете ввести? ");
// int countUserNumbers = Convert.ToInt32(Console.ReadLine());
// double[] arrayOfUsersNumbers = new double[countUserNumbers];

// void ReadUsersNumbers(int count, double[] array)
// {
//     for(int i = 0; i < count; i++)
//         {
//             System.Console.Write($"Введите {i + 1} число: ");
//             array[i] = Convert.ToInt32(Console.ReadLine());
//         }
// }


// int CountPositiveUsersNumbers(double[] array)
// {
//     int countPositive = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) { countPositive++; };
//     }
//     return countPositive;
// }

// ReadUsersNumbers(countUserNumbers, arrayOfUsersNumbers);
// System.Console.WriteLine($"Среди введенных вами чисел есть {CountPositiveUsersNumbers(arrayOfUsersNumbers)} положительных.");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// System.Console.WriteLine("Две прямые заданы следующими уравнениями: \n1) y = k1 * x + b1\n2) y = k2 * x + b2\n\n" + 
// "Введите коэффициенты b1, k1, b2 и k2, чтобы узнать точку пересечения этих прямых:");

// System.Console.Write("b1 = ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("k1 = ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("b2 = ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// System.Console.Write("k2 = ");
// double k2 = Convert.ToDouble(Console.ReadLine());

// void IntersectionPoint(double b1, double k1, double b2, double k2)
// {
//     double x, y;

//     x = (b1-b2)/(k2-k1);
//     y = k1 * x + b1;

//     System.Console.WriteLine($"({Math.Round(x, 2)}; {Math.Round(y, 2)})");
// }

// System.Console.Write($"Данные прямые пересекаются в точке: ");
// IntersectionPoint(b1, k1, b2, k2);