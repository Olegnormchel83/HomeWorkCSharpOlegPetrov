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





// ДОМАШНЕЕ ЗАДАНИЕ (3 СЕМИНАР)

// void Check_palindrome (int users_number)
// {
//     int palindrome_of_users_number, first_digit_of_users_number, second_digit_of_users_number, third_digit_of_users_number, fourth_digit_of_users_number, fiveth_digit_of_users_number;
//     first_digit_of_users_number = users_number / 10000;
//     second_digit_of_users_number = users_number / 1000 % 10;
//     third_digit_of_users_number = users_number / 100 % 10;
//     fourth_digit_of_users_number = users_number / 10 % 10;
//     fiveth_digit_of_users_number = users_number % 10;
    
//     palindrome_of_users_number = fiveth_digit_of_users_number * 10000 + fourth_digit_of_users_number * 1000 + third_digit_of_users_number * 100 + second_digit_of_users_number * 10 + first_digit_of_users_number;

//     if (palindrome_of_users_number == users_number)
//     {
//         System.Console.WriteLine($"{users_number} -> True");
//     }
//     else
//     {
//         System.Console.WriteLine($"{users_number} -> False");
//     }
// }

// System.Console.WriteLine("Input a 5-digit number: ");
// int users_number = Convert.ToInt32(Console.ReadLine());

// if (users_number >= 10000 && users_number <= 99999)
// {
//     Check_palindrome(users_number);
// }
// else
// {
//     System.Console.WriteLine($"{users_number} -> Число не пятизначное");
// }





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




