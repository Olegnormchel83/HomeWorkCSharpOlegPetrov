// ДОМАШНЕЕ ЗАДАНИЕ (4 СЕМИНАР)

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Degree(int main_number, int degree_number)
// {
//     int result = 1;
//     for (int i = 1; i <= degree_number; i++)
//     {
//         result *= main_number;
//     }
//     return result;
// }

// System.Console.WriteLine("Введите число 1: ");
// int users_number_1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите число 2: ");
// int users_number_2 = Convert.ToInt32(Console.ReadLine());

// System.Console.Write($"Число 1 в степени числа 2 -> {Degree(users_number_1, users_number_2)}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumbersInNumber(int number)
// {
//     int result = 0;

//     while (number > 0)
//     {
//         result += number % 10;
//         number /= 10;
//     }

//     return result;
// }

// System.Console.WriteLine("Введите число: ");
// int users_number_1 = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine($"Сумма цифр в введенном числе -> {SumNumbersInNumber(users_number_1)}");



// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min_value = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int max_value = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min_value, max_value);
// System.Console.Write("Random array - > ");
// PrintArray(myArray);