//Задача 3 - Задайте произвольный массив. Выведете его
//элементы, начиная с конца. Использовать рекурсию, не
//использовать циклы.

void array ()
{
    int[] array = { 5, 6, 7, 8, 9, 10 };
    PrintArrayReversed(array, array.Length - 1);
}

void PrintArrayReversed(int[] arr, int index)
{
    if (index < 0)
    {
        return;
    }
    else
    {
        PrintArrayReversed(arr, index - 1);
        Console.WriteLine(arr[index]);
    }
}