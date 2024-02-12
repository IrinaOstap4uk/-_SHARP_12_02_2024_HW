//Задача 1 - Задайте значения M и N. Напишите программу, которая выведет
//все натуральные числа в промежутке от M до N. Использовать рекурсию, не
//использовать циклы.


Console.WriteLine("ВВедение символов от M до N: ");

int m = int.Parse(Console.ReadLine()!);
int n = int.Parse(Console.ReadLine()!);

PrintNumbersInRange(m, n);

static void PrintNumbersInRange(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        m++;
        PrintNumbersInRange(m, n);
    }
}

