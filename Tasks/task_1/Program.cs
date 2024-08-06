// ----------------------------------------------------------------------
// Задача 1: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N. Использовать рекурсию,
// не использовать циклы.
// ----------------------------------------------------------------------
int InputNumber(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine());
}

int m1 = InputNumber("M: ");
int n1 = InputNumber("N: ");

int min1 = Math.Min(m1, n1);
int max1 = Math.Max(m1, n1);

void OutputNumbersBetween(int min, int max)
{
    Console.Write(min + " ");

    if (min == max)
    {
        return;
    }

    OutputNumbersBetween(min + 1, max);
}

OutputNumbersBetween(min1, max1);
Console.WriteLine();
