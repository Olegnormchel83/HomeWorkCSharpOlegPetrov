// ДОМАШНЕЕ ЗАДАНИЕ (1 СЕМИНАР)

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

// System.Console.WriteLine("Input three-digit number: ");
// int num_8 = Convert.ToInt32(System.Console.ReadLine());
// if (num_8 >= 100 && num_8 <= 999)
// {
//     System.Console.Write($"{num_8} -> ");
//     num_8 = num_8 / 10 % 10;
//     System.Console.Write(num_8);
// }
// else
// {
//     System.Console.WriteLine("Error! Number isn't three-digit.");
// }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// System.Console.WriteLine("Input your number: ");
// int num_9 = Convert.ToInt32(System.Console.ReadLine());
// int num_10 = num_9, i = 0;
// int[] array_2 = new int[0];

// if (num_9 >= 100)
// {
//     while (num_9 > 0)
//     {
//         Array.Resize(ref array_2, array_2.Length + 1);
//         array_2[i] = num_9 % 10;
//         num_9 /= 10;
//         i++;
//     }
//     System.Console.WriteLine($"{num_10} -> {array_2[i-3]}");
// }
// else
// {
//     System.Console.WriteLine($"{num_10} -> третьей цифры нет");
// }



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// System.Console.WriteLine("Input number from 1 to 7: ");
// int num_11 = Convert.ToInt32(Console.ReadLine());

// switch (num_11)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//     System.Console.WriteLine($"{num_11} -> NO");
//     break;

//     case 6:
//     case 7:
//     System.Console.WriteLine($"{num_11} -> YES");
//     break;

//     default:
//     System.Console.WriteLine("ERROR");
//     break;
// }