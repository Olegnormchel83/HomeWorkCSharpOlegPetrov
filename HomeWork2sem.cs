/*
ДОМАШНЕЕ ЗАДАНИЕ (2 СЕМИНАР)

Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1

System.Console.WriteLine("Input three-digit number: ");
int num_8 = Convert.ToInt32(System.Console.ReadLine());
if (num_8 >= 100 && num_8 <= 999)
{
    System.Console.Write($"{num_8} -> ");
    num_8 = num_8 / 10 % 10;
    System.Console.Write(num_8);
}
else
{
    System.Console.WriteLine("Error! Number isn't three-digit.");
}



Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

System.Console.WriteLine("Input your number: ");
int num_9 = Convert.ToInt32(System.Console.ReadLine());
int num_10 = num_9, i = 0;
int[] array_2 = new int[0];

if (num_9 >= 100)
{
    while (num_9 > 0)
    {
        Array.Resize(ref array_2, array_2.Length + 1);
        array_2[i] = num_9 % 10;
        num_9 /= 10;
        i++;
    }
    System.Console.WriteLine($"{num_10} -> {array_2[i-3]}");
}
else
{
    System.Console.WriteLine($"{num_10} -> третьей цифры нет");
}



Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

System.Console.WriteLine("Input number from 1 to 7: ");
int num_11 = Convert.ToInt32(Console.ReadLine());

switch (num_11)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
    System.Console.WriteLine($"{num_11} -> NO");
    break;

    case 6:
    case 7:
    System.Console.WriteLine($"{num_11} -> YES");
    break;

    default:
    System.Console.WriteLine("ERROR");
    break;
}
*/