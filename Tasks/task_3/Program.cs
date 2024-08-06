// ----------------------------------------------------------------------
// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная
// с конца. Использовать рекурсию, не использовать циклы.
// ----------------------------------------------------------------------

int[] InputArray(string prompt)
{
    Console.Write(prompt);
    string input = Console.ReadLine()!;
    string[] parts = input.Split(' '); // 43 23 61 1 3
    int[] result = new int[parts.Length];

    for (int i = 0; i < parts.Length; i++)
    {
        result[i] = int.Parse(parts[i]);
    }

    return result;
}

int[] input3 = InputArray("ARR: ");

void OutputArrayReverse(int[] array, int i)
{
    if (i < 0)
    {
        return;
    }
    
    Console.Write(array[i] + " ");
    
    OutputArrayReverse(array, i - 1);
}

OutputArrayReverse(input3, input3.Length - 1);
Console.WriteLine();