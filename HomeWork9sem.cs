/*
ДОМАШНЕЕ ЗАДАНИЕ (9 СМЕИНАР)

Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

/*
void ShowNums(int N)
{
    if (N > 0)
    {
        System.Console.Write(N + " ");
        ShowNums(N - 1);
    }
}

System.Console.Write("Введите любое число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
ShowNums(userNumber);
*/



/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

/*
int CalcAmount(int m, int n)
{
    if (m < n)
    {
        return CalcAmount(m, n - 1) + n;
    }
    else if (m > n)
    {
        return CalcAmount(m - 1, n) + m;
    }
    else return m;
}

System.Console.WriteLine("Введите 2 любых числа, а я найду сумму в заданном промежутке: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int userNumber2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма чисел в заданном промежутке: {CalcAmount(userNumber1, userNumber2)}");
*/



/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
double AkkermanFunc(double m, double n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if(m > 0 && n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
    else return 0;
}

System.Console.Write("Калькулятор функции Аккермана\nВведите значение m: ");
double m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение n: ");
double n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"A(m, n) = {AkkermanFunc(m, n)}");
*/