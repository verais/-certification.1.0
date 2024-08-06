// ----------------------------------------------------------------------
// Задача 2: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// ----------------------------------------------------------------------
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }

    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m2 = InputNumber("M: ");
int n2 = InputNumber("N: ");

int result2 = Akkerman(m2, n2);
Console.WriteLine(result2);
