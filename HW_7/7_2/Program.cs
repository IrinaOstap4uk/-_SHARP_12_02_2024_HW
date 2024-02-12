//Задача 2 - Напишите программу вычисления функции Аккермана
//с помощью рекурсии. Даны два неотрицательных числа m и n.


int Ackermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    
    else if (n > 0 && m == 0)
    {
        return Ackermann(n - 1, 1);
    }
   
    else
    {
        return Ackermann(n - 1, Ackermann(n, m - 1));
    }
}

    
void Value ()
{
    int n = 4;
    int m = 5;
    Console.WriteLine("Ackermann({0}, {1}) = {2}", n, m, Ackermann(n,m));
}

Value(Ackermann);


// у меня не работает программа, ошибку не могу найти.
