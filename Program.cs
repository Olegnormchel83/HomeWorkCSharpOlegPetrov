﻿// ДОМАШНЕЕ ЗАДАНИЕ (1 СЕМИНАР)

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Input two numbers: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// int num_2 = Convert.ToInt32(Console.ReadLine());

// if (num_1 > num_2)
// {
//     Console.WriteLine($"a = {num_1}; b = {num_2} -> max = {num_1}");
// }
// else
// {
//     Console.WriteLine($"a = {num_1}; b = {num_2} -> max = {num_2}");
// }



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// System.Console.WriteLine("Input 3 numbers: ");
// int num_3 = Convert.ToInt32(Console.ReadLine());
// int num_4 = Convert.ToInt32(Console.ReadLine());
// int num_5 = Convert.ToInt32(Console.ReadLine());
// int[] array = {num_3, num_4, num_5};
// int max_number = 0;

// for (int i = 0; i < 2; i++)
// {
//     Console.Write($"{array[i]}, ");
//     if (array[i] > max_number)
//     {
//         max_number = array[i];
//     }
// }

// Console.Write($"{array[2]} -> max = {max_number}");



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.WriteLine("Input your number: ");
// int num_6 = Convert.ToInt32(Console.ReadLine());

// if (num_6 % 2 == 0)
// {
//     Console.Write($"{num_6} -> Number is even");
// }
// else
// {
//     Console.Write($"{num_6} -> Number is uneven");
// }



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// System.Console.WriteLine("Input your number: ");
// int num_7 = Convert.ToInt32(Console.ReadLine());

// Console.Write($"{num_7} -> ");

// for (int i = 2; i < num_7-1; i+=2)
// {
//     Console.Write($"{i}, ");
// }
// if (num_7 % 2 == 0)
// {
//     Console.Write(num_7);
// }
// else
// {
//     Console.Write(num_7-1);
// }





// ДОМАШНЕЕ ЗАДАНИЕ (2 СЕМИНАР)

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите трехзначное число: ");
// int num_8 = Convert.ToInt32(System.Console.ReadLine());
// if (num_8 >= 100 && num_8 <= 999)
// {
//     System.Console.Write($"{num_8} -> ");
//     num_8 = num_8 / 10 % 10;
//     System.Console.Write(num_8);
// }
// else
// {
//     System.Console.WriteLine("ОШИБКА! Число не трехзначное. До свидания!)");
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

